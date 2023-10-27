using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticsLib {
    public class OnlineCovariance {
        // Data needed
        public OnlineMean meanX, meanY;
        private double sumCross;
        private int n;

        public OnlineCovariance() {
            meanX = new OnlineMean();
            meanY = new OnlineMean();
            sumCross = 0;
            n = 0;
        }

        // Properties
        public double Covariance { get => (sumCross/n); }

        // Methods
        public void AddValues(double x, double y) {
            // Calculate x term before updating the mean of x
            double xTerm = x - meanX.Avg;

            // Update means
            meanX.AddValue(x);
            meanY.AddValue(y);

            // calculate y term
            double yTerm = y - meanY.Avg;

            // Update sum of cross products
            sumCross += xTerm * yTerm;
            n++;
        }


    }
}
