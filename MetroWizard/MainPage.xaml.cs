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

        private void btnChangeState_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            //switch (vm.WizardStep)
            //{
            //    case WizardStep.Step1: 
            //        vm.WizardStep = WizardStep.Step2;
            //        break;
            //    case WizardStep.Step2:
            //        vm.WizardStep = WizardStep.Step3;
            //        break;
            //    case WizardStep.Step3: 
            //        vm.WizardStep = WizardStep.Step4;
            //        break;
            //    case WizardStep.Step4:
            //        vm.WizardStep = WizardStep.Step1;
            //        break;
            //}
        }
    }
}