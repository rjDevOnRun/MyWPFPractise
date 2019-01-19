using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UsingCommands
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /*
         *  In Code-behind, we handle the two events. The CanExecute handler, 
         *  which WPF will call when the application is idle to see if the 
         *  specific command is currently available, is very simple for 
         *  this example, as we want this particular command to be available 
         *  all the time. This is done by setting the CanExecute property of 
         *  the event arguments to true. 
         *  
         * The Executed handler simply shows a message box when the command 
         * is invoked. If you run the sample and press the button, you will 
         * see this message. A thing to notice is that this command has a 
         * default keyboard shortcut defined, which you get as an added bonus. 
         * 
         * Instead of clicking the button, you can try to press Ctrl+N 
         * on your keyboard - the result is the same.  
         */

        private void CommandBinding_New_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("The New Command was invoked");
        }

        private void CommandBinding_New_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }


        /*
         * In Code-behind, we have two events for each button: One that performs the actual action, 
         * which name ends with _Executed, and then the CanExecute events. In each of them, 
         * you will see that I apply some logic to decide whether or not the action can be executed 
         * and then assign it to the return value CanExecute on the EventArgs. 
         * 
         * The cool thing about this is that you don't have to call these methods to have your 
         * buttons updated - WPF does it automatically when the application has an idle moment, 
         * making sure that you interface remains updated all the time. 

        */

        private void CutCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (txtEditor != null) && (txtEditor.SelectionLength > 0);
        }

        private void CutCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            txtEditor.Cut();
        }

        private void PasteCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = Clipboard.ContainsText();
        }

        private void PasteCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            txtEditor.Paste();
        }
    }
}
