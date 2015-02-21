using FactoryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication3.Models
{
    public class Main_index
    {
        public IHtmlString labels;
        public IHtmlString data;
        public List<Notification> notes;
        public void set_label(List<String> ll)
        {
            labels=JavaScriptConvert.SerializeObject(ll);
        }
        public void set_data(List<int> dd)
        {
            data = JavaScriptConvert.SerializeObject(dd);
        }
        public void set_difference(int value,DataAccountsEntities db)
        {
            if (value == 0)
            {
                DateTime my = System.DateTime.Now;
                List<String> label = new List<String>();
                // set_label(label);
                List<int> daata = new List<int>(7);
                for (int i = -6; i <= 0; i++)
                {
                    DateTime curr = my.AddHours(i);

                    var scoreQuery = from n in db.Notifications where DateTime.Compare(n.date, curr) <= 0 select n.amount;
                    int sum = 0;
                    sum = scoreQuery.DefaultIfEmpty(0).Sum();
                    daata.Add(sum);
                    label.Add(my.AddHours(i).ToString("hh:mm"));
                }
                set_label(label);
                set_data(daata);
            }
            else if(value==1)
            {
                DateTime my = System.DateTime.Now;
               List<String> label = new List<String>();// { my.AddDays(-6).ToString("dd/mm/yy"), my.AddDays(-5).ToString("dd/mm/yy"), my.AddDays(-4).ToString("dd/mm/yy"), my.AddDays(-3).ToString("dd/mm/yy"), my.AddDays(-2).ToString("dd/mm/yy"), my.AddDays(-1).ToString("dd/mm/yy"), my.AddDays(0).ToString("dd/mm/yy") };
               // set_label(label);
                List<int> daata=new List<int>(7);
                for(int i=-6;i<=0;i++)
                {
                    DateTime curr=my.AddDays(i);
                    
                    var scoreQuery = from n in db.Notifications where DateTime.Compare(n.date,curr) <= 0 select n.amount;
                    int sum = 0;
                    sum=scoreQuery.DefaultIfEmpty(0).Sum();
                    daata.Add(sum);
                    label.Add(my.AddDays(i).ToString("dd/MM/yy"));
                }
                set_label(label);
                set_data(daata);
            }
            else if (value == 2)
            {
                DateTime my = System.DateTime.Now;
                List<String> label = new List<String>();// { my.AddDays(-6).ToString("dd/mm/yy"), my.AddDays(-5).ToString("dd/mm/yy"), my.AddDays(-4).ToString("dd/mm/yy"), my.AddDays(-3).ToString("dd/mm/yy"), my.AddDays(-2).ToString("dd/mm/yy"), my.AddDays(-1).ToString("dd/mm/yy"), my.AddDays(0).ToString("dd/mm/yy") };
                // set_label(label);
                List<int> daata = new List<int>(7);
                for (int i = -6; i <= 0; i++)
                {
                    DateTime curr = my.AddDays(i*7);

                    var scoreQuery = from n in db.Notifications where DateTime.Compare(n.date, curr) <= 0 select n.amount;
                    int sum = 0;
                    sum = scoreQuery.DefaultIfEmpty(0).Sum();
                    daata.Add(sum);
                    label.Add(my.AddDays(i*7).ToString("dd/MM"));
                }
                set_label(label);
                set_data(daata);
            }
            else if (value == 3)
            {
                DateTime my = System.DateTime.Now;
                List<String> label = new List<String>();// { my.AddDays(-6).ToString("dd/mm/yy"), my.AddDays(-5).ToString("dd/mm/yy"), my.AddDays(-4).ToString("dd/mm/yy"), my.AddDays(-3).ToString("dd/mm/yy"), my.AddDays(-2).ToString("dd/mm/yy"), my.AddDays(-1).ToString("dd/mm/yy"), my.AddDays(0).ToString("dd/mm/yy") };
                // set_label(label);
                List<int> daata = new List<int>(7);
                for (int i = -6; i <= 0; i++)
                {
                    DateTime curr = my.AddMonths(i);

                    var scoreQuery = from n in db.Notifications where DateTime.Compare(n.date, curr) <= 0 select n.amount;
                    int sum = 0;
                    sum = scoreQuery.DefaultIfEmpty(0).Sum();
                    daata.Add(sum);
                    label.Add(my.AddMonths(i).ToString("MM/yy"));
                }
                set_label(label);
                set_data(daata);
            }
            else if (value == 4)
            {
                DateTime my = System.DateTime.Now;
                List<String> label = new List<String>();// { my.AddDays(-6).ToString("dd/mm/yy"), my.AddDays(-5).ToString("dd/mm/yy"), my.AddDays(-4).ToString("dd/mm/yy"), my.AddDays(-3).ToString("dd/mm/yy"), my.AddDays(-2).ToString("dd/mm/yy"), my.AddDays(-1).ToString("dd/mm/yy"), my.AddDays(0).ToString("dd/mm/yy") };
                // set_label(label);
                List<int> daata = new List<int>(7);
                for (int i = -6; i <= 0; i++)
                {
                    DateTime curr = my.AddYears(i);

                    var scoreQuery = from n in db.Notifications where DateTime.Compare(n.date, curr) <= 0 select n.amount;
                    int sum = 0;
                    sum = scoreQuery.DefaultIfEmpty(0).Sum();
                    daata.Add(sum);
                    label.Add(my.AddYears(i).ToString("yyyy"));
                }
                set_label(label);
                set_data(daata);
            }
            else if (value == 5)
            {
                DateTime my = System.DateTime.Now;
                List<String> label = new List<String>();
                // set_label(label);
                List<int> daata = new List<int>(7);
                for (int i = -6; i <= 0; i++)
                {
                    DateTime curr = my.AddMinutes(i);

                    var scoreQuery = from n in db.Notifications where DateTime.Compare(n.date, curr) <= 0 select n.amount;
                    int sum = 0;
                    sum = scoreQuery.DefaultIfEmpty(0).Sum();
                    daata.Add(sum);
                    label.Add(my.AddMinutes(i).ToString("hh:mm"));
                }
                set_label(label);
                set_data(daata);
            }
        }
    }

}