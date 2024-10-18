using Microsoft.EntityFrameworkCore;
using WebAthenPs.API.Data;
using WebAthenPs.API.Entities.Components.ChatEntities;
using WebAthenPs.API.Repositories.Interfaces.ChatImplementation;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAthenPs.API.Entities;

namespace WebAthenPs.API.Repositories.Implementations.ChatImplementation
{
    public class ChatRepository : IChatRepository
    {
        private readonly ApplicationDbContext _context;

        public ChatRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Chat> CreateChatAsync(Chat chat)
        {
            if (chat == null) throw new ArgumentNullException(nameof(chat));
            await _context.Chats.AddAsync(chat);
            await _context.SaveChangesAsync();
            return chat;
        }

        public async Task<Chat> GetChatByIdAsync(Guid chatId)
        {
            return await _context.Chats
                .Include(c => c.Participants)
                .Include(c => c.Messages)
                .FirstOrDefaultAsync(c => c.ChatId == chatId);
        }

        public async Task<IEnumerable<Chat>> GetChatsByUserIdAsync(string userId)
        {
            return await _context.Chats
                .Include(c => c.Participants)
                .Include(c => c.Messages)
                .Where(c => c.Participants.Any(p => p.UserId == userId))
                .ToListAsync();
        }

        public async Task<Message> AddMessageAsync(Message message)
        {
            if (message == null) throw new ArgumentNullException(nameof(message));
            await _context.Messages.AddAsync(message);
            await _context.SaveChangesAsync();
            return message;
        }

        public async Task<IEnumerable<Message>> GetMessagesByChatIdAsync(Guid chatId)
        {
            return await _context.Messages
                .Where(m => m.ChatId == chatId)
                .ToListAsync();
        }

        public async Task<ChatParticipant> AddParticipantAsync(ChatParticipant participant)
        {
            if (participant == null) throw new ArgumentNullException(nameof(participant));
            await _context.ChatParticipants.AddAsync(participant);
            await _context.SaveChangesAsync();
            return participant;
        }
    }
}
