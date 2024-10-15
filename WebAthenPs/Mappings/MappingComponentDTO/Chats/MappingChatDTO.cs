using System;
using System.Collections.Generic;
using System.Linq;
using WebAthenPs.API.Entities;
using WebAthenPs.API.Entities.Components.ChatEntities;
using WebAthenPs.Models.DTOs.Components.Chats;

namespace WebAthenPs.API.Mappings.MappingComponentDTO
{
    public static class MappingChatDTO
    {
        public static IEnumerable<ChatDTO> ConverterChatsParaDTO(this IEnumerable<Chat> chats)
        {
            return chats?.Select(chat => new ChatDTO
            {
                ChatId = chat.ChatId,
                Participants = chat.Participants.Select(p => new ChatParticipantDTO
                {
                    ChatId = p.ChatId,
                    UserId = p.User.Id, // Usando p.User.Id
                }).ToList(),
                Messages = chat.Messages.Select(m => new MessageDTO
                {
                    MessageId = m.MessageId,
                    Content = m.Content,
                    Timestamp = m.Timestamp,
                    SenderId = m.User.Id, // Usando m.User.Id
                    ChatId = m.Chat.ChatId // Usando m.Chat.ChatId
                }).ToList()
            }) ?? Enumerable.Empty<ChatDTO>();
        }

        public static ChatDTO ConverterChatParaDTO(this Chat chat)
        {
            return new ChatDTO
            {
                ChatId = chat.ChatId,
                Participants = chat.Participants.Select(p => new ChatParticipantDTO
                {
                    ChatId = p.ChatId,
                    UserId = p.User.Id // Usando p.User.Id
                }).ToList(),
                Messages = chat.Messages.Select(m => new MessageDTO
                {
                    MessageId = m.MessageId,
                    Content = m.Content,
                    Timestamp = m.Timestamp,
                    SenderId = m.User.Id, // Usando m.User.Id
                    ChatId = m.Chat.ChatId // Usando m.Chat.ChatId
                }).ToList()
            };
        }

        public static Chat CriarChatEmDTO(this ChatDTO chatDTO)
        {
            return new Chat
            {
                ChatId = chatDTO.ChatId,
                Participants = chatDTO.Participants.Select(p => new ChatParticipant
                {
                    ChatId = p.ChatId,
                    UserId = p.UserId // Assume-se que o UserId seja passado corretamente
                }).ToList(),
                Messages = chatDTO.Messages.Select(m => new Message
                {
                    MessageId = m.MessageId,
                    Content = m.Content,
                    Timestamp = m.Timestamp,
                    SenderId = m.SenderId, // Assume-se que o SenderId seja passado corretamente
                    ChatId = m.ChatId // Assume-se que o ChatId seja passado corretamente
                }).ToList()
            };
        }

        public static Chat AtualizarChatDTO(this ChatDTO chatDTO)
        {
            return new Chat
            {
                ChatId = chatDTO.ChatId,
                Participants = chatDTO.Participants.Select(p => new ChatParticipant
                {
                    ChatId = p.ChatId,
                    UserId = p.UserId // Assume-se que o UserId seja passado corretamente
                }).ToList(),
                Messages = chatDTO.Messages.Select(m => new Message
                {
                    MessageId = m.MessageId,
                    Content = m.Content,
                    Timestamp = m.Timestamp,
                    SenderId = m.SenderId, // Assume-se que o SenderId seja passado corretamente
                    ChatId = m.ChatId // Assume-se que o ChatId seja passado corretamente
                }).ToList()
            };
        }

        public static IEnumerable<MessageDTO> ConverterMensagensParaDTO(this IEnumerable<Message> messages)
        {
            return messages?.Select(m => new MessageDTO
            {
                MessageId = m.MessageId,
                Content = m.Content,
                Timestamp = m.Timestamp,
                SenderId = m.User.Id, // Usando m.User.Id
                ChatId = m.Chat.ChatId // Usando m.Chat.ChatId
            }) ?? Enumerable.Empty<MessageDTO>();
        }

        public static MessageDTO ConverterMensagemParaDTO(this Message message)
        {
            return new MessageDTO
            {
                MessageId = message.MessageId,
                Content = message.Content,
                Timestamp = message.Timestamp,
                SenderId = message.User.Id, // Usando message.User.Id
                ChatId = message.Chat.ChatId // Usando message.Chat.ChatId
            };
        }

        public static Message CriarMensagemEmDTO(this MessageDTO messageDTO)
        {
            return new Message
            {
                MessageId = messageDTO.MessageId,
                Content = messageDTO.Content,
                Timestamp = messageDTO.Timestamp,
                SenderId = messageDTO.SenderId, // Assume-se que o SenderId seja passado corretamente
                ChatId = messageDTO.ChatId // Assume-se que o ChatId seja passado corretamente
            };
        }

        public static Message AtualizarMensagemDTO(this MessageDTO messageDTO)
        {
            return new Message
            {
                MessageId = messageDTO.MessageId,
                Content = messageDTO.Content,
                Timestamp = messageDTO.Timestamp,
                SenderId = messageDTO.SenderId, // Assume-se que o SenderId seja passado corretamente
                ChatId = messageDTO.ChatId // Assume-se que o ChatId seja passado corretamente
            };
        }
    }
}
