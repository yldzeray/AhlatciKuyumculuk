﻿using AhlatciKuyumculuk.Shop.Application.Models.Dtos.Customers;
using AhlatciKuyumculuk.Shop.Domain.Entities;

namespace AhlatciKuyumculuk.Shop.Application.Models.Dtos.Accounts
{
    public class AccountDto
    {
        public int CustomerId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public string LastUserIp { get; set; }
        public Roles Role { get; set; }

        public CustomerDto Customer { get; set; }
    }
}
