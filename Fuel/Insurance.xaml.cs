using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fuel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Insurance : ContentPage
    {
        public Insurance()
        {
            InitializeComponent();
            

            if (Application.Current.Properties.ContainsKey("PolicyNum")) PolicyNumberE.Text = Application.Current.Properties["PolicyNum"].ToString();
            if (Application.Current.Properties.ContainsKey("PolicyOwn")) PolicyOwnerE.Text = Application.Current.Properties["PolicyOwn"].ToString();
            if (Application.Current.Properties.ContainsKey("Vehicle")) VehicleE.Text = Application.Current.Properties["Vehicle"].ToString();

            if (Application.Current.Properties.ContainsKey("DateF")) FromDate.Date = Convert.ToDateTime(Application.Current.Properties["DateF"]);
            if (Application.Current.Properties.ContainsKey("DateT")) ToDate.Date = Convert.ToDateTime(Application.Current.Properties["DateT"]);
        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["PolicyNum"] = PolicyNumberE.Text;
            Application.Current.Properties["PolicyOwn"] = PolicyOwnerE.Text;
            Application.Current.Properties["Vehicle"] = VehicleE.Text;
            Application.Current.Properties["DateF"] = FromDate.Date;
            Application.Current.Properties["DateT"] = ToDate.Date;

        }



    }
}