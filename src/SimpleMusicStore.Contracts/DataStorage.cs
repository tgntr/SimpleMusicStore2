﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMusicStore.Contracts
{
	public interface DataStorage
	{
		Task Upload(IFormFile file);
	}
}
