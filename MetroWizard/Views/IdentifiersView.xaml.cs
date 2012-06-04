using System.Windows.Controls;
using MetroWizard.Models;
using MetroWizard.Validators;
using MetroWizard.ViewModels;

namespace MetroWizard.Views
{
    public partial class IdentifiersView : Page
    {
        private readonly IdentifiersViewModel vm;
        public IdentifiersView()
		{
			InitializeComponent();
            vm = new IdentifiersViewModel(new IdentifiersModel(), new IdentifiersModelValidator());
		    DataContext = vm;
		}

    }
}
