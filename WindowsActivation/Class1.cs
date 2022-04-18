using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WindowsActivation
{
    public class Class1
    {
        public void activation(string version)
        {
            switch (version)
            {
                case "Windows11 Pro":
                case "Windows10 Pro":
                    // W269N-WFGWX-YVC9B-4J6C9-T83GX
                    Process.Start("slmgr", "/ipk W269N-WFGWX-YVC9B-4J6C9-T83GX");
                    Process.Start("slmgr", "/smks kms8.msguides.com");
                    Process.Start("slmgr", "/ato");
                    break;

                case "Windows11 Pro Education":
                case "Windows10 Pro Education":
                    break;

                case "Windows11 Home":
                case "Windows10 Home":
                    break;

                case "Windows11 Enterprise":
                case "Windows10 Enterprise":
                    break;

                case "Windows Server 2022 DataCenter":
                    break;

                case "Windows Server 2022 Standard":
                    break;

                case "Windows Server 2019 Datacenter":
                    break;

                case "Windows Server 2019 Standard":
                    break;

                case "Windows Server 2019 Essential":
                    break;

                case "Windows8.1 Pro":
                    break;

                case "Windows8.1 Enterprise":
                    break;

                case "Windows7 Professional":
                    break;

                case "Windows7 Enterprise":
                    break;
            }
        }
        public void win1110pro()
        {

        }
        public void win1110proedu()
        {

        }
        public void win1110home()
        {

        }
        public void win1110ent()
        {

        }
        public void winserver2022data()
        {

        }
        public void winserver2022stan()
        {

        }
        public void winserver2019data()
        {

        }
        public void winserver2019stan()
        {

        }
        public void winserver2019ess()
        {

        }
        public void win81pro()
        {

        }
        public void win81ent()
        {

        }
        public void win7pro()
        {

        }
        public void win7ent()
        {

        }
    }
}
