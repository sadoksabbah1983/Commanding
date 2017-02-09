using System.Windows.Controls;
using Commanding.Modules.Oder.Desktop.ViewModels;

namespace Commanding.Modules.Oder.Desktop.Views
{
    /// <summary>
    /// Interaction logic for OrdersEditorView.xaml
    /// </summary>
    public partial class OrdersEditorView : UserControl
    {
        public OrdersEditorView( OrdersEditorViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
