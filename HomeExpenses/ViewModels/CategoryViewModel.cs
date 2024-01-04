using Caliburn.Micro;
using HomeExpenses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeExpenses.ViewModels
{
    public class CategoryViewModel : Screen
    {
        private CategoriesViewModel _parentWindow;
        private string _name;
        public string Name { 
            get { return _name; } 
            set { _name = value;
                NotifyOfPropertyChange(()=>CanSave);
            } 
        }
        public CategoryType Type { get; set; }
        public string Description { get; set; }

        private bool IsEdit = false;
        public bool CanSave { 
            get { return !string.IsNullOrWhiteSpace(Name); }
        }
        private Category CategoryRef;

        public CategoryViewModel(CategoriesViewModel parent)
        {

            this.DisplayName = "New Category";
            _parentWindow = parent;
        }

        public CategoryViewModel(CategoriesViewModel parent, Category category):this(parent)
        {
            this.DisplayName = "Edit Category";
            IsEdit = true;
            CategoryRef = category;
            Name = category.Name;
            Type = category.Type;
            Description = category.Description;
        }
        
        public void OkButton()
        {
            _parentWindow.Categories.Add(new Category(Name, Type, Description));//adding new element to collection
            if (IsEdit)
            {
                _parentWindow.Categories.Remove(CategoryRef); // is item was edited than we delete previous version/data
            }
            TryClose();
        }
        public void CancelButton()
        {
            TryClose();
        }
    }
}
