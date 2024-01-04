using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HomeExpenses.Models;


namespace HomeExpenses.ViewModels 
{
    public class ShellViewModel : Conductor<object>
    {
        public StatisticsViewModel Statistics { get; private set; }

        public TransactionsViewModel Transactions { get; private set; }

        public CategoriesViewModel Categories { get; private set; }
        
        public ShellViewModel()//перехід на сторінку Статистики
        {
            Statistics=new StatisticsViewModel();
            Transactions = new TransactionsViewModel();
            Categories = new CategoriesViewModel();
            StatisticsPage();
        }
        //перехід на сторінку Статистики
        public void StatisticsPage() => ActivateItem(Statistics);
        //перехід на сторінку Бази даних
        public void TransactionPage() => ActivateItem(Transactions);
        //перехід на сторінку категорій
        public void CategoriesPage() => ActivateItem(Categories);
    }
}
