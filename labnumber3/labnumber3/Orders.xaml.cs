using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace labnumber3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Orders : ContentPage
    {
        public Orders()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            UserGrid.ItemsSource = App.Database.GetItems().Select(x=> new { FullName= $"{x.Id}) {x.Name} with {x.Addons}"});
            base.OnAppearing();
        }
    }
}