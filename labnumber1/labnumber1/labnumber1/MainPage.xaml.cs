using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace labnumber1
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
        }
    }
}