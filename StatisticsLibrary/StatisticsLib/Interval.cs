using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticsLib {
    public class Interval {
        public double lowerEnd;
        public double upperEnd;
        public double intervalSize;
        private OnlineMean mean;
        private int count;

        // Properties
        public int Count => count;

        internal OnlineMean Mean { get => mean;     }

        public Interval(double start, double end) {
            lowerEnd = start;
            upperEnd = end;
            intervalSize = end - start;
            count = 0;
            mean = new OnlineMean();
        }

        // Methods
        public void AddValue(double val) {
            // Add value to mean as well
            mean.AddValue(val);
            count++;
        }

        public bool Contains(double val) {
            return ((double)val >= lowerEnd && (double)val < upperEnd);
        }

    }
}
