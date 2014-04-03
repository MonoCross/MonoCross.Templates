using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

using MonoCross.Navigation;
using MonoCross.WindowsPhone;

namespace $rootnamespace$
{
    public class Base$safeitemname$ : MXPhonePage<string>, IMXView { }

    [MXPhoneView("/Views/$safeitemname$.xaml")]
    partial class $safeitemname$ : Base$safeitemname$
    {
        public $safeitemname$()
        {
            InitializeComponent();
            ApplicationTitle.Text = MXContainer.Instance.App.Title;
        }

        public override void Render()
        {
            // set 
            Message.Text = Model;
        }
    }
}