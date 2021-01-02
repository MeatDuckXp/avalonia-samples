using SimpleNavigation.Core;
using System.ComponentModel;

using System.Windows.Input;

namespace SimpleNavigation.ViewModels
{
    public class NavigationViewModel : ViewModelBase, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand EmpCommand { get; set; }

        public ICommand DeptCommand { get; set; }


        public NavigationViewModel()
        {
            EmpCommand = new BaseCommand(OpenEmp);
            DeptCommand = new BaseCommand(OpenDept);
        }

        private object selectedViewModel;

        public object SelectedViewModel
        {
            get
            {
                return selectedViewModel;
            }
            set
            {
                selectedViewModel = value;

                OnProprtyChanged("SelectedViewModel");
            }
        }

        private void OpenEmp(object obj)
        {
            SelectedViewModel = new EmployeeViewModel();
        }
        private void OpenDept(object obj)
        {
            SelectedViewModel = new DepartmentViewModel();
        }

        private void OnProprtyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
