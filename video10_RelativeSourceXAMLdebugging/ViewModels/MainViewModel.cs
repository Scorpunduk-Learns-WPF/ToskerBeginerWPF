using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MVVMadds;
using System.Windows.Input;

namespace video10_RelativeSourceXAMLdebugging.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        public ListViewViewModel ListView { get; set; }
        public ICommand RemoveNameCommand { get; set; }

        public MainViewModel()
        {
            ListView = new ListViewViewModel();
            RemoveNameCommand = new RelayCommandGeneric<string>(RemoveName);
        }

        public void RemoveName(string obj)
        {
            ListView.Names.Remove(obj);
        }
    }
}
