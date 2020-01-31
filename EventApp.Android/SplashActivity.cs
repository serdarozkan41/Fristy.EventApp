using Android.App;
using Android.OS;

namespace EventApp.Droid
{
    [Activity(Label = "Fristy", Icon = "@mipmap/ic_launcher", Theme = "@style/MyTheme.Splash",
        MainLauncher = true, NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // System.Threading.Thread.Sleep(1500);
            this.StartActivity(typeof(MainActivity));
        }
    }
}