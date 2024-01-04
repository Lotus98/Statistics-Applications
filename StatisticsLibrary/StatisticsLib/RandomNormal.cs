using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticsLib {
    public class RandomNormal {
        private double mean;
        private double stdDev;
        private Random rand = new Random();

        public RandomNormal(double mean, double stdDev) {
            this.mean = mean;
            this.stdDev = stdDev;
        }

    public double Next() {
            double u1 = rand.NextDouble();
            double u2 = rand.NextDouble();
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2);
            return mean + stdDev * randStdNormal;
        }
    }
}
