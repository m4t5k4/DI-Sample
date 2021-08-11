using System;
using System.Collections.Generic;
using System.Text;

namespace DI_Sample
{
    public class MainPageModel
    {
        public string InjectedString { get; set; }
        public MainPageModel(IMyService myService)
        {
            InjectedString = myService.GetString();
        }
    }
}
