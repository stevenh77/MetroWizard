using System.Windows.Input;
using MetroWizard.Commands;

namespace MetroWizard.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel()
        {
            PageCount = 4;
            
            CancelCommand = new DelegateCommand((x) => CurrentPage = 0, (x) => CurrentPage != PageCount);
            PreviousCommand = new DelegateCommand((x) => CurrentPage--, (x) => CurrentPage != 0);
            NextCommand = new DelegateCommand((x) => CurrentPage++, (x) => CurrentPage != PageCount);
            FinishCommand = new DelegateCommand((x) => CurrentPage = 0, (x) => CurrentPage == PageCount);
        }

        public ICommand CancelCommand { get; set; }
        public ICommand PreviousCommand { get; set; }
        public ICommand NextCommand { get; set; }
        public ICommand FinishCommand { get; set; }

        private int currentPage;
        public int CurrentPage 
        { 
            get { return currentPage; } 
            set 
            { 
                if (currentPage == value) return;
                currentPage = value;
                NotifyPropertyChanged("CurrentPage");
            } 
        }

        public int PageCount { get; set; }
    }
}
