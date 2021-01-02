using System;

namespace SimpleNavigation.ViewModels
{
    public class EmployeeViewModel : ViewModelBase
    {
        public string EmployeeInfo => $"Employee information queried at {DateTime.UtcNow}";

    }
}
