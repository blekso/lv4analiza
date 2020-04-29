using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace lv4_analiza.components
{
    class Dataset
    {
        private List<List<double>> data;
        public Dataset()
        {
            this.data = new List<List<double>>();
        }
        public Dataset(string filePath) : this()
        {
            this.LoadDataFromCSV(filePath);
        }
        public void LoadDataFromCSV(string filePath)
        {
            string[] lines = System.IO.File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                List<double> row =
               new List<double>(Array.ConvertAll(line.Split(','), x => double.Parse(x, CultureInfo.InvariantCulture))); //ispravak greske kod ucitavanja CSV file-a
                this.data.Add(row);
            }
        }
        public IList<List<double>> GetData()
        {
            return
           new System.Collections.ObjectModel.ReadOnlyCollection<List<double>>(this.data);
        }
    }
}
