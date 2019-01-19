using System.Windows;
using System.Windows.Input;
using WpfTutorialSamples.TestCommandSample.Commands;

namespace WpfTutorialSamples.TestCommandSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class StartupWindow : Window
    {
        TestCommandViewModel _oViewModel=null;

        public StartupWindow()
        {
            InitializeComponent();
            _oViewModel = new TestCommandViewModel(this);
            this.DataContext = _oViewModel;
        }

        // I found that the _CanExecute and _Executed Method implementations
        // must be on the code-behind file of the window for which its appilcable

        private void DoCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            //e.CanExecute = true;

            if (_oViewModel != null)
            {
                if (_oViewModel.IsTheTextBoxEmpty() == true)
                {
                    e.CanExecute = false;
                }
                else
                {
                    e.CanExecute = true;
                }

            }
        }

        private void DoCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Command is Working!");
        }

    }
}
