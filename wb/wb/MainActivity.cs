using Android.App;
using Android.OS;
using Android.Support.V7.App;

namespace wb
{
    [Activity(Label = "wb", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/AppTheme.Main")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.main);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }
    }
}

