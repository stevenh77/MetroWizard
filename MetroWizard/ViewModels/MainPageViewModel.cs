using System;
using System.ComponentModel;

namespace MetroWizard.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            WizardStep = WizardStep.Step1;
        }

        private WizardStep wizardStep;
        public WizardStep WizardStep
        {
            get { return this.wizardStep; }
            set
            {
                if (value == this.wizardStep) return;
                this.wizardStep = value;
                NotifyPropertyChanged("WizardStep");
            }
        }

        #region INPC

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(info));
        }

        #endregion
    }

    public enum WizardStep
    {
        NotSet = 0,
        Step1,
        Step2,
        Step3,
        Step4
    }
}
