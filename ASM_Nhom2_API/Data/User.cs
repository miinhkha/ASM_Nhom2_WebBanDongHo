﻿using System;
using System.Collections.Generic;

namespace ASM_Nhom2_API.Data
{
    public class User
    {
        public int UserID { get; set; }
        public string FullName { get; set; }
        public bool? Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Image { get; set; }
        public string? Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<Bill> Bills { get; set; } = new HashSet<Bill>();
    }
}