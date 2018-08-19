using ListPerformanceTest.Business;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListPerformanceTest.XamarinForms
{
    class MainViewModel
    {
        public DataItem[] Items => new Loader().LoadData();
        public NavigateToDetailCommand GoToDetail => new NavigateToDetailCommand();
    }
}
