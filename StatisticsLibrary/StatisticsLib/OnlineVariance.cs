using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticsLib {

    // We can reuse the Covariance class to compute the variance
    public class OnlineVariance : OnlineCovariance{

        public OnlineVariance() : base() { }

        // Properties
        public double Variance { get => this.Covariance; }

        // Methods
        public void AddValue(double x) {
            this.AddValues(x, x);
        }
    }
}
