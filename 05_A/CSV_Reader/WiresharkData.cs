using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Reader {
    public class WiresharkData {
        public int nr;
        public double time;
        public string srcIP;
        public string dstIP;
        public string proto;
        public int len;
        public string info;

        public WiresharkData() {
            nr = 0;
            time = 0;
            srcIP = "";
            dstIP = "";
            proto = "";
            len = 0;
            info = "";
        }

    }
}
