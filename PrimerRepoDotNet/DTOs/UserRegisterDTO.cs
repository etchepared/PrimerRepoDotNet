﻿namespace PrimerRepoDotNet.DTOs
{
    public class UserRegisterDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string DNI { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }

    }
}
