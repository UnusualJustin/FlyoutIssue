﻿namespace FlyoutIssue
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            BindingContext = new FlyoutViewModel();
        }
    }
}
