using System;
using System.Collections.Generic;
using System.Text;

namespace lv4_analiza.components
{
    interface IAnalytics
    {
        double[] CalculateAveragePerColumn(Dataset dataset);
        double[] CalculateAveragePerRow(Dataset dataset);
    }
}
