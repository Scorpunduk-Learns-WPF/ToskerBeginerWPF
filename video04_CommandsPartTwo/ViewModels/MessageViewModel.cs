using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
using System.Windows;

using MVVMadds;

namespace video04_CommandsPartTwo.ViewModels
{
    public class MessageViewModel
    {
        public ObservableCollection<string> Messages { get; private set; }

        public RelayCommand MessageCommand { get; private set; }
        public RelayCommand ConsoleCommand { get; private set; }

        public MessageViewModel()
        {
            Messages = new ObservableCollection<string>()
            {
                "Hello World!",
                "My name is Ivan",
                "I Love Learning Commands",
                "I am a message box",
                "I am a console"
            };

            MessageCommand = new RelayCommand(DisplayMessagebox, MessageBoxCanUse);
            ConsoleCommand = new RelayCommand(DisplayConsole, ConsoleCanUse);
        }

        public void DisplayMessagebox(object message)
        {
            MessageBox.Show((string)message);
        }

        public void DisplayConsole(object message)
        {
            Console.WriteLine((string)message);
        }

        public bool MessageBoxCanUse(object message)
        {
            if((string)message == Messages[4])
            {
                return false;
            }
            return true;
        }

        public bool ConsoleCanUse(object message)
        {
            if((string)message == Messages[3])
            {
                return false;
            }
            return true;
        }
    }
}
