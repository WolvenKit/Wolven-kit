// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StatusBarViewModel.cs" company="WildGums">
//   Copyright (c) 2008 - 2017 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Threading.Tasks;
using Catel;
using Catel.Configuration;
using Catel.IoC;
using Catel.MVVM;
using Catel.Threading;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.ViewModels.Shell
{
    public class StatusBarViewModel : ViewModelBase
    {
        #region Fields

        private readonly IConfigurationService _configurationService;
        private readonly IProjectManager _projectManager;
        private readonly IServiceLocator _serviceLocator;

        #endregion Fields

        #region Constructors

        public StatusBarViewModel(IProjectManager projectManager, IServiceLocator serviceLocator, IConfigurationService configurationService
            )
        {
            Argument.IsNotNull(() => projectManager);
            Argument.IsNotNull(() => serviceLocator);
            Argument.IsNotNull(() => configurationService);

            _projectManager = projectManager;
            _serviceLocator = serviceLocator;
            _configurationService = configurationService;
            StaticReferencesVM.GlobalStatusBar = this;

            CurrentProject = "-";
        }

        #endregion Constructors

        #region Properties

        public int Column { get; private set; }
        public string Heading { get; private set; }
        public string InternetConnected { get; private set; }
        public bool IsLoading { get; set; }
        public bool IsUpdatedInstalled { get; private set; }
        public int Line { get; private set; }
        public string LoadingString { get; set; }
        public string ReceivingAutomaticUpdates { get; private set; }
        public string Version { get; private set; }
        public string CurrentProject { get; set; }

        #endregion Properties

        #region Methods

        protected override async Task CloseAsync()
        {
            _configurationService.ConfigurationChanged -= OnConfigurationChanged;

            await base.CloseAsync();
        }

        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();
            StaticReferencesVM.GlobalStatusBar = this;
            _configurationService.ConfigurationChanged += OnConfigurationChanged;

            //Version = VersionHelper.GetCurrentVersion(); //TODO
            Version = "Version 0.8.1"; // TempFix
            var Connected = HandyControl.Tools.ApplicationHelper.IsConnectedToInternet();
            if (Connected)
            { InternetConnected = "Connected"; }

            IsLoading = false;
            LoadingString = "";
        }

        private void OnConfigurationChanged(object sender, ConfigurationChangedEventArgs e)
        {

        }

        #endregion Methods
    }
}
