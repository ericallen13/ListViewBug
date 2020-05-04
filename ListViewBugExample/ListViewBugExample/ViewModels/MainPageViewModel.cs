using ExecutiveReportingXamarinInfrastructure.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ListViewBugExample.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        private ObservableCollection<int> _metrics;
        public ObservableCollection<int> Metrics { get => _metrics; set { SetProperty(ref _metrics, value); } }


        private ObservableCollection<int> _businessUnits;

        public ObservableCollection<int> BusinessList { get => _businessUnits; set { SetProperty(ref _businessUnits, value); } }



        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            BusinessList = new ObservableCollection<int> { 1, 2, 3, 4 };

            Metrics = new ObservableCollection<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
        }

      
    }

}
