﻿using Catel.Data;

namespace WolvenKit.Model.Wizards
{
    public class FirstSetupWizardModel : ModelBase
    {
        #region fields
        private string _author = "";
        private string _email = "";
        private string _donateLink = "";
        private string _defaultDescription = "";
        private bool _createModForW3 = true;
        private bool _createModForCP77 = true;
        private bool _autoInstallMods = true;
        private bool _autoUpdatesEnabled = true;
        #endregion fields

        #region properties
        /// <summary>
        /// Gets/Sets the author's name.
        /// </summary>
        public string Author
        {
            get => _author;
            set
            {
                _author = value;
                RaisePropertyChanged(nameof(Author));
            }
        }

        /// <summary>
        /// Gets/Sets the email string.
        /// </summary>
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                RaisePropertyChanged(nameof(Email));
            }
        }

        /// <summary>
		/// Gets/Sets the donate link.
		/// </summary>
		public string DonateLink
        {
            get => _donateLink;
            set
            {
                _donateLink = value;
                RaisePropertyChanged(nameof(DonateLink));
            }
        }

        /// <summary>
		/// Gets/Sets the description.
		/// </summary>
		public string DefaultDescription
        {
            get => _defaultDescription;
            set
            {
                _defaultDescription = value;
                RaisePropertyChanged(nameof(DefaultDescription));
            }
        }

        /// <summary>
		/// Gets/Sets the CreateModForW3 bool.
		/// </summary>
		public bool CreateModForW3
        {
            get => _createModForW3;
            set
            {
                _createModForW3 = value;
                RaisePropertyChanged(nameof(CreateModForW3));
            }
        }

        /// <summary>
		/// Gets/Sets the CreateModForCP77 bool.
		/// </summary>
		public bool CreateModForCP77
        {
            get => _createModForCP77;
            set
            {
                _createModForCP77 = value;
                RaisePropertyChanged(nameof(CreateModForCP77));
            }
        }

        /// <summary>
		/// Gets/Sets the AutoInstallMods bool.
		/// </summary>
		public bool AutoInstallMods
        {
            get => _autoInstallMods;
            set
            {
                _autoInstallMods = value;
                RaisePropertyChanged(nameof(AutoInstallMods));
            }
        }

        /// <summary>
		/// Gets/Sets the AutoUpdatesEnabled bool.
		/// </summary>
		public bool AutoUpdatesEnabled
        {
            get => _autoUpdatesEnabled;
            set
            {
                _autoUpdatesEnabled = value;
                RaisePropertyChanged(nameof(AutoUpdatesEnabled));
            }
        }

        /// <summary>
		/// Gets the SelectedGames string.
		/// </summary>
        public string SelectedGames
        {
            get => (CreateModForW3 ? ProjectWizardModel.WitcherGameName + "\t" : "") + (CreateModForCP77 ? ProjectWizardModel.CyberpunkGameName : "");
        }
        #endregion properties
    }
}
