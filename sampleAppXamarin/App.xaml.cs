using System.Collections.Generic;
using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace sampleAppXamarin
{
    public partial class App : Application
    {
        public App()
        {
            AppCenter.Start("92b39f71-ca95-4b49-9149-ded8a273ae52",
                               typeof(Analytics), typeof(Crashes));

            MainPage = new ButtonPage();
        }
    }
}
