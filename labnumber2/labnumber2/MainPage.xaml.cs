using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace labnumber2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Button_OnClicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(Entry.Text))
            {
                if(!Switch.IsToggled)
                {
                    var c = new OrderDetail();
                    c.Label1 = Entry.Text;
                    c.Label2 = RadioButtonGroupView.SelectedItem?.ToString();
                    
                    await Navigation.PushAsync(c);
                }
                else
                {
                    await DisplayAlert ("Order", $"Order name: {Entry.Text}\n" +
                                                               $"Addons: {RadioButtonGroupView.SelectedItem}",
                        "OK");
                }
            }
            

            ResultLabel.Text = Entry.Text + '\n' + RadioButtonGroupView.SelectedItem;
        }
    }
}