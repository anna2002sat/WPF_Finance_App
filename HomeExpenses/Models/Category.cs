using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeExpenses.Models
{
    [Serializable()]
    public enum CategoryType
    {
        Debit, //-
        Credit //+
    }

    [Serializable()]
    public class Category
    {
        public string Name { get; set; }

        public CategoryType Type { get; set; }

        public string Description { get; set; } = "";
        public Category()
        {

        }
        public Category(string _name, CategoryType _type, string _description)
        {
            Name = _name;
            Type = _type;
            Description = _description;
        }
    }
    
    
    
}
