using MetroWizard.Models;
using MetroWizard.Validators;
using MetroWizard.ViewModels;

namespace MetroWizard.Views
{
    public partial class IdentifiersView
    {
        private readonly IdentifiersViewModel vm;
        public IdentifiersView()
		{
			InitializeComponent();
            vm = new IdentifiersViewModel(new IdentifiersModel(), new IdentifiersModelValidator());
		    DataContext = vm;
		}

        // TODO: Databind target values within storyboard
        // TODO: Convert behavior to statename
        // TODO: Metro styles textbox (base on from telerik)
        // TODO: Convert sidebar wizard page values to itemspresenter databound to tab control headers
        // TODO: Sort out font for more metro feel
    }
}
