using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;                           

namespace video03_CommandsPartOne.ViewModels
{
    public class MessageViewModel
    {
        public string MessageText
        {
            get;
            set;
        }

        public CommandMessage CmdMessage { get; private set; }
        public CommandMessageParametrized CmdMessageParam { get; private set; }

        public MessageViewModel()
        {
            CmdMessage = new CommandMessage(MessageDisplay);
            CmdMessageParam = new CommandMessageParametrized(MessageDisplayParametrized);
        }

        public void MessageDisplay()
        {
            MessageBox.Show(MessageText);
        }

        public void MessageDisplayParametrized(string messageText)
        {
            MessageBox.Show(messageText);
        }

    }
}
