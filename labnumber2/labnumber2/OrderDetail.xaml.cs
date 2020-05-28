using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace labnumber2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderDetail : ContentPage
    {
        public string Label1;
        public string Label2;

        public OrderDetail()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            NameLabel.Text = Label1;
            AddonsLabel.Text = Label2;
        }
    }
}