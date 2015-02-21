using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication3.Models
{
    public class Data_set
    {
        public String fillColor;
        public String strokeColor;
        public String highlightFill;
        public String highlightStroke;
        public List<int> data = new List<int>();
        public Data_set(int i)
        {
            if(i==0)
            {
                fillColor = "rgba(151,187,205,0.5)";
                strokeColor = "rgba(151,187,205,0.8)";
                highlightFill = "rgba(151,187,205,0.75)";
                highlightStroke = "rgba(151,187,205,1)";
            }
            if(i==1)
            {
                fillColor = "rgba(220,220,220,0.5)";
                strokeColor = "rgba(220,220,220,0.8)";
                highlightFill = "rgba(220,220,220,0.75)";
                highlightStroke = "rgba(220,220,220,1)";
            }
        }
    }
    public class Chart_data
    {
        public List<String> labels = new List<string>();
        public List<Data_set> datasets = new List<Data_set>();
    }
}