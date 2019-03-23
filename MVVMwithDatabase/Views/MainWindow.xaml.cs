using System.Windows;
using WpfSimpleMVVM.ViewModels;

namespace WpfSimpleMVVM
{
 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
