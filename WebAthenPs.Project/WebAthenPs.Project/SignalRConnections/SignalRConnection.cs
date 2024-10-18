using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Threading.Tasks;
using WebAthenPs.Project.Services.Interfaces.User;

namespace WebOllamaChat.Client.SignalConnections
{
    public class SignalRConnection
    {
        public event Action? ConnectionStateChanged;
        public string ConnectionState = string.Empty;
        private readonly NavigationManager _navManager;
        public readonly HubConnection hubConnection;
        private readonly IAuthService authService;

        public SignalRConnection(IAuthService authService, NavigationManager navManager)
        {
            this.authService = authService;
            _navManager = navManager;
            hubConnection = new HubConnectionBuilder()
                .WithUrl(_navManager.ToAbsoluteUri("https://localhost:7171/connect")) // Ajuste a URL para o seu hub de chat
                .Build();
        }

        public async Task StartConnection()
        {
            if (hubConnection.State == HubConnectionState.Disconnected)
            {
                await hubConnection.StartAsync();
                ConnectionState = "Connected"; // Atualiza o estado da conexão
                ConnectionStateChanged?.Invoke();
            }
            GetConnectionState();
        }

        public async Task CloseConnection()
        {
            if (hubConnection.State == HubConnectionState.Connected)
            {
                await hubConnection.StopAsync();
                ConnectionState = "Disconnected"; // Atualiza o estado da conexão
                ConnectionStateChanged?.Invoke();
            }
            GetConnectionState();
        }

        public async Task AddUserToChat(Guid chatId, string userId)
        {
            await hubConnection.InvokeAsync("AddUserToChat", chatId, userId); // Chamada corrigida
        }

        public async Task<Guid> CreateChat()
        {
            var userId = await authService.GetUserIdFromToken(); // Obtém o ID do usuário
            return await hubConnection.InvokeAsync<Guid>("CreateChat", userId);
        }

        public async Task SendMessage(Guid chatId, string message)
        {
            var userId = await authService.GetUserIdFromToken(); // Obtém o ID do usuário
            await hubConnection.InvokeAsync("SendMessage", chatId, message);
        }

        public async Task<string> GetUserConnectionId()
        {
            return await hubConnection.InvokeAsync<string>("GetConnectionId"); // Chama o método GetConnectionId
        }

        public void ReceiveMessage(Action<string, string> handler)
        {
            hubConnection.On<string, string>("ReceiveMessage", (userId, message) =>
            {
                handler(userId, message);
            });
        }

        private void GetConnectionState()
        {
            switch (hubConnection.State)
            {
                case HubConnectionState.Connected:
                    Invoke("Connected");
                    break;
                case HubConnectionState.Connecting:
                    Invoke("Connecting");
                    break;
                case HubConnectionState.Disconnected:
                    Invoke("Disconnected");
                    break;
                default:
                    ConnectionState = "Unknown error occurred";
                    break;
            }
        }

        private void Invoke(string message)
        {
            ConnectionState = message;
            ConnectionStateChanged?.Invoke();
        }
    }
}
