
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;


/*  CREATE CUSTOM COMMANDS: Summary
 *  =========================================================================================
 * 
 * Basically, you must add a custom Command class to the namespace.
 * 
 * Add the _CanExecute and _Executed methods of the ICommand interface.
 * 
 *      _CanExecute:    Checks if the Command can execute or not...
 *                      you can add your logic here to check your conditions
 *                      for your command to execute or not..
 *                      
 *      _Executed:      The actual code that has to be Run/Executed if the
 *                      _canexecute's .CanExeute=true.
 *                      you can add your own logic under this method that has 
 *                      to execute/run
 * 
 * In XAML: 
 *          Add <xmlns:self="clr-namespace:__Namespace_of_your_Code_behind">
 *          this will enable to use the 'self' pointer.
 * 
 *          Add the Windows.CommandBinding Keys
 *          <CommandBindings> must defines the command Name, CanExecute and
 *          Executed Method pointers.
 
 *          With the above you can use "Command="self:_customClassName.CommandName_"
 *          in the <CommandBiding Command:....> to point to your custom class.
 * 
 * Add your Custom Class that defines your Custom Routed UI command objects.
 *          Syntax:
 *              RoutedUICommand(string text, 
 *                              string name, 
 *                              Type ownerType, 
 *                              InputGestureCollection inputGestures)"
 * 
 *  =========================================================================================    
 */


namespace WpfTutorialSamples.Commands
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class CustomCommandSample : Window
	{
		public CustomCommandSample()
		{
			InitializeComponent();
		}

		// this example simply returns true...
		// Name of the command is "ExitCommand"
		// ICommand method implementation"_CanExecute" is required..
		private void ExitCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}

		// this example simply quits the current application.
		// ICommand method implementation"_Execute" is required..
		private void ExitCommand_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}

        private void ShowThis_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if(String.IsNullOrEmpty(txtCheck.Text))
            {
                e.CanExecute = false;
            }
            else
            {
                e.CanExecute = true;
            }
        }

        private void ShowThis_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //MessageBox.Show("Show this message (From: Menu / Key(Alt-F12))");
            RunthisMethod();
        }

        private void RunthisMethod()
        {
            MessageBox.Show(txtCheck.Text.ToUpper() + "\nCommand Executed from a Method");
        }


	}

    // custom Class holding the 'Command' definitions
    // and Key-shortcuts for the Routed UI commands.
    public static class CustomCommands
	{
		public static readonly RoutedUICommand Exit = new RoutedUICommand
		(
			"Exit",
			"Exit",
			typeof(CustomCommands),
			new InputGestureCollection()
			{
				new KeyGesture(Key.F4, ModifierKeys.Alt)
			}
		);

		public static readonly RoutedUICommand ShowThis = new RoutedUICommand
		(
			"ShowThis", 
			"ShowThis", 
			typeof(CustomCommands), 
			new InputGestureCollection 
			{ 
				new KeyGesture(Key.F12, ModifierKeys.Alt) 
			}
		);

		//Define more commands here, just like the one above
	}

}
