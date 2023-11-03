//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

using System.Globalization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PassMan.Models
{

    [Table("users")]
    public class User
    {
        public static string? VaultPath { get; set; }

        public User ShallowCopy() => (User)this.MemberwiseClone();

        [Key]
        public int Id { get; set; }

        [Required, DisplayName("Username")]
        public string? Username { get; set; }

        [Required, DisplayName("Password")]
        public string? Password { get; set; }

        [Required, DisplayName("Email")]
        public string? Email { get; set; }

        [Required, DisplayName("Firstname")]
        public string? FirstName { get; set; }

        [Required, DisplayName("Lastname")]
        public string? LastName { get; set; }

        public List<VaultEntry> VaultEntries { get; set; }

    }
}
