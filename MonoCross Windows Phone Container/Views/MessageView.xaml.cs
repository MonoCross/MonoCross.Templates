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

namespace $safeprojectname$.Views
{
    public class BaseMessageView : MXPhonePage<string>, IMXView { }

    [MXPhoneView("/Views/MessageView.xaml")]
    partial class MessageView : BaseMessageView
    {
        public MessageView()
        {
            InitializeComponent();
            ApplicationTitle.Text = MXContainer.Instance.App.Title;
        }

        public override void Render()
        {
            Message.Text = Model;
        }
    }
}