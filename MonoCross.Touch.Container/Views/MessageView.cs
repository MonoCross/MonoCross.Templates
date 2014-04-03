using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using MonoCross.Navigation;
using MonoCross.Touch;

namespace $safeprojectname$.Views
{
    class MessageView : MXTouchViewController<string>, IMXView
    {
        public override void Render()
        {
            Title = "Hello World!";
            View = new UITextView() { Text = Model };            
        }
    }
}