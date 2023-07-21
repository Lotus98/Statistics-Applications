using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticsLib {
    public class OnlineMean {
        private double avg = 0;
        private int index = 0;

        // Properties
        public double Avg => avg;

        // Methods
        public void AddValue (double val) {
            index++;
            avg += (val - avg) / index;
        }
    }
}
