using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace DI_Sample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = Startup.ServiceProvider.GetService<MainPageModel>();
        }
    }
}
