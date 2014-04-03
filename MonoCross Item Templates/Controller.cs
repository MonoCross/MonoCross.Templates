using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MonoCross.Navigation;

namespace $rootnamespace$
{
    public class $safeitemname$ : MXController<string>
    {
        public override string Load(Dictionary<string,string> parameters)
        {
            // add busniss logic, and logic to initialize your model
            // example: Model = "My Model Text:";

            // return a string indicating the view to render
            return ViewPerspective.Default;
        }
    }
}
