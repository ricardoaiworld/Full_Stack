using System;
using System.Collections.Generic;

namespace Exercise3
{
    public class HouseholdAccounts
    {
        private List<List<object>> list;
        public int choice = 1;
        public HouseholdAccounts()
        {
            this.list = new List<List<object>>();
            while (choice != 0)
            {
                Console.WriteLine("1:Add Expense. 2:Search Expenses. 3:Search Expenses by Text. 4:Modify Tab. 5:Delete Data. 6:Sort Data. 7:Normalize Description. 8:Quit");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        AddExpense();
                        break;
                    case 2:
                        ShowExpensesbyCategory();
                        break;
                    case 3:
                        ShowCostsbyText();
                        break;
                    case 4:
                        ModifyTab();
                        break;
                    case 5:
                        DeleteData();
                        break;
                    case 6:
                        SortData();
                        break;
                    case 7:
                        NormalizeData();
                        break;
                    case 8:
                        choice = 0;
                        break;
                    default:
                        break;
                }
            } 
        }

        public void AddExpense()
        {
            string date = AddDate();
            string description = AddDescription();
            string category = AddCategory();
            double amount = AddAmount();
            list.Add(new List<object>{ date, description, category, amount});
    
        }
        public string AddDate()
        {
            Console.WriteLine("Enter Date: (YYYYMMDD)");
            string strDate = Console.ReadLine();
            int year = Convert.ToInt32(strDate.Substring(0, 4));
            int month = Convert.ToInt32(strDate.Substring(4, 2));
            int date = Convert.ToInt32(strDate.Substring(6, 2));

            if (1000 <= year && year <= 3000 && 1 <= month && month <= 12 && 1 <= date && date <= 31)
            {
                return strDate;
            }
            else
            {
                Console.WriteLine("Date Invalid");
                return AddDate();
            }
        }
        public string AddDescription()
        {
            Console.WriteLine("Enter Description");
            string strDesp = Console.ReadLine();
            if (strDesp == "")
            {
                Console.WriteLine("Invalid Description");
                return AddDescription();
            }
            return strDesp;
        }
        public string AddCategory()
        {
            Console.WriteLine("Enter Category");
            return Console.ReadLine();
        }
        public double AddAmount()
        {
            Console.WriteLine("Enter Amount");
            return Convert.ToDouble(Console.ReadLine());
        }

        public void ShowExpensesbyCategory()
        {
            Console.WriteLine("Enter the category");
            string input = Console.ReadLine();
            Console.WriteLine("Enter start date (YYYYMMDD)");
            string startDate = Console.ReadLine();
            Console.WriteLine("Enter end date");
            string endDate = Console.ReadLine();
            int cnt = 0;
            for (int i=0; i<list.Count; i++)
            {
                List<object> item = list[i];
                string date = (string)item[0];
                string description = (string) item[1];
                string category = (string)item[2];
                double amount = (double)item[3];
                if (category == input && Convert.ToInt32(startDate)<=Convert.ToInt32(date) && Convert.ToInt32(date) <= Convert.ToInt32(endDate))
                {
                    Console.WriteLine($"{++cnt}-{date.Substring(6, 2)}/{date.Substring(4, 2)}/{date.Substring(0, 4)}-{description}-({category})-({Math.Round(amount, 2)})");
                }
                Console.WriteLine($"Total {cnt} data");
            }

        }

        public void ShowCostsbyText()
        {
            Console.WriteLine("1:Description. 2:Category");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter keyword");
            string keyword = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                List<object> item = list[i];
                string date = (string)item[0];
                string description = (string)item[1];
                string category = (string)item[2];
                double amount = (double)item[3];
                string truncated_desp = description.Length <= 6 ? description : description.Substring(0, 6);
                if ((input == 1 && description.Contains(keyword)) || (input == 2 && category.Contains(keyword)))
                {
                    Console.WriteLine($"{amount}-{date}-{truncated_desp}");
                }
            }
        }

        public void ModifyTab()
        {
        }
        public void DeleteData()
        {
        }
        public void SortData()
        {
            list.Sort((a, b) => {
                int res = String.Compare((string)a[0], (string)b[0]);
                return res != 0 ? res : String.Compare((string)a[1], (string)b[1]);
            });
            
        }
        public void NormalizeData()
        {
            for (int i = 0; i < list.Count; i++)
            {
                List<object> item = list[i];
                string date = (string)item[0];
                string description = (string)item[1];
                string category = (string)item[2];
                double amount = (double)item[3];
                string trimed_description = description.Trim();
                string trimed_category = category.Trim();
                list[i][1] = trimed_description;
                list[i][2] = trimed_category;
                if (trimed_description.ToUpper() ==trimed_description)
                {
                    list[i][1] = trimed_description.Substring(0,1)+trimed_description.ToLower().Substring(1, trimed_description.Length - 1);
                }
            }
        }
    }
}
