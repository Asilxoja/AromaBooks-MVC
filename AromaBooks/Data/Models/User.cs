﻿using Microsoft.AspNetCore.Identity;

namespace AromaBooks.Data.Models;

public class User : IdentityUser
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set;} = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string AvatarUrl { get; set; } = string.Empty;
}