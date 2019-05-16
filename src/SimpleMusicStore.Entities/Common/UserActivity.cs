﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SimpleMusicStore.Entities.Common
{
	public abstract class UserActivity
	{
		public UserActivity()
		{
			Date = DateTime.UtcNow;
		}

		[Required]
		public string UserId { get; set; }
		public User User { get; set; }

		public DateTime Date { get; set; }
	}
}