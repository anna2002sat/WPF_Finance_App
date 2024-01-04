using Caliburn.Micro;
using HomeExpenses.Helpers;
using HomeExpenses.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeExpenses.ViewModels
{

    public class CategoriesViewModel : Screen
    {
        public ObservableCollection<Category> Categories { get; set; }

        public Category SelectedCategory { get; set; }

        private System.Windows.Forms.DialogResult result { get; set; }
        public void DeleteCategory(Category category)
        {
            result = System.Windows.Forms.MessageBox.Show("Are you sure, you want to delete this item?", "Information", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Categories.Remove(category);
            }
        }
        private WindowManager windowManager = new WindowManager();
        public void EditCategory(Category category)
        {
            windowManager.ShowDialog(new CategoryViewModel(this, category));
        }
        public void AddCategory()
        {
            windowManager.ShowDialog(new CategoryViewModel(this));
        }

        protected override void OnActivate()
        {
            base.OnActivate();
            Categories = new ObservableCollection<Category>(FileHelper.LoadCategories() ?? new List<Category>());
        }

        protected override void OnDeactivate(bool close)
        {
            FileHelper.SaveCategories(Categories.ToList());
            base.OnDeactivate(close);
        }
    }
}
