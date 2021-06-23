using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Media;

namespace video02_INotifyPropertyChanged.ViewModel
{
    public class MainVM
    {
        public PersonViewModel Person { get; private set; }
        public BackGroundViewModel BackGround { get; private set; }

        public MainVM()
        {
            Person = new PersonViewModel();
            BackGround = new BackGroundViewModel();
        }

        public void SetBackGround(Brush brushColor)
        {
            BackGround.Color = brushColor;  
        }
    }
}
