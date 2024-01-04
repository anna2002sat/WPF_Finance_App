using Caliburn.Micro;
using HomeExpenses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using HomeExpenses.Helpers;
using System.Text.RegularExpressions;

namespace HomeExpenses.ViewModels
{
    public class TransactionViewModel : Caliburn.Micro.Screen
    {
        private DateTime _date = DateTime.Now;
        public DateTime Date 
        {
            get { return _date; }
            set {
                _date = value;
                NotifyOfPropertyChange();// update/notify TransactionView Date about changes
            }
        }
        private Category _selectedCategory;
        public Category SelectedCategory
        {
            get { return _selectedCategory; }
            set
            {
                _selectedCategory = value;
                NotifyOfPropertyChange(); // update/notify TransactionView SelectedCategory about changes
            }
        }

        public ObservableCollection<Category> Categories { get; set; }

        private string _amount;        

        public string Amount {  
            get { return  _amount; } 
            set {
                Regex regex = new Regex(@"^(\d+)?(\.?)(\d+)?$");// regular expression for amount
                Match valid = regex.Match(value); //checking if symbol is a number or a dot 
                if (valid.Success)
                    _amount = value;
                NotifyOfPropertyChange(()=>CanSave); // update CanSave about changes
            } 
        }

        public bool CanSave
        {
            get { return decimal.TryParse(_amount, out DecAmount); } //checks if string amount can be parsed to decimal
        }

        public string Description { get; set; } = "";

        private bool IsEdit = false;
        private Transaction TransactionRef;
        private TransactionsViewModel _parentWindow;

        public TransactionViewModel(TransactionsViewModel parent)
        {
            this.DisplayName = "New Transaction"; //name of the window where we do editing
            _parentWindow = parent;
            var ListCategories = FileHelper.LoadCategories() ?? new List<Category>(); //load a List of Categories and if fuction returns null then we create new empty List
            Categories = new ObservableCollection<Category>(ListCategories.OrderBy(c => c.Name)); //order
            SelectedCategory = Categories?[0];
        }

        public TransactionViewModel(TransactionsViewModel parent, Transaction transaction):this(parent)
        {
            this.DisplayName = "Edit Transaction";
            IsEdit = true;
            TransactionRef = transaction;
            Date = transaction.Date;
            SelectedCategory = transaction.SelectedCategory;
            _amount = transaction.Amount.ToString();
            Description = transaction.Description;
        }
        private decimal DecAmount;
        public void OkButton()
        {

            decimal.TryParse(_amount, out DecAmount);
            _parentWindow.AllTransactions.Add(new Transaction(Date, SelectedCategory, DecAmount, Description));
            if (IsEdit)
                _parentWindow.AllTransactions.Remove(TransactionRef);
            _parentWindow.UpdateData();
            TryClose();
        }
        public void CancelButton()
        {
            TryClose();
        }
       
    }
}
