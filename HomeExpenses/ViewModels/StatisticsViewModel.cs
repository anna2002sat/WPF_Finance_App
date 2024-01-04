using Caliburn.Micro;
using HomeExpenses.Helpers;
using HomeExpenses.Models;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace HomeExpenses.ViewModels
{
    public class StatisticsViewModel : Screen
    {
        public ObservableCollection<Transaction> AllTransactions { get; set; }
        public ChartValues<decimal> DebitMonthlyValues
        {
            get { return _debitMonthlyValues; }
            set
            {
                _debitMonthlyValues = value;
                NotifyOfPropertyChange();
            }
        }
        public ChartValues<decimal> CreditMonthlyValues
        {
            get { return _creditMonthlyValues; }
            set
            {
                _creditMonthlyValues = value;
                NotifyOfPropertyChange();
            }
        }
        public ObservableCollection<string> DatesAxexX
        {
            get { return _datesAxexX; }
            set
            {
                _datesAxexX = value;
                NotifyOfPropertyChange();
            }
        }

        public ObservableCollection<int> YearBalans
        {
            get { return _yearBalans; }
            set
            {
                _yearBalans = value;
            }
        }
        public int SelectedYear
        {
            get { return _selectedYear; }
            set
            {
                _selectedYear = value;
                NotifyOfPropertyChange();
                UpdateChart();
                UpdatePie();
            }
        }
        private ObservableCollection<string> DateMonth { get; set; }
        
        public ObservableCollection<string> DatesAxexXOrderByDescending
        {
            get { return _datesAxexXOrderByDescending; }
            set
            {
                _datesAxexXOrderByDescending = value;
                NotifyOfPropertyChange();
            }
        }

        public int SelectedMonthIndex
        {
            get { return _selectedMonthIndex; }
            set
            {
                _selectedMonthIndex = value;
                NotifyOfPropertyChange();
                UpdatePie();
            }
        }

        public SeriesCollection SeriesCollection
        {
            get { return _seriesCollection; }
            set
            {
                _seriesCollection = value;
                NotifyOfPropertyChange();
            }
        }

        private ChartValues<decimal> _debitMonthlyValues;
        private ChartValues<decimal> _creditMonthlyValues;
        private SeriesCollection _seriesCollection;
        private ObservableCollection<string> _datesAxexX;
        private ObservableCollection<string> _datesAxexXOrderByDescending;
        private int _selectedYear = DateTime.Now.Year;
        private int _selectedMonthIndex = 0;
        private ObservableCollection<int> _yearBalans;

        public void UpdateChart()
        {
            AllTransactions.Where(t => t.Date.Year == SelectedYear).Select(s => s.Date.Month) // фільтрація по року, вибір місяця із кожного запису
                .Distinct().ToList().ForEach(month => // вибір унікальних міцяців, для кожного місяця  в записі буде такий сценарій... далі
                {
                  var currentDate = DateTime.Parse($"{SelectedYear}-{month}-01"); // створюємо змінну із поточним роком, міцяцем, що і в поточного запису
                   var countDebitTransactions = AllTransactions.Where(t => t.Date.Month == month // фільтруємо всі транзакції по місяцю і по типу Debit
                                                           && t.SelectedCategory.Type == CategoryType.Debit).Count();// рахуємо кількість відфільтрованих записів 

                    var countCreditTransactions = AllTransactions.Where(t => t.Date.Month == month  // фільтруємо всі транзакції по місяцю і по типу Credit
                                                          && t.SelectedCategory.Type == CategoryType.Credit).Count(); // рахуємо кількість відфільтрованих записів 

                    if (countDebitTransactions == 0) // якщо в році немає жодного запису по Debit даного місяця 
                        AllTransactions.Add(new Transaction(currentDate, new Category { Type = CategoryType.Debit}, 0, ""));// то створюємо новий запис із сумою 0

                    if (countCreditTransactions == 0) // якщо в році немає жодного запису по Credit даного місяця 
                        AllTransactions.Add(new Transaction(currentDate, new Category { Type = CategoryType.Credit }, 0, ""));// то створюємо новий запис із сумою 0
                });

            var list = AllTransactions
               .Where(t => t.Date.Year == SelectedYear)
               //Беремо всі транзакції за поточний рік
               .OrderBy(t => t.Date)
               //Сортуємо по даті
               .GroupBy(t => new { t.Date.Month, t.SelectedCategory.Type })
               //групуємо транзакції по унікальному місяцю та типу
               .Select(t => new { Month = t.Key.Month, Type = t.Key.Type, SumAmount = t.Sum(s => s.Amount) })
               //Вибір ключового місяця та додавання всіх коштів у групі
               .ToList();

            DatesAxexX = new ObservableCollection<string>(list.Select(s => s.Month.ToString() + "/"+ SelectedYear.ToString()).Distinct()); //вибір унікальних місяців
            DatesAxexXOrderByDescending= new ObservableCollection<string>(list.OrderByDescending(t => t.Month).Select(s => s.Month.ToString() + "/" + SelectedYear.ToString()).Distinct());
            //сортування дат за спаданням для combobox існуючих місяців
            DateMonth = new ObservableCollection<string>(list.OrderByDescending(t => t.Month).Select(s => s.Month.ToString()).Distinct());
            //Вибір просто місяців без вказаного року
            SelectedMonthIndex = 0; // індекс вибраного місяця = 0 - беремо перший елемент
            DebitMonthlyValues = new ChartValues<decimal>(list.Where(s => s.Type == CategoryType.Debit).Select(s => s.SumAmount)); // фільтрація колекції витрат
            CreditMonthlyValues = new ChartValues<decimal>(list.Where(s => s.Type == CategoryType.Credit).Select(s => s.SumAmount)); // фільтрація колекції Прибутків
        }
        
        public void UpdatePie()
        {
            var PieData = AllTransactions
                .Where(t => t.SelectedCategory.Type == CategoryType.Debit && t.Date.Year == SelectedYear && t.Date.Month.ToString()== DateMonth[SelectedMonthIndex])
                // фільтр записів по вибраному року і місяцю
                .GroupBy(t => new { t.SelectedCategory.Name})
                // групування по унікальній назві категорії
                .Select(t => new { Category = t.Key.Name, SumAmount = t.Sum(s => s.Amount) })
                // вибір із групи ключового ім'я та суми всіх записів у групі
                .ToList();

            SeriesCollection = new SeriesCollection();
            for (int i = 0; i < PieData.Count; i++)
                // прохід по даним кругової діаграми, що створить стільки секторів, скільки є записів із різними категоріями витрат
            {
                SeriesCollection.Add( // добавляємо в кругову діаграму поле
                    new PieSeries
                    {
                        Title = PieData[i].Category,//назва поля = назві ключової категорії
                        Values = new ChartValues<ObservableValue> { new ObservableValue((double)PieData[i].SumAmount) }, 
                        // значення поточного сектору = сумі грошей за поточний вид категорії
                        DataLabels = true
                        // увімкнення підпису на секторі
                    }
                );
            }
        }
        protected override void OnActivate()
        {
            AllTransactions = new ObservableCollection<Transaction>(FileHelper.LoadTransactions() ?? new List<Transaction>());
            YearBalans = new ObservableCollection<int>(AllTransactions.OrderByDescending(t => t.Date.Year).Select(t => t.Date.Year).Distinct().ToList());
            UpdateChart();
            UpdatePie();
            base.OnActivate();
        }
    }
}
