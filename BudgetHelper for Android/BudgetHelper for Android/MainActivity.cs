using Android.App;
using Android.Widget;
using Android.OS;

namespace BudgetHelper_for_Android
{
    [Activity(Label = "BudgetHelper_for_Android", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);//asdasdasdad

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

