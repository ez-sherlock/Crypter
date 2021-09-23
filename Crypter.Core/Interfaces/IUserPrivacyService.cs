﻿using Crypter.Contracts.Enum;
using System;
using System.Threading.Tasks;

namespace Crypter.Core.Interfaces
{
   public interface IUserPrivacyService
   {
      Task<bool> UpsertAsync(Guid userId, bool allowKeyExchangeRequests, UserVisibilityLevel visibilityLevel, UserItemTransferPermission receiveFilesPermission, UserItemTransferPermission receiveMessagesPermission);
      Task<IUserPrivacy> ReadAsync(Guid userId);

      Task<bool> IsUserViewableByPartyAsync(Guid userId, Guid otherPartyId);
      Task<bool> DoesUserAcceptMessagesFromOtherPartyAsync(Guid userId, Guid otherPartyId);
      Task<bool> DoesUserAcceptFilesFromOtherPartyAsync(Guid userId, Guid otherPartyId);
   }
}
