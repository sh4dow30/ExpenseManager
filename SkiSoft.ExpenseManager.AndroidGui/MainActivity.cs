using Android.App;
using Android.Widget;
using Android.OS;
using SkiSoft.ExpenseManager.DataModel;

namespace SkiSoft.ExpenseManager.AndroidGui
{
    [Activity(Label = "SkiSoft.ExpenseManager.AndroidGui", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Account _account;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }
    }
}

