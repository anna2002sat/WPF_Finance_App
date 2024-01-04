using Caliburn.Micro;
using HomeExpenses.Helpers;
using HomeExpenses.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeExpenses.ViewModels
{
    public class TransactionsViewModel : Caliburn.Micro.Screen
    {
        public List<Transaction> AllTransactions { get; set; }
        public ObservableCollection<Transaction> Transactions { get; set; }
        public Transaction SelectedTransaction { get; set; }
        private decimal _totalCredit;
        private decimal _totalProfit;
        private decimal _totalDebit;

        public decimal TotalCredit {
            get 
            {
                return _totalCredit;
            }
            set 
            {
                _totalCredit = value;
                NotifyOfPropertyChange();
            }
        }
        public decimal TotalDebit{
            get
            {
                return _totalDebit;
            }
            set
            {
                _totalDebit = value;
                NotifyOfPropertyChange();
            }
        }
        public decimal TotalProfit {
            get
            {
                return _totalProfit;
            }
            set
            {
                _totalProfit = value;
                NotifyOfPropertyChange();
            }
        }

        private WindowManager windowManager = new WindowManager();
        private DateTime _strartDate;
        private DateTime _finishDate = DateTime.Now;
        private int _showTypes=0;
        private string _search;
        private DialogResult result { get; set; }

        public DateTime StartDate {
            get {
                return _strartDate;
            } 
            set {
                if (value <= _finishDate)
                {
                    _strartDate = value;
                    NotifyOfPropertyChange();
                    UpdateData();
                }
                else
                    System.Windows.Forms.MessageBox.Show("Given invalid information!\nStarting date should occure before the finishing date!\nTry again...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        } 
        public DateTime FinishDate {
            get 
            {
                return _finishDate;
            } 
            set
            {
                _finishDate = value;
                NotifyOfPropertyChange();
                UpdateData();
            }
        }
        public int ShowTypes {
            get
            { 
                return _showTypes;
            }
            set
            {
                _showTypes = value;
                NotifyOfPropertyChange();
                UpdateData();
            }
        }

        public string Search {
            get
            {
        
                return _search;
            }
            set
            {
                _search = value;
                NotifyOfPropertyChange();
                UpdateData();
            }
        }

        public void ToDefault()
        {
            Search = null;
            ShowTypes = 0;
            if (AllTransactions.Count!=0)
                StartDate = AllTransactions.Min(t => t.Date);
            FinishDate = DateTime.Now;
        }

        public void UpdateData()
        {
            Transactions.Clear();
            var filteredList = AllTransactions //we take original version collection of transactions
                .Where(t => t.Date.Date >= StartDate.Date && t.Date.Date <= FinishDate.Date) // filter by date
                .Where(t => _showTypes == 0 || (int)t.SelectedCategory.Type + 1 == _showTypes) // filter by Categoty Type
                // if category index==0 or category index+1  == chosen category index
                .Where(t => string.IsNullOrWhiteSpace(_search) || t.ToString().ToLower().Contains(_search.ToLower())).ToList(); // filter by search
                // if search fiels is empty || if all content items contains search text
            foreach (var transaction in filteredList)
                Transactions.Add(transaction); // adding all items of filtered list to transaction collection
            CountProfit(); 
        }
        public void CountProfit()
        {
            TotalDebit = Transactions.Where(t => t.SelectedCategory.Type == CategoryType.Debit).Sum(t => t.Amount);
            TotalCredit = Transactions.Where(t => t.SelectedCategory.Type == CategoryType.Credit).Sum(t => t.Amount); 
            TotalProfit = TotalCredit - TotalDebit;
        }
        public void DeleteTransaction(Transaction transaction)
        {
            result = System.Windows.Forms.MessageBox.Show("Are you sure, you want to delete this item?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                AllTransactions.Remove(transaction);
                if (AllTransactions.Count != 0)
                    StartDate = AllTransactions.Min(t => t.Date);
                UpdateData();
            }
        }
        public void AddTransaction()
        {
            windowManager.ShowDialog(new TransactionViewModel(this));
            if (AllTransactions.Count != 0)
                StartDate = AllTransactions.Min(t => t.Date);
            UpdateData();
        }
        public void EditCategory(Transaction transaction)
        {
            windowManager.ShowDialog(new TransactionViewModel(this, transaction));
            if (AllTransactions.Count != 0)
                StartDate = AllTransactions.Min(t => t.Date);
            UpdateData();
        }
        public TransactionsViewModel()
        {
        }
        protected override void OnActivate()
        {
            AllTransactions = new List<Transaction>(FileHelper.LoadTransactions() ?? new List<Transaction>());
            Transactions = new ObservableCollection<Transaction>();
            ToDefault();
            UpdateData();
            base.OnActivate();
        }
        protected override void OnDeactivate(bool close)
        {
            FileHelper.SaveTransactions(AllTransactions.ToList());
            base.OnDeactivate(close);
        }
    }
}
