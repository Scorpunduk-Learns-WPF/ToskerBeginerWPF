using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Input;

namespace video03_CommandsPartOne.ViewModels
{
    public class CommandMessage : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Action _execute;

        public CommandMessage(Action execute)
        {
            _execute = execute;         
        }

        public void Execute(object parameter)
        {
            _execute.Invoke();
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }
    }

    public class CommandMessageParametrized : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Action<string> _execute;

        public CommandMessageParametrized(Action<string> execute)
        {
            _execute = execute;
        }

        public void Execute(object parameter)
        {
            _execute.Invoke(parameter as string);
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }
    }
}
