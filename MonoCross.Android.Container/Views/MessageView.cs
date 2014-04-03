using System;

using Android.App;
using Android.Content.PM;
using Android.Views;
using Android.Widget;
using Android.OS;

using MonoCross.Navigation;
using MonoCross.Droid;

namespace $safeprojectname$
{
    [Activity(MainLauncher = true, Label = "Hello World!", LaunchMode = LaunchMode.SingleTop)]
    public class MessageView : MXListActivityView<string>
    {
        public override void Render()
        {
            ListAdapter = new ArrayAdapter<string>(this, Resource.Layout.ListItem, new string[] { Model });
        }

        protected override void OnCreate(Bundle bundle)
        {
            if (MXContainer.Instance == null)
            {
                // initialize app
                // example: MXDroidContainer.Initialize(new HelloWorld.App(), ApplicationContext);

                // initialize views
                MXContainer.AddView<string>(typeof(MessageView), ViewPerspective.Default);

                // navigate to first view
                MXContainer.Navigate(null, MXContainer.Instance.App.NavigateOnLoad);
            }

            base.OnCreate(bundle);
        }
    }
}