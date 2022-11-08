using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace CSV_Reader {
    public partial class ReaderForm : Form {
        public List<WiresharkData> listOfUnits;
        public char separator = ',';
        public bool multivariate = false;

        public ReaderForm() {
            InitializeComponent();
            pathTextBox.DragEnter += new DragEventHandler(pathTextBox_DragEnter);
            pathTextBox.DragDrop += new DragEventHandler(pathTextBox_DragDrop);
        }

        private void pathTextBox_DragDrop(object sender, DragEventArgs e) {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
                pathTextBox.Text += file;
        }

        private void pathTextBox_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void getFileButton_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            pathTextBox.Text = ofd.FileName;
        }

        private void readFileButton_Click(object sender, EventArgs e) {
            contentRTB.Clear();
            string path = pathTextBox.Text;
            
            // Check if the file path has been loaded
            if (path == string.Empty) {
                contentRTB.Text = "[!] ERROR: Select a file first";
                return;
            }

            StreamReader reader = new StreamReader(path);
            // Skip header
            reader.ReadLine();
            // Initialize list
            listOfUnits = new List<WiresharkData>();

            while (true) {
                WiresharkData tmpUnit = new WiresharkData();

                string line = reader.ReadLine();
                line = line.Replace("\"", string.Empty);
                string[] values = line.Split(',');

                // Using Reflections to collect the values in a general way
                Type unitType = tmpUnit.GetType();
                FieldInfo[] fieldInfos = unitType.GetFields();
                int i = 0;
                foreach (FieldInfo field in fieldInfos) {
                    if (!string.IsNullOrWhiteSpace(values[i]) ) {
                        //Console.WriteLine(string.Format("Value[{0}] = {1}", i, values[i]));
                        Object tmpValue = Convert.ChangeType(values[i], field.FieldType);
                        field.SetValue(tmpUnit, tmpValue);
                    }
                    i++;
                }
                listOfUnits.Add(tmpUnit);
                if (reader.EndOfStream) break;
            }
            reader.Dispose();

            contentRTB.Text = "[+] SUCCESS: File read correctly!";
        }

        private void commaRButton_CheckedChanged(object sender, EventArgs e) => separator = ',';

        private void pipeRButton_CheckedChanged(object sender, EventArgs e) => separator = '|';

        private void colonRButton_CheckedChanged(object sender, EventArgs e) => separator = ';';

        private void ReaderForm_Load(object sender, EventArgs e) {
            distComboBox.SelectedIndex = 0;
        }

        private void distComboBox_SelectedIndexChanged(object sender, EventArgs e) => multivariate = Convert.ToBoolean(distComboBox.SelectedIndex);

        private void meanButton_Click(object sender, EventArgs e) {
            contentRTB.Clear();
            OnlineMean lenMean = new OnlineMean();
            foreach (WiresharkData unit in listOfUnits) {
                lenMean.NewValue(unit.len);
            }
            contentRTB.Text = string.Format("Mean for the discrete variable lenght: {0:0.00}", lenMean.GetAvg());
        }

        private void stdDevButton_Click(object sender, EventArgs e) {
            StandardDeviation stdDev = new StandardDeviation();
            List<double> data = new List<double>();

            foreach (WiresharkData unit in listOfUnits) {
                data.Add(unit.len);
            }
            contentRTB.Clear();
            contentRTB.Text = string.Format("Standard deviation for the discrete variable lenght: {0:0.00}", stdDev.computeStdDev(data));

        }

        private void freqDistButton_Click(object sender, EventArgs e) {
            if (multivariate) {
                DiscreteDistribution dist = new DiscreteDistribution();
                foreach (WiresharkData unit in listOfUnits) {
                    Tuple<int, string> tmpKey = new Tuple<int, string>(unit.len, unit.proto);
                    dist.AddValue(tmpKey);
                }
                contentRTB.Clear();
                contentRTB.AppendText("Bivariate distribution for the variable lenght(X) and protocol(Y):\n\n");

                // Extract distinct values
                Dictionary<int, object> distinctValFirstVar = new Dictionary<int, object>();
                Dictionary<string, object> distinctValSecondVar = new Dictionary<string, object>();
                SortedDictionary<object, int> distribution = dist.Distribution;
                foreach (KeyValuePair<object, int> kvp in distribution) {
                    Tuple<int, string> key = (Tuple<int, string>) kvp.Key;
                    if (!distinctValFirstVar.ContainsKey(key.Item1))
                        distinctValFirstVar.Add(key.Item1, null);
                    if (!distinctValSecondVar.ContainsKey(key.Item2))
                        distinctValSecondVar.Add(key.Item2, null);
                }

                // Set tabs according to number of Y's
                int cols = distinctValSecondVar.Count;
                contentRTB.SelectionTabs = new int[cols + 1];
                contentRTB.SelectionTabs[0] = 55;
                for (int i=1; i<=cols; i++) {
                    contentRTB.SelectionTabs[i] = 75 * i;
                }

                // Create table
                contentRTB.AppendText("X\\Y\t|");
                foreach (KeyValuePair<string, object> Y in distinctValSecondVar) {
                    contentRTB.AppendText(string.Format("\t{0}", Y.Key));
                }
                contentRTB.AppendText("\n");
                contentRTB.AppendText(new string('-', 64));
                contentRTB.AppendText("\n");

                foreach (KeyValuePair<int, object> X in distinctValFirstVar) {
                    contentRTB.AppendText(string.Format("{0}\t|", X.Key));
                    foreach (KeyValuePair<string, object> Y in distinctValSecondVar) {
                        Tuple<int, string> key = new Tuple<int, string>(X.Key, Y.Key);
                        int count;
                        if (!distribution.ContainsKey(key)) count = 0;
                        else {
                            count = distribution[key];
                        }
                        contentRTB.AppendText(string.Format("\t{0}", count));
                    }
                    contentRTB.AppendText("\n");
                }


            }
            else {
                DiscreteDistribution dist = new DiscreteDistribution();

                foreach (WiresharkData unit in listOfUnits) {
                    dist.AddValue(unit.len);
                }
                contentRTB.Clear();
                contentRTB.AppendText("Univariate distribution for the variable length:\n");
                contentRTB.SelectionTabs = new int[] { 75, 150, 225 };
                contentRTB.AppendText("Length\tCount\tFreq\tPerc\n");

                SortedDictionary<object, int> distribution = dist.Distribution;
                foreach(KeyValuePair<object,int> pair in distribution) {
                    double relFreq = dist.GetRelFreq(pair.Key);
                    double perc = dist.GetPerc(pair.Key);
                    string format = string.Format("{0}\t{1}\t{2:0.00}\t{3:0.00}%\n", (int)pair.Key, pair.Value, relFreq, perc);
                    contentRTB.AppendText(format);
                }
            }
        }
    }
}
