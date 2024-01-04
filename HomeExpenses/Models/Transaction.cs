using HomeExpenses.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeExpenses.Models
{
    [Serializable()]
    public class Transaction
    {
        public DateTime Date { get; set; }
        public Category SelectedCategory { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; } = "";

        public Transaction(DateTime date, Category category, decimal amount, string description)
        {
            Date = date;
            SelectedCategory = category;
            Amount = amount;
            Description = description;
        }
        public override string ToString() => Date.ToString("dd/MM/yy") + SelectedCategory.Name + Amount.ToString() + Description.ToString();
    }
}
