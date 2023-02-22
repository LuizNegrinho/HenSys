﻿namespace EstrelaNegra.API.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public string UserFullName { get; set; }
        public DateTime UserJoinDate { get; set; }
    }
}