using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fuel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
            permissionsAcces();
        }

        private async void permissionsAcces()
        {
            try
            {
                var permissions = await Permissions.CheckStatusAsync<Permissions.CalendarWrite>();
                if(permissions != PermissionStatus.Granted)
                {
                    permissions = await Permissions.RequestAsync<Permissions.CalendarWrite>();
                }

            }
            catch(Exception ex)
            {
                return;
            }
        }

        private  async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new repairs());
        }

        private async void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Insurance());
        }

        private async void ImageButton_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}