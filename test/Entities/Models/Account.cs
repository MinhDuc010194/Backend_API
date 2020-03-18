using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace test.Entities.Models
{
    [Table("account")]
    public class Account
    {
        [Column("AccountId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Date created is required")]
        public DateTime DateCreated { get; set; }

        [Required(ErrorMessage = "Account type is required")]
        public string AccountType { get; set; }

        [Required(ErrorMessage = "Owner Id is required")]
        public Guid OwnerId { get; set; }

        public ICollection<Account> Accounts { get; set; }
    }
}