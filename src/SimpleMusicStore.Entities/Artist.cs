﻿using SimpleMusicStore.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SimpleMusicStore.Entities
{
    public class Artist : Entity<int>
	{
        public Artist()
        {
            Records = new List<Record>();
            Followers = new List<ArtistFollow>();
            ImageUrl = @"https://upload.wikimedia.org/wikipedia/commons/thumb/b/b6/12in-Vinyl-LP-Record-Angle.jpg/330px-12in-Vinyl-LP-Record-Angle.jpg";
        }

        [Required]
        public int DiscogsId { get; set; }

        [Required]
        public string Name { get; set; }

        [Url]
        public string ImageUrl { get; set; }

        public string Description { get; set; }

        //TODO should navigation properties be virtual?
        public ICollection<Record> Records { get; set; }

        public ICollection<ArtistFollow> Followers { get; set; }

    }
}