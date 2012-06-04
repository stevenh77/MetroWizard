using MetroWizard.ViewModels;

namespace MetroWizard  
{
	public partial class MainPage
	{
	    private readonly MainPageViewModel vm;
		public MainPage()
		{
			InitializeComponent();
		    vm = new MainPageViewModel();
		    DataContext = vm;
		}
    }
}