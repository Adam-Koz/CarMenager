using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fuel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class repairs : ContentPage
    {
        public repairs()
        {
            InitializeComponent();
            if (Application.Current.Properties.ContainsKey("beltKM")) beltEntry.Text = Application.Current.Properties["beltKM"].ToString();
            if (Application.Current.Properties.ContainsKey("beltTime")) beltDate.Date = Convert.ToDateTime(Application.Current.Properties["beltTime"]);
            //
            if (Application.Current.Properties.ContainsKey("airKM")) airEntry.Text = Application.Current.Properties["airKM"].ToString();
            if (Application.Current.Properties.ContainsKey("airTime")) airDate.Date = Convert.ToDateTime(Application.Current.Properties["airTime"]);
            //
            if (Application.Current.Properties.ContainsKey("amorKM")) amorEntry.Text = Application.Current.Properties["amorKM"].ToString();
            if (Application.Current.Properties.ContainsKey("amorTime")) amorDate.Date = Convert.ToDateTime(Application.Current.Properties["amorTime"]);
            //
            if (Application.Current.Properties.ContainsKey("RamorKM")) RamorEntry.Text = Application.Current.Properties["RamorKM"].ToString();
            if (Application.Current.Properties.ContainsKey("RamorTime")) RamorDate.Date = Convert.ToDateTime(Application.Current.Properties["RamorTime"]);
            //
            if (Application.Current.Properties.ContainsKey("brakeKM")) brakeEntry.Text = Application.Current.Properties["brakeKM"].ToString();
            if (Application.Current.Properties.ContainsKey("brakeTime")) brakeDate.Date = Convert.ToDateTime(Application.Current.Properties["brakeTime"]);
            //
            if (Application.Current.Properties.ContainsKey("RbrakeKM")) RbrakeEntry.Text = Application.Current.Properties["RbrakeKM"].ToString();
            if (Application.Current.Properties.ContainsKey("RbrakeTime")) RbrakeDate.Date = Convert.ToDateTime(Application.Current.Properties["RbrakeTime"]);
            //
            if (Application.Current.Properties.ContainsKey("oilKM")) oilEntry.Text = Application.Current.Properties["oilKM"].ToString();
            if (Application.Current.Properties.ContainsKey("oilTime")) oilDate.Date = Convert.ToDateTime(Application.Current.Properties["oilTime"]);
            //
            if (Application.Current.Properties.ContainsKey("sparkKM")) sparkEntry.Text = Application.Current.Properties["sparkKM"].ToString();
            if (Application.Current.Properties.ContainsKey("sparkTime")) sparkDate.Date = Convert.ToDateTime(Application.Current.Properties["sparkTime"]);
            //
            if (Application.Current.Properties.ContainsKey("wheelsKM")) wheelsEntry.Text = Application.Current.Properties["wheelsKM"].ToString();
            if (Application.Current.Properties.ContainsKey("wheelsTime")) wheelsDate.Date = Convert.ToDateTime(Application.Current.Properties["wheelsTime"]);
            //
            if (Application.Current.Properties.ContainsKey("coolantKM")) coolantEntry.Text = Application.Current.Properties["coolantKM"].ToString();
            if (Application.Current.Properties.ContainsKey("coolantTime")) coolantDate.Date = Convert.ToDateTime(Application.Current.Properties["coolantTime"]);
        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            // engine timing gear
            Application.Current.Properties["beltKM"] = beltEntry.Text;
            Application.Current.Properties["beltTime"] = beltDate.Date;

            //air filter
            Application.Current.Properties["airKM"] = airEntry.Text;
            Application.Current.Properties["airTime"] = airDate.Date;


            //front shock absorber
            Application.Current.Properties["amorKM"] = amorEntry.Text;
            Application.Current.Properties["amorTime"] = amorDate.Date;
            //Rear shock absorber
            Application.Current.Properties["RamorKM"] = RamorEntry.Text;
            Application.Current.Properties["RamorTime"] = RamorDate.Date;

            //front brakes
            Application.Current.Properties["brakeKM"] = brakeEntry.Text;
            Application.Current.Properties["brakeTime"] = brakeDate.Date;
            //rear brakes
            Application.Current.Properties["RbrakeKM"] = RbrakeEntry.Text;
            Application.Current.Properties["RbrakeTime"] = RbrakeDate.Date;

            // oil
            Application.Current.Properties["oilKM"] = oilEntry.Text;
            Application.Current.Properties["oilTime"] = oilDate.Date;

            //sparks 
            Application.Current.Properties["sparkKM"] = sparkEntry.Text;
            Application.Current.Properties["sparkTime"] = sparkDate.Date;

            //wheels
            Application.Current.Properties["wheelsKM"] = wheelsEntry.Text;
            Application.Current.Properties["wheelsTime"] = wheelsDate.Date;

            //coolant
            Application.Current.Properties["coolantKM"] = coolantEntry.Text;
            Application.Current.Properties["coolantTime"] = coolantDate.Date;

        }
    }
}