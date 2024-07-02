using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClerkgroupTest.UI.ViewModels.Components;

namespace ClerkgroupTest.UI.ViewModels.Windows
{
    public class MainViewModel : ViewModelBase
    {
        public LayoutViewModel LayoutViewModel { get; set; }

        public MainViewModel(LayoutViewModel layoutViewModel)
        {
            LayoutViewModel = layoutViewModel;
        }
        public string Text { get; } = "MainViewModel";
    }
}
