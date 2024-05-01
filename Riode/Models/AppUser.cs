﻿using Microsoft.AspNetCore.Identity;

namespace Riode.Models
{
	public class AppUser : IdentityUser
	{
		public string FullName { get; set; }
		public bool IsActive { get; set; }
	}
}
