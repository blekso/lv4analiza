using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lv4_analiza.components
{
    class Analyzer3rdParty
    {
        public double[] PerRowAverage(double[][] data)
        {
            int rowCount = data.Length;
            double[] results = new double[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                results[i] = data[i].Average();
            }
            return results;
        }
        public double[] PerColumnAverage(double[][] data)
        {
            int colCount = data[0].Length;
            double[] results = new double[colCount];
            for (int i = 0; i < colCount; i++)
            {
                for(int j = 0; j < data.Length; j++)
                {
                    results[i] += data[j][i];
                }
                results[i] /= data.Length;
            }

            return results;

        }
    }

}
