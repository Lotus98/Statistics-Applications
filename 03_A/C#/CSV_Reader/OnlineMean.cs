using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Reader {
    class OnlineMean {
        private double currentAvg = 0;
        private int index = 0;

        public double GetAvg() { return currentAvg; }

        public void NewValue (double val) {
            index++;
            currentAvg += (val - currentAvg) / index;
        }
    }
}
