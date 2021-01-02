using System;

namespace SimpleNavigation.ViewModels
{
    public class DepartmentViewModel : ViewModelBase
    {
        public string DepartmentInfo => $"Depratment information queried at {DateTime.UtcNow}";
    }
}
