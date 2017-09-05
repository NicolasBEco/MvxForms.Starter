﻿using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Views;
using MvvmCross.Forms.Uwp.Presenters;
using MvvmCross.Platform;

namespace MvxForms.Starter.App.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            var start = Mvx.Resolve<IMvxAppStart>();
            start.Start();

            var presenter = Mvx.Resolve<IMvxViewPresenter>() as MvxFormsUwpPagePresenter;

            LoadApplication(presenter.FormsApplication);
        }
    }
}