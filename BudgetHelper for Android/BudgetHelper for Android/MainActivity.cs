using Android.App;
using Android.Widget;
using Android.OS;
using System.IO;
using SQLite;
using SQLite.Net;

namespace BudgetHelper_for_Android
{
    [Activity(Label = "BudgetHelper_for_Android", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button button = FindViewById<Button>(Resource.Id.myButton);

            button.Click += delegate
            {
                string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "dbTest.db3");


                var db = new SQLiteConnection;


            };
        }
    }
}

