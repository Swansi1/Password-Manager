
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace PassMan.Models
{
    [Table("VaultEntries")]
    public class VaultEntry
    {
        public static string? UsersPath { get; set; }

        [Key]
        public int Id { get; set; }

        [Required, DisplayName("Username")]
        public string? UserId { get; set; }

        [Required, DisplayName("Name")]
        public string? Name { get; set; }

        [Required, DisplayName("Password")]
        public string? Password { get; set; }

        [Required, DisplayName("Website")]
        public string? Website { get; set; }

        public User User { get; set; }
    }
}
