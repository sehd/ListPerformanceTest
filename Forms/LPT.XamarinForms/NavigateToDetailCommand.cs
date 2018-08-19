using ListPerformanceTest.Business;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ListPerformanceTest.XamarinForms
{
    class NavigateToDetailCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if (parameter is DataItem)
                return true;
            else
                return false;
        }

        public void Execute(object parameter)
        {
            App.NavigationPage.Navigation.PushAsync(new DetailsPage(parameter as DataItem));
        }
    }
}
