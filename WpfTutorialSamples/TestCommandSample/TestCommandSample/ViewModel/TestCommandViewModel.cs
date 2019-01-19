using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
//using WpfTutorialSamples.TestCommandSample;

namespace WpfTutorialSamples.TestCommandSample.Commands
{
    public class TestCommandViewModel
    {

        StartupWindow _oStartupWin;

        // Constructor:
        // Get the MAin Staup Window as parameter
        // this will enable access to the Form object..
        public TestCommandViewModel(StartupWindow oStartupWin)  
        {
            if(oStartupWin != null)
            {
                _oStartupWin = oStartupWin;
            }
        }

        public bool IsTheTextBoxEmpty()
        {
            bool bTest = true;

            if(_oStartupWin !=null)
            {
                if(string.IsNullOrWhiteSpace(_oStartupWin.txtCheck.Text))
                {
                    bTest = true;
                }
                else
                {
                    bTest= false;
                }
            }
            return bTest;
        }

    }
}

