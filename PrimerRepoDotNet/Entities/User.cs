using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PrimerRepoDotNet.Entities
{
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
    }
}
