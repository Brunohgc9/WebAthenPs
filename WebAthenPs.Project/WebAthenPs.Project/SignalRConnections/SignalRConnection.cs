using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using WebAthenPs.Models.DTOs.Components.Chats;
using WebAthenPs.Project.Services.Interfaces.User;

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
            ConnectionState = "Connected";
            ConnectionStateChanged?.Invoke();
        }
        GetConnectionState();
    }

    public async Task CloseConnection()
    {
        if (hubConnection.State == HubConnectionState.Connected)
        {
            await hubConnection.StopAsync();
            ConnectionState = "Disconnected";
            ConnectionStateChanged?.Invoke();
        }
        GetConnectionState();
    }

    public async Task<List<ChatDto>> GetUserChats()
    {
        var userId = await authService.GetUserIdFromToken();
        return await hubConnection.InvokeAsync<List<ChatDto>>("GetUserChats", userId); // Obtém todos os chats relacionados ao usuário
    }

    public async Task AddUserToChat(Guid chatId, string userId)
    {
        await hubConnection.InvokeAsync("AddUserToChat", chatId, userId);
    }

    public async Task<Guid> CreateChat()
    {
        var userId = await authService.GetUserIdFromToken();
        return await hubConnection.InvokeAsync<Guid>("CreateChat", userId);
    }

    public async Task SendMessage(Guid chatId, string message)
    {
        var userId = await authService.GetUserIdFromToken();
        await hubConnection.InvokeAsync("SendMessage", userId, chatId, message);
    }

    public async Task<string> GetUserConnectionId()
    {
        return await hubConnection.InvokeAsync<string>("GetConnectionId");
    }


    public async Task JoinChat(Guid chatId)
    {
        // Associa o cliente ao grupo do chat
        await hubConnection.InvokeAsync("JoinChat", chatId);
    }

    public void ReceiveMessage(Action<string, string> handler)
    {
        // Recebe mensagens enviadas pelo hub
        hubConnection.On<string, string>("ReceiveMessage", (userId, message) =>
        {
            handler(userId, message);
        });
    }

    public async Task<List<ChatMessageDto>> GetChatMessages(Guid chatId)
    {
        var userId = await authService.GetUserIdFromToken();
        return await hubConnection.InvokeAsync<List<ChatMessageDto>>("GetChatMessages", userId, chatId);
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
