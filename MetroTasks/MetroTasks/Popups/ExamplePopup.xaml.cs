using System.Windows;
using System.Windows.Controls;

using Apex;

namespace MetroTasks.Views
{
    /// <summary>
    /// Interaction logic for ExamplePopup.xaml
    /// </summary>
    public partial class ExamplePopup : UserControl
    {
        public ExamplePopup()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, RoutedEventArgs e)
        {
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            ApexBroker.GetShell().ClosePopup(this, false);
        }
    }
}
