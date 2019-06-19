﻿using SimpleMusicStore.Entities;
using SimpleMusicStore.Models.Auth;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMusicStore.Contracts.Services
{
    public interface IServiceValidations
    {
        Task ItemIsInStock(int itemId, IDictionary<int, int> items);
        void ItemIsInCart(int itemId, IDictionary<int, int> items);
        Task RecordIsNotInStore(int id);
        Task LabelIsFollowed(int labelId);
        Task ArtistIsFollowed(int artistId);
        Task RecordIsInWishlist(int recordId);
        Task LabelExists(int labelId);
        Task LabelIsNotFollowed(int labelId);
        Task ArtistIsNotFollowed(int artistId);
        Task ArtistExists(int artistId);
        Task RecordExists(int recordId);
        Task RecordIsNotInWishlist(int recordId);
        void CartIsNotEmpty(IDictionary<int, int> items);
        Task AddressIsValid(int id);
        Task CredentialsAreValid(User user, string pasword);
        Task OrderIsValid(int orderId);
        void SearchTermIsNotEmpty(string searchTerm);
        void FileIsMP3(string contentType);
    }
}
