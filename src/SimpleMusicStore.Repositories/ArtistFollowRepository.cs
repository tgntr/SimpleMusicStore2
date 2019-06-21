﻿using Microsoft.EntityFrameworkCore;
using SimpleMusicStore.Constants;
using SimpleMusicStore.Contracts.Repositories;
using SimpleMusicStore.Data;
using SimpleMusicStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMusicStore.Repositories
{
    public class ArtistFollowRepository : DbRepository<ArtistFollow>, IArtistFollowRepository
    {
        public ArtistFollowRepository(SimpleMusicStoreDbContext db)
            : base(db)
        {
        }

        public async Task Delete(int artistId, string userId)
        {
            var artistFollow = await _set.FindAsync(artistId, userId);
            ValidateThatFollowExists(artistFollow);
            _set.Remove(artistFollow);
        }

        public Task<bool> Exists(int artistId, string userId)
        {
            return _set.AnyAsync(f => f.ArtistId == artistId && f.UserId == userId);
        }

        private static void ValidateThatFollowExists(ArtistFollow artistFollow)
        {
            if (artistFollow == null)
                throw new ArgumentException(ErrorMessages.ARTIST_NOT_FOLLOWED);
        }
    }
}
