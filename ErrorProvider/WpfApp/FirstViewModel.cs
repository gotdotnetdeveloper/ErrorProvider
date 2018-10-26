using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

namespace WpfApp
{
    public class FirstViewModel : ViewModelBase
    {
        private string _test;
        private bool _isLocator;

        public FirstViewModel()
        {
            SaveEmployeesCommand = new RelayCommand<string>(SaveEmployeesMethod, CanExecuteSaveEmployeesMethod);
        }

        private bool CanExecuteSaveEmployeesMethod(string obj)
        {
            return true;
        }

        private void SaveEmployeesMethod(string obj)
        {
            
        }


        public ICommand SaveEmployeesCommand { get; private set; }


        public string Test
        {
            get => _test;
            set
            {
                _test = value;
                RaisePropertyChanged(() => Test);
            }
        }

        /// <summary>
        /// Тестовая команда для тоглБуттон
        /// </summary>
        public bool IsLocator
        {
            get => _isLocator;
            set
            {
                _isLocator = value;
                RaisePropertyChanged();
            } 
        }


    }
}
