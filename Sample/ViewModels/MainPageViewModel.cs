﻿#region

using System.Windows;
using System.Windows.Input;
using Vermeil.Commands;
using Vermeil.IoC;
using Vermeil.Logging;
using Vermeil.MVVM;
using Vermeil.State;

#endregion

namespace Sample.ViewModels
{
    public class MainPageViewModel : ViewModel
    {
        [Tombstoned]
        public string MyProperty
        {
            get { return (string) GetValue(MyPropertyProperty); }
            set { SetValue(MyPropertyProperty, value); }
        }

        public static readonly DependencyProperty MyPropertyProperty =
            DependencyProperty.Register("MyProperty", typeof (string), typeof (MainPageViewModel), new PropertyMetadata(null));


        protected override void OnCreate()
        {
            Logger.Debug("OnCreate");
        }

        protected override void OnLoad()
        {
            Logger.Debug("OnLoad");
        }

        protected override void OnOrientationChanged()
        {
            Logger.Debug("OnOrientationChanged");
        }

        [Inject]
        public ILogger Logger { get; set; }

        public ICommand InfoCommand
        {
            get { return new RelayCommand<string>(x => Logger.Debug(x), x => !string.IsNullOrWhiteSpace(x)); }
        }

        public ICommand AboutCommand
        {
            get
            {
                return new NavigationCommand("/Views/AboutPage.xaml");
            }
        }
    }
}