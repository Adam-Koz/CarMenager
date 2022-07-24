using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Fuel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (Consumption.Text != null && Price.Text != null)
            {

                float consumption = float.Parse(Consumption.Text);
                float price = float.Parse(Price.Text);

                if (Cost.Text != null) CalcCost(consumption, price); 
                else if (Capacity.Text != null) CalcCapacity(consumption, price);
                else if (Distance.Text != null) CalcDistance(consumption, price);
                else await DisplayAlert("Fill all required fields", "Consumption, Price per liter and and one of the fields below can not be empty", "OK");
            }
            else await DisplayAlert("Fill all required fields", "Consumption, Price per liter and and one of the fields below can not be empty", "OK");
        }

        private void CalcCost(float cons, float price)
        {
            float cost = float.Parse(Cost.Text);
            float capacity, distance;
            capacity = cost / price;
            distance = (capacity / cons) * 100;
            Capacity.Text = capacity.ToString();
            Distance.Text = distance.ToString();
        }
        private void CalcCapacity(float cons, float price)
        {
            float capacity = float.Parse(Capacity.Text);
            float cost, distance;
            cost = capacity * price;
            distance = (capacity / cons) * 100;
            Distance.Text = distance.ToString();
            Cost.Text = cost.ToString();

        }
        private void CalcDistance(float cons, float price)
        {
            float distance = float.Parse(Distance.Text);
            float cost, capacity;
            capacity = distance * cons / 100;
            cost = capacity * price;
            Capacity.Text = capacity.ToString();
            Cost.Text = cost.ToString();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Capacity.Text = null;
            Cost.Text = null;
            Distance.Text = null;
        }
    }
}
