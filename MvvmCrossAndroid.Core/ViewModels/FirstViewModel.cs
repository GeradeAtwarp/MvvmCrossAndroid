using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MvvmCrossAndroid.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        private ObservableCollection<string> _items = new ObservableCollection<string>()
        {
            "One", "Two", "Three"
        };

        public ObservableCollection<string> Items
        {
            get { return _items; }
            set { _items = value; RaisePropertyChanged(() => Items); }
        }

        private int i = 0;
        public ICommand Hello
        {
            get { return new MvxCommand(() => Mvx.Trace("Hello " + ++i)); }
        }
    }
}
