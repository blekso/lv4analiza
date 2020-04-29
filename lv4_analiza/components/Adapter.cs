using System;
using System.Collections.Generic;
using System.Text;

namespace lv4_analiza.components
{
    class Adapter : IAnalytics
    {
        private Analyzer3rdParty analyticsService;
        public Adapter(Analyzer3rdParty service)
        {
            this.analyticsService = service;
        }
        private double[][] ConvertData(Dataset dataset)
        {
            IList<List<double>> listdata = dataset.GetData();
            

            double[][] data = new double[listdata.Count][];
            int i = 0;
            foreach(List<double>line in listdata)
            {
                data[i] = new double[line.Count];
                data[i] = line.ToArray();
                i++;
            }
            
            return data;
        }
        public double[] CalculateAveragePerColumn(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerColumnAverage(data);
        }
        public double[] CalculateAveragePerRow(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerRowAverage(data);
        }
    }
}
