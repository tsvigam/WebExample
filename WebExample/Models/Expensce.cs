using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebExample.Models
{
    public class Expensce
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Name of Item")]
        [Required]
        public string ItemName { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Positive number!")]
        public int Amount { get; set; }
        public IList<Item> Items { get; set; }
    }
}

