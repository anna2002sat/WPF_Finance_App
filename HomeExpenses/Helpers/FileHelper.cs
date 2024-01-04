using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using HomeExpenses.Models;

namespace HomeExpenses.Helpers
{
    public static class FileHelper
    {

        private static string _categoryFilePath = "category.bin";

        public static List<Category> LoadCategories() {
            if (!File.Exists(_categoryFilePath)) return null;
            try
            {
                List<Category> categories = new List<Category>();
                using (Stream stream = File.Open(_categoryFilePath, FileMode.Open))
                {

                    BinaryFormatter bin = new BinaryFormatter();
                    categories = (List<Category>) bin.Deserialize(stream);
                    return categories;
                }
            }
            catch (Exception e)
            { }
            return null; 
        }
        public static bool SaveCategories(List<Category> categories)
        {
            try
            {
                using (Stream stream = File.Open(_categoryFilePath, FileMode.Create))
                {

                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, categories);
                    return true;
                }
            }
            catch (Exception e)
            {

            }
            return false;
        }
        private static string _transactionsFilePath = "transactions.bin";

        public static List<Transaction> LoadTransactions()
        {
            if (!File.Exists(_transactionsFilePath)) return null;
            try
            {
                List<Transaction> transactions = new List<Transaction>();
                using (Stream stream = File.Open(_transactionsFilePath, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    transactions = (List<Transaction>)bin.Deserialize(stream);
                    return transactions;
                }
            }
            catch (Exception e)
            { }
            return null;
        }
        public static bool SaveTransactions(List<Transaction> transactions)
        {
            try
            {
                using (Stream stream = File.Open(_transactionsFilePath, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, transactions);
                    return true;
                }
            }
            catch (Exception e)
            {

            }
            return false;
        }
    }
}
