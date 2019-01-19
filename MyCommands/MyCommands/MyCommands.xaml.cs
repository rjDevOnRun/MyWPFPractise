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

namespace WfpTutorialSamples.MainCommand
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LearnCommands : Window
    {
        public LearnCommands()
        {
            InitializeComponent();
        }

        private void DoCommand1_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void DoCommand1_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Is Working!");
        }

    }


}

namespace WfpTutorialSamples.MainCommand
{
    public static class TestCommands
    {
        public static readonly RoutedUICommand DoThisCommand1 = new RoutedUICommand
        (
            "DoThisCommand1", "DoThisCommand1", typeof(TestCommands), new InputGestureCollection { new KeyGesture(Key.F12, ModifierKeys.Alt) }
        );
    }
}

