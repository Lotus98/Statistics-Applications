using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticsLib {
    public class DiscreteDistribution {
        private SortedDictionary<object, int> distDict;
        private int n;

        public DiscreteDistribution() {
            distDict = new SortedDictionary<object, int>();
            n = 0;
        }

        public void AddValue(object key) {
            if (distDict.ContainsKey(key)) {
                distDict[key]++;
            } else {
                distDict.Add(key, 1);
            }
            n++;
        }

        public int GetCount(object key) => distDict[key];

        public double GetRelFreq(object key) {
            double relFreq = distDict[key] / (double)n;
            return relFreq;
        }

        public double GetPerc(object key) {
            double perc = distDict[key] / (double)n * 100;
            return perc;
        }

        public SortedDictionary<object, int> Distribution { get => distDict; }


    }
}
