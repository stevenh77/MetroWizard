using System.Windows.Controls;
using MetroWizard.ViewModels;

namespace MetroWizard.Views
{
	public partial class CurrenciesView
	{
        private readonly CurrenciesViewModel vm;
        
        public CurrenciesView()
		{
			InitializeComponent();
            vm = new CurrenciesViewModel();
		    DataContext = vm;
		}

        private void CurrencyNameTextBlock_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var container = (sender as TextBlock).Parent as StackPanel;
            var chkIsIncluded = container.FindName("chkIsIncluded") as CheckBox;
            chkIsIncluded.IsChecked = !chkIsIncluded.IsChecked; 
        }
	}
}