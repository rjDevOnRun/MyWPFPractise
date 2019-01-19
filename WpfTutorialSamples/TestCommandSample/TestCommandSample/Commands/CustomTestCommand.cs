using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfTutorialSamples.TestCommandSample.Commands
{
    // Just take care that the Namespace must be same as the
    // namespace of the ViewModel.

    public static class CustomTestCommand
    {
        public static readonly RoutedUICommand DoCommand = new RoutedUICommand
        (
            "DoCommand",
            "DoCommand",
            typeof(CustomTestCommand),
            new InputGestureCollection
            {
                new KeyGesture(Key.F12, ModifierKeys.Alt)
            }
        );
    }
}
