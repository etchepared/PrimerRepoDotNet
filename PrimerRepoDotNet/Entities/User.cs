using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using PrimerRepoDotNet.DTOs;

namespace PrimerRepoDotNet.Entities
{
    [Table("Users")]
    public class User
    {
        [Key]
        [Column("user_id")]
        public int Id { get; set; }

        [Column("user_firstName", TypeName = "VARCHAR(100)")]
        public string FirstName { get; set; }
        [Column("user_lastName", TypeName = "VARCHAR(100)")]
        public string LastName { get; set; }
        [Column("user_password", TypeName = "VARCHAR(100)")]
        public string Password { get; set; }
        [Column("user_DNI", TypeName = "VARCHAR(100)")]
        public string DNI { get; set; }
        [Column("user_email", TypeName = "VARCHAR(100)")]
        public string Email { get; set; }
        [Column("user_isDeleted")]
        public bool IsDeleted { get; set; }

        public static implicit operator User(UserRegisterDTO v)
        {
            var user = new User();
            user.FirstName = v.FirstName;
            user.LastName = v.LastName;
            user.Password = v.Password;
            user.DNI = v.DNI;
            user.Email = v.Email;
            return user;
        }
    }
}
