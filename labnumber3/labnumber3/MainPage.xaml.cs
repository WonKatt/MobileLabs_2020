using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace labnumber3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            ResultLabel.IsVisible = true;
            if(string.IsNullOrWhiteSpace(Entry.Text))
            {
                ResultLabel.Text = "Please enter pizzas name";
                return;
            }

            ResultLabel.Text = Entry.Text + '\n' + RadioButtonGroupView.SelectedItem;
            App.Database.SaveItem(new Entities.Order()
            {
                Name = Entry.Text,
                Addons = RadioButtonGroupView.SelectedItem.ToString()
            });
        }
        
        private async void Button1_OnClicked(object sender, EventArgs e)
        {
            try
            {
                if (App.Database.GetItems()?.Any() != true)
                {
                    await DisplayAlert ("Error", "Orders are empty", "OK");
                    return;
                }
                await Navigation.PushAsync(new Orders());
            }
            catch 
            {
                await DisplayAlert ("Error", "Orders are empty", "OK");
            }
        }

        private async void DeleteButton_OnClicked(object sender, EventArgs e)
        {
            App.Database.DeleteAll();
            await DisplayAlert ("Alert", "All orders have been deleted.", "OK");
        }
    }
}