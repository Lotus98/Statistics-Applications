using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Reader {
    class StandardDeviation {
        private OnlineMean mean;
        private double stdDev = 0;

        public double computeStdDev(List<double> data) {
            mean = new OnlineMean();
            foreach (double val in data) {
                mean.NewValue(val);
            }
            double resMean = mean.GetAvg();
            foreach (double val in data) {
                stdDev += Math.Pow((val - resMean), 2);
            }
            stdDev = Math.Sqrt(stdDev / data.Count);

            return stdDev;
        }

    }
}
