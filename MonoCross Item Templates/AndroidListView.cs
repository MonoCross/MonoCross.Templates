using System;

using Android.App;
using Android.Content.PM;
using Android.Views;
using Android.Widget;
using Android.OS;

using MonoCross.Navigation;
using MonoCross.Droid;

namespace $rootnamespace$
{
    [Activity(MainLauncher = true, Label = "$itemname$", LaunchMode = LaunchMode.SingleTop)]
    public class $safeitemname$ : MXListActivityView<string>
    {
        public override void Render()
        {
            // initialize and set a new list adapter

            // example: 
            // ListAdapter = new ArrayAdapter<string>(this, Resource.Layout.ListItem, new string[] { Model });
        }
    }
}