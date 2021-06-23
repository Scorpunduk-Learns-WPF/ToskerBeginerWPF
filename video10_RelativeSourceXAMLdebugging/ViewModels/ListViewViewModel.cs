using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace video10_RelativeSourceXAMLdebugging.ViewModels
{
    public class ListViewViewModel
    {
        public ObservableCollection<string> Names { get; set; }

        public ListViewViewModel()
        {
            Names = new ObservableCollection<string>()
            {
                "Jane",
                "Joe",
                "John",
                "Jessica",
                "Matt"
            };
        }
    }
}
