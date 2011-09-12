using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReportDataLibrary
{
    public class ReportData
    {
        private List<ReportItem> _reportItems;
        public List<ReportItem> ReportItems
        {
            get { return _reportItems; }
            set { _reportItems = value; }
        }

        private string[] group = {"Zero","One","Two","Three","Four","Five","Six"};
        public ReportData()
        {
            Random random = new Random();
            ReportItems = new List<ReportItem>(50);
            string name;
            int age;
            for (int i = 0; i < 500; i++)
            {
                int nameKey = random.Next(0, 6);
                name = group[nameKey];
                age = random.Next(12, 99);
                ReportItem reportItem = new ReportItem{Name = name,Age = age,SortKey = nameKey};
                ReportItems.Add(reportItem);
            }
        }
        public List<ReportItem> Select()
        {
            return _reportItems;
        }
    }

    public class ReportItem
    {
        public string Name { get; set; }
        public int SortKey { get; set; }
        public int Age { get; set; }
    }
}
