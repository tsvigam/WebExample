using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebExample.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Borrower { get; set; }
        public string Lender { get; set; }
        public int ExpensceId { get; set; }
        [DisplayName("Item Name")]
        public Expensce ItemName { get; set; }
    }
}
