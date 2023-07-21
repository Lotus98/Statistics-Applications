using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticsLib {
    public class ContinuousDistribution {
        public List<Interval> intervals;
        private string name;
        private double intervalSize;
        
        public ContinuousDistribution(string name, double start, double intervalSize) {
            intervals = new List<Interval>();
            this.intervalSize = intervalSize;
            this.name = name;
            InitList(start);
        }

        public ContinuousDistribution(string name, double start, double end, double intervalSize) {
            intervals = new List<Interval>();
            this.intervalSize = intervalSize;
            this.name = name;
            InitList(start, end);
        }

        // Properties
        public string Name { get => name; }

        public List<Interval> Distribution { get => intervals; }

        // Methods
        private void InitList(double startInterval) {
            intervals.Add(new Interval(startInterval, startInterval+intervalSize));
        }

        private void InitList(double startInterval, double endInterval) {
            for (double i = startInterval; i < endInterval; i += intervalSize) {
                intervals.Add(new Interval(i, i + intervalSize));
            }
        }

        /// <summary>
        ///     Inserts a value of type dynamic into the Intervals list
        /// </summary>
        /// <param name="value">
        ///     the value to be inserted
        /// </param>
        public void InsertInList(double value) {
            bool inserted = false;

            foreach (Interval interval in intervals) {
                if (value >= (double)interval.lowerEnd && value < (double)interval.upperEnd) {
                    interval.AddValue(value);
                    inserted = true;
                    break;
                }
            }

            if (!inserted) {
                // Inserting interval on the left
                if (value < (double)intervals[0].lowerEnd) {
                    while (!inserted) {
                        double upper = intervals[0].lowerEnd;
                        double lower = upper - intervalSize;
                        Interval temp = new Interval(lower, upper);
                        if (value >= (double)lower) {
                            temp.AddValue(value);
                            inserted = true;
                        }
                        intervals.Insert(0, temp);

                    }
                }
                // Adding interval on the right
                else {
                    while (!inserted) {
                        double lower = intervals[intervals.Count - 1].upperEnd;
                        double upper = lower + intervalSize;
                        Interval temp = new Interval(lower, upper);
                        if (value < (double)upper) {
                            temp.AddValue(value);
                            inserted = true;
                        }
                        intervals.Add(temp);

                    }
                }
            }

            return;
        }

        public int GetIndex(double value) {
            for (int i=0; i<intervals.Count; i++) {
                if (intervals[i].Contains(value))
                    return i;
            }
            throw new Exception("Value not in distribution!");
        }
    }
}
