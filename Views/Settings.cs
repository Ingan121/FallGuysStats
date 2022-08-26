using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
namespace FallGuysStats {
    public partial class Settings : Form {
        private PrivateFontCollection CustomFonts;
        private string overlayFontSerialized = string.Empty;

        public UserSettings CurrentSettings { get; set; }
        public Settings() {
            InitializeComponent();

            CustomFonts = new PrivateFontCollection();
            CustomFonts.AddFontFile("TitanOne-Regular.ttf");
        }
        private void Settings_Load(object sender, EventArgs e) {
            txtLogPath.Text = CurrentSettings.LogPath;

            if (CurrentSettings.SwitchBetweenLongest) {
                chkCycleFastestLongest.Checked = true;
            } else if (CurrentSettings.OnlyShowLongest) {
                chkOnlyShowLongest.Checked = true;
            } else {
                chkOnlyShowFastest.Checked = true;
            }
            if (CurrentSettings.SwitchBetweenQualify) {
                chkCycleQualifyGold.Checked = true;
            } else if (CurrentSettings.OnlyShowGold) {
                chkOnlyShowGold.Checked = true;
            } else {
                chkOnlyShowQualify.Checked = true;
            }
            if (CurrentSettings.SwitchBetweenPlayers) {
                chkCyclePlayersPing.Checked = true;
            } else if (CurrentSettings.OnlyShowPing) {
                chkOnlyShowPing.Checked = true;
            } else {
                chkOnlyShowPlayers.Checked = true;
            }
            if (CurrentSettings.SwitchBetweenStreaks) {
                chkCycleWinFinalStreak.Checked = true;
            } else if (CurrentSettings.OnlyShowFinalStreak) {
                chkOnlyShowFinalStreak.Checked = true;
            } else {
                chkOnlyShowWinStreak.Checked = true;
            }

            txtCycleTimeSeconds.Text = CurrentSettings.CycleTimeSeconds.ToString();
            txtPreviousWins.Text = CurrentSettings.PreviousWins.ToString();
            chkOverlayOnTop.Checked = !CurrentSettings.OverlayNotOnTop;
            chkHideWinsInfo.Checked = CurrentSettings.HideWinsInfo;
            chkHideRoundInfo.Checked = CurrentSettings.HideRoundInfo;
            chkHideTimeInfo.Checked = CurrentSettings.HideTimeInfo;
            chkShowTabs.Checked = CurrentSettings.ShowOverlayTabs;
            chkAutoUpdate.Checked = CurrentSettings.AutoUpdate;
            chkFlipped.Checked = CurrentSettings.FlippedDisplay;
            chkHidePercentages.Checked = CurrentSettings.HideOverlayPercentages;
            chkChangeHoopsieLegends.Checked = CurrentSettings.HoopsieHeros;

            switch (CurrentSettings.OverlayColor) {
                case 0: cboOverlayColor.SelectedIndex = 1; break; // Magenta
                case 1: cboOverlayColor.SelectedIndex = 4; break; // Blue
                case 2: cboOverlayColor.SelectedIndex = 2; break; // Red
                case 3: cboOverlayColor.SelectedIndex = 0; break; // Transparent
                case 4: cboOverlayColor.SelectedIndex = 5; break; // Black
                case 5: cboOverlayColor.SelectedIndex = 3; break; // Green
            }
            switch (CurrentSettings.WinsFilter) {
                case 0: cboWinsFilter.SelectedIndex = 1; break; // Stats and Party Filter
                case 1: cboWinsFilter.SelectedIndex = 2; break; // Season Stats
                case 2: cboWinsFilter.SelectedIndex = 3; break; // Week Stats
                case 3: cboWinsFilter.SelectedIndex = 0; break; // All Time Stats
                case 4: cboWinsFilter.SelectedIndex = 4; break; // Day Stats
                case 5: cboWinsFilter.SelectedIndex = 5; break; // Session Stats
            }
            switch (CurrentSettings.QualifyFilter) {
                case 0: cboQualifyFilter.SelectedIndex = 0; break; // All Time Stats
                case 1: cboQualifyFilter.SelectedIndex = 1; break; // Stats and Party Filter
                case 2: cboQualifyFilter.SelectedIndex = 2; break; // Season Stats
                case 3: cboQualifyFilter.SelectedIndex = 3; break; // Week Stats
                case 4: cboQualifyFilter.SelectedIndex = 4; break; // Day Stats
                case 5: cboQualifyFilter.SelectedIndex = 5; break; // Session Stats
            }
            switch (CurrentSettings.FastestFilter) {
                case 0: cboFastestFilter.SelectedIndex = 0; break; // All Time Stats
                case 1: cboFastestFilter.SelectedIndex = 1; break; // Stats and Party Filter
                case 2: cboFastestFilter.SelectedIndex = 2; break; // Season Stats
                case 3: cboFastestFilter.SelectedIndex = 3; break; // Week Stats
                case 4: cboFastestFilter.SelectedIndex = 4; break; // Day Stats
                case 5: cboFastestFilter.SelectedIndex = 5; break; // Session Stats
            }
            switch (CurrentSettings.Language) {
                case 0: cboLanguage.SelectedIndex = 0; break; // Use System Language
                case 1: cboLanguage.SelectedIndex = 1; break; // English
                case 2: cboLanguage.SelectedIndex = 2; break; // Korean
            }

            txtGameExeLocation.Text = CurrentSettings.GameExeLocation;
            chkAutoLaunchGameOnStart.Checked = CurrentSettings.AutoLaunchGameOnStartup;
            chkIgnoreLevelTypeWhenSorting.Checked = CurrentSettings.IgnoreLevelTypeWhenSorting;

            if (!string.IsNullOrEmpty(CurrentSettings.OverlayFontSerialized)) {
                FontConverter fontConverter = new FontConverter();
                Font exampleFont = fontConverter.ConvertFromString(CurrentSettings.OverlayFontSerialized) as Font;
                lblOverlayFontExample.Font = exampleFont;
            } else if (CustomFonts != null) {
                lblOverlayFontExample.Font = new Font(CustomFonts.Families[0], 18, FontStyle.Regular, GraphicsUnit.Pixel);
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            CurrentSettings.LogPath = txtLogPath.Text;

            if (string.IsNullOrEmpty(txtCycleTimeSeconds.Text)) {
                CurrentSettings.CycleTimeSeconds = 5;
            } else {
                CurrentSettings.CycleTimeSeconds = int.Parse(txtCycleTimeSeconds.Text);
                if (CurrentSettings.CycleTimeSeconds <= 0) {
                    CurrentSettings.CycleTimeSeconds = 5;
                }
            }

            if (string.IsNullOrEmpty(txtPreviousWins.Text)) {
                CurrentSettings.PreviousWins = 0;
            } else {
                CurrentSettings.PreviousWins = int.Parse(txtPreviousWins.Text);
                if (CurrentSettings.PreviousWins < 0) {
                    CurrentSettings.PreviousWins = 0;
                }
            }

            if (chkCycleFastestLongest.Checked) {
                CurrentSettings.SwitchBetweenLongest = true;
                CurrentSettings.OnlyShowLongest = false;
            } else if (chkOnlyShowLongest.Checked) {
                CurrentSettings.SwitchBetweenLongest = false;
                CurrentSettings.OnlyShowLongest = true;
            } else {
                CurrentSettings.SwitchBetweenLongest = false;
                CurrentSettings.OnlyShowLongest = false;
            }
            if (chkCycleQualifyGold.Checked) {
                CurrentSettings.SwitchBetweenQualify = true;
                CurrentSettings.OnlyShowGold = false;
            } else if (chkOnlyShowGold.Checked) {
                CurrentSettings.SwitchBetweenQualify = false;
                CurrentSettings.OnlyShowGold = true;
            } else {
                CurrentSettings.SwitchBetweenQualify = false;
                CurrentSettings.OnlyShowGold = false;
            }
            if (chkCyclePlayersPing.Checked) {
                CurrentSettings.SwitchBetweenPlayers = true;
                CurrentSettings.OnlyShowPing = false;
            } else if (chkOnlyShowPing.Checked) {
                CurrentSettings.SwitchBetweenPlayers = false;
                CurrentSettings.OnlyShowPing = true;
            } else {
                CurrentSettings.SwitchBetweenPlayers = false;
                CurrentSettings.OnlyShowPing = false;
            }
            if (chkCycleWinFinalStreak.Checked) {
                CurrentSettings.SwitchBetweenStreaks = true;
                CurrentSettings.OnlyShowFinalStreak = false;
            } else if (chkOnlyShowFinalStreak.Checked) {
                CurrentSettings.SwitchBetweenStreaks = false;
                CurrentSettings.OnlyShowFinalStreak = true;
            } else {
                CurrentSettings.SwitchBetweenStreaks = false;
                CurrentSettings.OnlyShowFinalStreak = false;
            }

            CurrentSettings.OverlayNotOnTop = !chkOverlayOnTop.Checked;
            if (chkHideRoundInfo.Checked && chkHideTimeInfo.Checked && chkHideWinsInfo.Checked) {
                chkHideWinsInfo.Checked = false;
            }
            bool resizeOverlay = CurrentSettings.HideWinsInfo != chkHideWinsInfo.Checked ||
                CurrentSettings.HideRoundInfo != chkHideRoundInfo.Checked ||
                CurrentSettings.HideTimeInfo != chkHideTimeInfo.Checked ||
                CurrentSettings.ShowOverlayTabs != chkShowTabs.Checked;

            CurrentSettings.HideWinsInfo = chkHideWinsInfo.Checked;
            CurrentSettings.HideRoundInfo = chkHideRoundInfo.Checked;
            CurrentSettings.HideTimeInfo = chkHideTimeInfo.Checked;
            CurrentSettings.ShowOverlayTabs = chkShowTabs.Checked;
            CurrentSettings.AutoUpdate = chkAutoUpdate.Checked;
            CurrentSettings.FlippedDisplay = chkFlipped.Checked;
            CurrentSettings.HideOverlayPercentages = chkHidePercentages.Checked;
            CurrentSettings.HoopsieHeros = chkChangeHoopsieLegends.Checked;

            switch (cboOverlayColor.SelectedIndex) {
                case 1: CurrentSettings.OverlayColor = 0; break; // Magenta
                case 4: CurrentSettings.OverlayColor = 1; break; // Blue
                case 2: CurrentSettings.OverlayColor = 2; break; // Red
                case 0: CurrentSettings.OverlayColor = 3; break; // Transparent
                case 5: CurrentSettings.OverlayColor = 4; break; // Black
                case 3: CurrentSettings.OverlayColor = 5; break; // Green
            }
            switch (cboWinsFilter.SelectedIndex) {
                case 1: CurrentSettings.WinsFilter = 0; break; // Stats and Party Filter
                case 2: CurrentSettings.WinsFilter = 1; break; // Season Stats
                case 3: CurrentSettings.WinsFilter = 2; break; // Week Stats
                case 0: CurrentSettings.WinsFilter = 3; break; // All Time Stats
                case 4: CurrentSettings.WinsFilter = 4; break; // Day Stats
                case 5: CurrentSettings.WinsFilter = 5; break; // Session Stats
            }
            switch (cboQualifyFilter.SelectedIndex) {
                case 0: CurrentSettings.QualifyFilter = 0; break; // All Time Stats
                case 1: CurrentSettings.QualifyFilter = 1; break; // Stats and Party Filter
                case 2: CurrentSettings.QualifyFilter = 2; break; // Season Stats
                case 3: CurrentSettings.QualifyFilter = 3; break; // Week Stats
                case 4: CurrentSettings.QualifyFilter = 4; break; // Day Stats
                case 5: CurrentSettings.QualifyFilter = 5; break; // Session Stats
            }
            switch (cboFastestFilter.SelectedIndex) {
                case 0: CurrentSettings.FastestFilter = 0; break; // All Time Stats
                case 1: CurrentSettings.FastestFilter = 1; break; // Stats and Party Filter
                case 2: CurrentSettings.FastestFilter = 2; break; // Season Stats
                case 3: CurrentSettings.FastestFilter = 3; break; // Week Stats
                case 4: CurrentSettings.FastestFilter = 4; break; // Day Stats
                case 5: CurrentSettings.FastestFilter = 5; break; // Session Stats
            }
            switch (cboLanguage.SelectedIndex) {
                case 0: CurrentSettings.Language = 0; break; // Use System Language
                case 1: CurrentSettings.Language = 1; break; // English
                case 2: CurrentSettings.Language = 2; break; // Korean
            }

            if (resizeOverlay) {
                int overlaySetting = (CurrentSettings.HideWinsInfo ? 4 : 0) + (CurrentSettings.HideRoundInfo ? 2 : 0) + (CurrentSettings.HideTimeInfo ? 1 : 0);
                switch (overlaySetting) {
                    case 0: CurrentSettings.OverlayWidth = 786; break;
                    case 1: CurrentSettings.OverlayWidth = 786 - 225 - 6; break;
                    case 2: CurrentSettings.OverlayWidth = 786 - 281 - 6; break;
                    case 3: CurrentSettings.OverlayWidth = 786 - 281 - 225 - 12; break;
                    case 4: CurrentSettings.OverlayWidth = 786 - 242 - 6; break;
                    case 5: CurrentSettings.OverlayWidth = 786 - 242 - 225 - 12; break;
                    case 6: CurrentSettings.OverlayWidth = 786 - 242 - 281 - 12; break;
                }

                if (CurrentSettings.ShowOverlayTabs) {
                    CurrentSettings.OverlayHeight = 134;
                } else {
                    CurrentSettings.OverlayHeight = 99;
                }
            }

            CurrentSettings.IgnoreLevelTypeWhenSorting = chkIgnoreLevelTypeWhenSorting.Checked;
            CurrentSettings.GameExeLocation = txtGameExeLocation.Text;
            CurrentSettings.AutoLaunchGameOnStartup = chkAutoLaunchGameOnStart.Checked;

            if (!string.IsNullOrEmpty(overlayFontSerialized)) {
                FontConverter fontConverter = new FontConverter();
                CurrentSettings.OverlayFontSerialized = fontConverter.ConvertToString(lblOverlayFontExample.Font);
            } else {
                CurrentSettings.OverlayFontSerialized = string.Empty;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
        private void txtCycleTimeSeconds_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (!string.IsNullOrEmpty(txtCycleTimeSeconds.Text) && !int.TryParse(txtCycleTimeSeconds.Text, out _)) {
                txtCycleTimeSeconds.Text = "5";
            }
        }
        private void txtLogPath_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            try {
                if (txtLogPath.Text.IndexOf(".log", StringComparison.OrdinalIgnoreCase) > 0) {
                    txtLogPath.Text = Path.GetDirectoryName(txtLogPath.Text);
                }
            } catch { }
        }
        private void txtPreviousWins_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (!string.IsNullOrEmpty(txtPreviousWins.Text) && !int.TryParse(txtPreviousWins.Text, out _)) {
                txtPreviousWins.Text = "0";
            }
        }
        private void btnGameExeLocationBrowse_Click(object sender, EventArgs e) {
            try {
                using (OpenFileDialog openFile = new OpenFileDialog()) {
                    if (!string.IsNullOrEmpty(txtGameExeLocation.Text)) {
                        FileInfo currentExeLocation = new FileInfo(txtGameExeLocation.Text);
                        if (currentExeLocation.Directory.Exists) {
                          openFile.InitialDirectory = currentExeLocation.Directory.FullName;
                        }
                    }

                    openFile.Filter = $"{Resources.Strings.settings_exe_files} (*.exe)|*.exe";
                    openFile.FileName = "FallGuys_client_game.exe";
                    openFile.Title = Resources.Strings.settings_locate_fall_guys;

                    DialogResult result = openFile.ShowDialog(this);
                    if (result.Equals(DialogResult.OK)) {
                        if (openFile.FileName.IndexOf("FallGuys_client", StringComparison.OrdinalIgnoreCase) >= 0) {
                            txtGameExeLocation.Text = openFile.FileName;
                        } else {
                            MessageBox.Show(Resources.Strings.settings_wrong_file_selected_msg, Resources.Strings.settings_wrong_file_selected, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            } catch (Exception ex) {
                ControlErrors.HandleException(this, ex, false);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void btnSelectFont_Click(object sender, EventArgs e) {
            dlgOverlayFont.Font = lblOverlayFontExample.Font;
            DialogResult result = dlgOverlayFont.ShowDialog(this);

            if (result.Equals(DialogResult.OK)) {
                lblOverlayFontExample.Font = dlgOverlayFont.Font;
                FontConverter fontConverter = new FontConverter();
                overlayFontSerialized = fontConverter.ConvertToString(dlgOverlayFont.Font);
            }
        }
        private void btnResetOverlayFont_Click(object sender, EventArgs e) {
            Font defaultFont = new Font(CustomFonts.Families[0], 18, FontStyle.Regular, GraphicsUnit.Pixel);
            lblOverlayFontExample.Font = defaultFont;
            overlayFontSerialized = string.Empty;
        }
    }
}