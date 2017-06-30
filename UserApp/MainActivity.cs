using Android.App;
using Android.OS;
using UserApp.Models;
using UserApp.SAL;

namespace UserApp
{
    [Activity(Label = "UserApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        readonly ServiceHelper _helper = new ServiceHelper();

        protected override async void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            var users = await _helper.GetUsersByName("macario");

            await _helper.InsertUserDetails(new UserDetails{FirstName = "Macario", LastName = "Hernandez", Age = 31});

            users = await _helper.GetUsersByName("macario");
        }
    }
}

