namespace FallGuysStats {
    partial class Settings {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.lblLogPath = new System.Windows.Forms.Label();
            this.lblLogPathNote = new System.Windows.Forms.Label();
            this.txtLogPath = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpOverlay = new System.Windows.Forms.GroupBox();
            this.grpCycleQualifyGold = new System.Windows.Forms.GroupBox();
            this.chkOnlyShowGold = new System.Windows.Forms.RadioButton();
            this.chkOnlyShowQualify = new System.Windows.Forms.RadioButton();
            this.chkCycleQualifyGold = new System.Windows.Forms.RadioButton();
            this.grpCycleFastestLongest = new System.Windows.Forms.GroupBox();
            this.chkOnlyShowLongest = new System.Windows.Forms.RadioButton();
            this.chkOnlyShowFastest = new System.Windows.Forms.RadioButton();
            this.chkCycleFastestLongest = new System.Windows.Forms.RadioButton();
            this.chkHidePercentages = new System.Windows.Forms.CheckBox();
            this.chkHideWinsInfo = new System.Windows.Forms.CheckBox();
            this.cboOverlayColor = new System.Windows.Forms.ComboBox();
            this.lblOverlayColor = new System.Windows.Forms.Label();
            this.chkFlipped = new System.Windows.Forms.CheckBox();
            this.chkShowTabs = new System.Windows.Forms.CheckBox();
            this.chkHideTimeInfo = new System.Windows.Forms.CheckBox();
            this.chkHideRoundInfo = new System.Windows.Forms.CheckBox();
            this.cboLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.cboFastestFilter = new System.Windows.Forms.ComboBox();
            this.lblFastestFilter = new System.Windows.Forms.Label();
            this.cboQualifyFilter = new System.Windows.Forms.ComboBox();
            this.lblQualifyFilter = new System.Windows.Forms.Label();
            this.cboWinsFilter = new System.Windows.Forms.ComboBox();
            this.lblWinsFilter = new System.Windows.Forms.Label();
            this.chkOverlayOnTop = new System.Windows.Forms.CheckBox();
            this.lblCycleTimeSecondsTag = new System.Windows.Forms.Label();
            this.lblCycleTimeSeconds = new System.Windows.Forms.Label();
            this.txtCycleTimeSeconds = new System.Windows.Forms.TextBox();
            this.grpCycleWinFinalStreak = new System.Windows.Forms.GroupBox();
            this.chkOnlyShowFinalStreak = new System.Windows.Forms.RadioButton();
            this.chkOnlyShowWinStreak = new System.Windows.Forms.RadioButton();
            this.chkCycleWinFinalStreak = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkOnlyShowPing = new System.Windows.Forms.RadioButton();
            this.chkOnlyShowPlayers = new System.Windows.Forms.RadioButton();
            this.chkCyclePlayersPing = new System.Windows.Forms.RadioButton();
            this.lblOverlayFont = new System.Windows.Forms.Label();
            this.btnSelectFont = new System.Windows.Forms.Button();
            this.btnResetOverlayFont = new System.Windows.Forms.Button();
            this.grpOverlayFontExample = new System.Windows.Forms.GroupBox();
            this.lblOverlayFontExample = new System.Windows.Forms.Label();
            this.grpStats = new System.Windows.Forms.GroupBox();
            this.chkChangeHoopsieLegends = new System.Windows.Forms.CheckBox();
            this.chkAutoUpdate = new System.Windows.Forms.CheckBox();
            this.lblPreviousWinsNote = new System.Windows.Forms.Label();
            this.lblPreviousWins = new System.Windows.Forms.Label();
            this.txtPreviousWins = new System.Windows.Forms.TextBox();
            this.grpGameOptions = new System.Windows.Forms.GroupBox();
            this.lblGameExeLocation = new System.Windows.Forms.Label();
            this.txtGameExeLocation = new System.Windows.Forms.TextBox();
            this.btnGameExeLocationBrowse = new System.Windows.Forms.Button();
            this.chkAutoLaunchGameOnStart = new System.Windows.Forms.CheckBox();
            this.grpSortingOptions = new System.Windows.Forms.GroupBox();
            this.chkIgnoreLevelTypeWhenSorting = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dlgOverlayFont = new System.Windows.Forms.FontDialog();
            this.grpOverlay.SuspendLayout();
            this.grpCycleQualifyGold.SuspendLayout();
            this.grpCycleFastestLongest.SuspendLayout();
            this.grpCycleWinFinalStreak.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpOverlayFontExample.SuspendLayout();
            this.grpStats.SuspendLayout();
            this.grpGameOptions.SuspendLayout();
            this.grpSortingOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogPath
            // 
            resources.ApplyResources(this.lblLogPath, "lblLogPath");
            this.lblLogPath.Name = "lblLogPath";
            // 
            // lblLogPathNote
            // 
            resources.ApplyResources(this.lblLogPathNote, "lblLogPathNote");
            this.lblLogPathNote.ForeColor = System.Drawing.Color.DimGray;
            this.lblLogPathNote.Name = "lblLogPathNote";
            // 
            // txtLogPath
            // 
            resources.ApplyResources(this.txtLogPath, "txtLogPath");
            this.txtLogPath.Name = "txtLogPath";
            this.txtLogPath.Validating += new System.ComponentModel.CancelEventHandler(this.txtLogPath_Validating);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpOverlay
            // 
            resources.ApplyResources(this.grpOverlay, "grpOverlay");
            this.grpOverlay.Controls.Add(this.grpCycleQualifyGold);
            this.grpOverlay.Controls.Add(this.grpCycleFastestLongest);
            this.grpOverlay.Controls.Add(this.chkHidePercentages);
            this.grpOverlay.Controls.Add(this.chkHideWinsInfo);
            this.grpOverlay.Controls.Add(this.cboOverlayColor);
            this.grpOverlay.Controls.Add(this.lblOverlayColor);
            this.grpOverlay.Controls.Add(this.chkFlipped);
            this.grpOverlay.Controls.Add(this.chkShowTabs);
            this.grpOverlay.Controls.Add(this.chkHideTimeInfo);
            this.grpOverlay.Controls.Add(this.chkHideRoundInfo);
            this.grpOverlay.Controls.Add(this.cboLanguage);
            this.grpOverlay.Controls.Add(this.lblLanguage);
            this.grpOverlay.Controls.Add(this.cboFastestFilter);
            this.grpOverlay.Controls.Add(this.lblFastestFilter);
            this.grpOverlay.Controls.Add(this.cboQualifyFilter);
            this.grpOverlay.Controls.Add(this.lblQualifyFilter);
            this.grpOverlay.Controls.Add(this.cboWinsFilter);
            this.grpOverlay.Controls.Add(this.lblWinsFilter);
            this.grpOverlay.Controls.Add(this.chkOverlayOnTop);
            this.grpOverlay.Controls.Add(this.lblCycleTimeSecondsTag);
            this.grpOverlay.Controls.Add(this.lblCycleTimeSeconds);
            this.grpOverlay.Controls.Add(this.txtCycleTimeSeconds);
            this.grpOverlay.Controls.Add(this.grpCycleWinFinalStreak);
            this.grpOverlay.Controls.Add(this.groupBox1);
            this.grpOverlay.Controls.Add(this.lblOverlayFont);
            this.grpOverlay.Controls.Add(this.btnSelectFont);
            this.grpOverlay.Controls.Add(this.btnResetOverlayFont);
            this.grpOverlay.Controls.Add(this.grpOverlayFontExample);
            this.grpOverlay.Name = "grpOverlay";
            this.grpOverlay.TabStop = false;
            // 
            // grpCycleQualifyGold
            // 
            resources.ApplyResources(this.grpCycleQualifyGold, "grpCycleQualifyGold");
            this.grpCycleQualifyGold.Controls.Add(this.chkOnlyShowGold);
            this.grpCycleQualifyGold.Controls.Add(this.chkOnlyShowQualify);
            this.grpCycleQualifyGold.Controls.Add(this.chkCycleQualifyGold);
            this.grpCycleQualifyGold.Name = "grpCycleQualifyGold";
            this.grpCycleQualifyGold.TabStop = false;
            // 
            // chkOnlyShowGold
            // 
            resources.ApplyResources(this.chkOnlyShowGold, "chkOnlyShowGold");
            this.chkOnlyShowGold.Name = "chkOnlyShowGold";
            this.chkOnlyShowGold.UseVisualStyleBackColor = true;
            // 
            // chkOnlyShowQualify
            // 
            resources.ApplyResources(this.chkOnlyShowQualify, "chkOnlyShowQualify");
            this.chkOnlyShowQualify.Name = "chkOnlyShowQualify";
            this.chkOnlyShowQualify.UseVisualStyleBackColor = true;
            // 
            // chkCycleQualifyGold
            // 
            resources.ApplyResources(this.chkCycleQualifyGold, "chkCycleQualifyGold");
            this.chkCycleQualifyGold.Checked = true;
            this.chkCycleQualifyGold.Name = "chkCycleQualifyGold";
            this.chkCycleQualifyGold.TabStop = true;
            this.chkCycleQualifyGold.UseVisualStyleBackColor = true;
            // 
            // grpCycleFastestLongest
            // 
            resources.ApplyResources(this.grpCycleFastestLongest, "grpCycleFastestLongest");
            this.grpCycleFastestLongest.Controls.Add(this.chkOnlyShowLongest);
            this.grpCycleFastestLongest.Controls.Add(this.chkOnlyShowFastest);
            this.grpCycleFastestLongest.Controls.Add(this.chkCycleFastestLongest);
            this.grpCycleFastestLongest.Name = "grpCycleFastestLongest";
            this.grpCycleFastestLongest.TabStop = false;
            // 
            // chkOnlyShowLongest
            // 
            resources.ApplyResources(this.chkOnlyShowLongest, "chkOnlyShowLongest");
            this.chkOnlyShowLongest.Name = "chkOnlyShowLongest";
            this.chkOnlyShowLongest.UseVisualStyleBackColor = true;
            // 
            // chkOnlyShowFastest
            // 
            resources.ApplyResources(this.chkOnlyShowFastest, "chkOnlyShowFastest");
            this.chkOnlyShowFastest.Name = "chkOnlyShowFastest";
            this.chkOnlyShowFastest.UseVisualStyleBackColor = true;
            // 
            // chkCycleFastestLongest
            // 
            resources.ApplyResources(this.chkCycleFastestLongest, "chkCycleFastestLongest");
            this.chkCycleFastestLongest.Checked = true;
            this.chkCycleFastestLongest.Name = "chkCycleFastestLongest";
            this.chkCycleFastestLongest.TabStop = true;
            this.chkCycleFastestLongest.UseVisualStyleBackColor = true;
            // 
            // chkHidePercentages
            // 
            resources.ApplyResources(this.chkHidePercentages, "chkHidePercentages");
            this.chkHidePercentages.Name = "chkHidePercentages";
            this.chkHidePercentages.UseVisualStyleBackColor = true;
            // 
            // chkHideWinsInfo
            // 
            resources.ApplyResources(this.chkHideWinsInfo, "chkHideWinsInfo");
            this.chkHideWinsInfo.Name = "chkHideWinsInfo";
            this.chkHideWinsInfo.UseVisualStyleBackColor = true;
            // 
            // cboOverlayColor
            // 
            resources.ApplyResources(this.cboOverlayColor, "cboOverlayColor");
            this.cboOverlayColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOverlayColor.FormattingEnabled = true;
            this.cboOverlayColor.Items.AddRange(new object[] {
            resources.GetString("cboOverlayColor.Items"),
            resources.GetString("cboOverlayColor.Items1"),
            resources.GetString("cboOverlayColor.Items2"),
            resources.GetString("cboOverlayColor.Items3"),
            resources.GetString("cboOverlayColor.Items4"),
            resources.GetString("cboOverlayColor.Items5")});
            this.cboOverlayColor.Name = "cboOverlayColor";
            // 
            // lblOverlayColor
            // 
            resources.ApplyResources(this.lblOverlayColor, "lblOverlayColor");
            this.lblOverlayColor.Name = "lblOverlayColor";
            // 
            // chkFlipped
            // 
            resources.ApplyResources(this.chkFlipped, "chkFlipped");
            this.chkFlipped.Name = "chkFlipped";
            this.chkFlipped.UseVisualStyleBackColor = true;
            // 
            // chkShowTabs
            // 
            resources.ApplyResources(this.chkShowTabs, "chkShowTabs");
            this.chkShowTabs.Name = "chkShowTabs";
            this.chkShowTabs.UseVisualStyleBackColor = true;
            // 
            // chkHideTimeInfo
            // 
            resources.ApplyResources(this.chkHideTimeInfo, "chkHideTimeInfo");
            this.chkHideTimeInfo.Name = "chkHideTimeInfo";
            this.chkHideTimeInfo.UseVisualStyleBackColor = true;
            // 
            // chkHideRoundInfo
            // 
            resources.ApplyResources(this.chkHideRoundInfo, "chkHideRoundInfo");
            this.chkHideRoundInfo.Name = "chkHideRoundInfo";
            this.chkHideRoundInfo.UseVisualStyleBackColor = true;
            // 
            // cboLanguage
            // 
            resources.ApplyResources(this.cboLanguage, "cboLanguage");
            this.cboLanguage.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("cboLanguage.AutoCompleteCustomSource"),
            resources.GetString("cboLanguage.AutoCompleteCustomSource1"),
            resources.GetString("cboLanguage.AutoCompleteCustomSource2")});
            this.cboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLanguage.FormattingEnabled = true;
            this.cboLanguage.Items.AddRange(new object[] {
            resources.GetString("cboLanguage.Items"),
            resources.GetString("cboLanguage.Items1"),
            resources.GetString("cboLanguage.Items2")});
            this.cboLanguage.Name = "cboLanguage";
            // 
            // lblLanguage
            // 
            resources.ApplyResources(this.lblLanguage, "lblLanguage");
            this.lblLanguage.Name = "lblLanguage";
            // 
            // cboFastestFilter
            // 
            resources.ApplyResources(this.cboFastestFilter, "cboFastestFilter");
            this.cboFastestFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFastestFilter.FormattingEnabled = true;
            this.cboFastestFilter.Items.AddRange(new object[] {
            resources.GetString("cboFastestFilter.Items"),
            resources.GetString("cboFastestFilter.Items1"),
            resources.GetString("cboFastestFilter.Items2"),
            resources.GetString("cboFastestFilter.Items3"),
            resources.GetString("cboFastestFilter.Items4"),
            resources.GetString("cboFastestFilter.Items5")});
            this.cboFastestFilter.Name = "cboFastestFilter";
            // 
            // lblFastestFilter
            // 
            resources.ApplyResources(this.lblFastestFilter, "lblFastestFilter");
            this.lblFastestFilter.Name = "lblFastestFilter";
            // 
            // cboQualifyFilter
            // 
            resources.ApplyResources(this.cboQualifyFilter, "cboQualifyFilter");
            this.cboQualifyFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQualifyFilter.FormattingEnabled = true;
            this.cboQualifyFilter.Items.AddRange(new object[] {
            resources.GetString("cboQualifyFilter.Items"),
            resources.GetString("cboQualifyFilter.Items1"),
            resources.GetString("cboQualifyFilter.Items2"),
            resources.GetString("cboQualifyFilter.Items3"),
            resources.GetString("cboQualifyFilter.Items4"),
            resources.GetString("cboQualifyFilter.Items5")});
            this.cboQualifyFilter.Name = "cboQualifyFilter";
            // 
            // lblQualifyFilter
            // 
            resources.ApplyResources(this.lblQualifyFilter, "lblQualifyFilter");
            this.lblQualifyFilter.Name = "lblQualifyFilter";
            // 
            // cboWinsFilter
            // 
            resources.ApplyResources(this.cboWinsFilter, "cboWinsFilter");
            this.cboWinsFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWinsFilter.FormattingEnabled = true;
            this.cboWinsFilter.Items.AddRange(new object[] {
            resources.GetString("cboWinsFilter.Items"),
            resources.GetString("cboWinsFilter.Items1"),
            resources.GetString("cboWinsFilter.Items2"),
            resources.GetString("cboWinsFilter.Items3"),
            resources.GetString("cboWinsFilter.Items4"),
            resources.GetString("cboWinsFilter.Items5")});
            this.cboWinsFilter.Name = "cboWinsFilter";
            // 
            // lblWinsFilter
            // 
            resources.ApplyResources(this.lblWinsFilter, "lblWinsFilter");
            this.lblWinsFilter.Name = "lblWinsFilter";
            // 
            // chkOverlayOnTop
            // 
            resources.ApplyResources(this.chkOverlayOnTop, "chkOverlayOnTop");
            this.chkOverlayOnTop.Name = "chkOverlayOnTop";
            this.chkOverlayOnTop.UseVisualStyleBackColor = true;
            // 
            // lblCycleTimeSecondsTag
            // 
            resources.ApplyResources(this.lblCycleTimeSecondsTag, "lblCycleTimeSecondsTag");
            this.lblCycleTimeSecondsTag.Name = "lblCycleTimeSecondsTag";
            // 
            // lblCycleTimeSeconds
            // 
            resources.ApplyResources(this.lblCycleTimeSeconds, "lblCycleTimeSeconds");
            this.lblCycleTimeSeconds.Name = "lblCycleTimeSeconds";
            // 
            // txtCycleTimeSeconds
            // 
            resources.ApplyResources(this.txtCycleTimeSeconds, "txtCycleTimeSeconds");
            this.txtCycleTimeSeconds.Name = "txtCycleTimeSeconds";
            this.txtCycleTimeSeconds.Validating += new System.ComponentModel.CancelEventHandler(this.txtCycleTimeSeconds_Validating);
            // 
            // grpCycleWinFinalStreak
            // 
            resources.ApplyResources(this.grpCycleWinFinalStreak, "grpCycleWinFinalStreak");
            this.grpCycleWinFinalStreak.Controls.Add(this.chkOnlyShowFinalStreak);
            this.grpCycleWinFinalStreak.Controls.Add(this.chkOnlyShowWinStreak);
            this.grpCycleWinFinalStreak.Controls.Add(this.chkCycleWinFinalStreak);
            this.grpCycleWinFinalStreak.Name = "grpCycleWinFinalStreak";
            this.grpCycleWinFinalStreak.TabStop = false;
            // 
            // chkOnlyShowFinalStreak
            // 
            resources.ApplyResources(this.chkOnlyShowFinalStreak, "chkOnlyShowFinalStreak");
            this.chkOnlyShowFinalStreak.Name = "chkOnlyShowFinalStreak";
            this.chkOnlyShowFinalStreak.UseVisualStyleBackColor = true;
            // 
            // chkOnlyShowWinStreak
            // 
            resources.ApplyResources(this.chkOnlyShowWinStreak, "chkOnlyShowWinStreak");
            this.chkOnlyShowWinStreak.Name = "chkOnlyShowWinStreak";
            this.chkOnlyShowWinStreak.UseVisualStyleBackColor = true;
            // 
            // chkCycleWinFinalStreak
            // 
            resources.ApplyResources(this.chkCycleWinFinalStreak, "chkCycleWinFinalStreak");
            this.chkCycleWinFinalStreak.Checked = true;
            this.chkCycleWinFinalStreak.Name = "chkCycleWinFinalStreak";
            this.chkCycleWinFinalStreak.TabStop = true;
            this.chkCycleWinFinalStreak.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.chkOnlyShowPing);
            this.groupBox1.Controls.Add(this.chkOnlyShowPlayers);
            this.groupBox1.Controls.Add(this.chkCyclePlayersPing);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // chkOnlyShowPing
            // 
            resources.ApplyResources(this.chkOnlyShowPing, "chkOnlyShowPing");
            this.chkOnlyShowPing.Name = "chkOnlyShowPing";
            this.chkOnlyShowPing.UseVisualStyleBackColor = true;
            // 
            // chkOnlyShowPlayers
            // 
            resources.ApplyResources(this.chkOnlyShowPlayers, "chkOnlyShowPlayers");
            this.chkOnlyShowPlayers.Name = "chkOnlyShowPlayers";
            this.chkOnlyShowPlayers.UseVisualStyleBackColor = true;
            // 
            // chkCyclePlayersPing
            // 
            resources.ApplyResources(this.chkCyclePlayersPing, "chkCyclePlayersPing");
            this.chkCyclePlayersPing.Checked = true;
            this.chkCyclePlayersPing.Name = "chkCyclePlayersPing";
            this.chkCyclePlayersPing.TabStop = true;
            this.chkCyclePlayersPing.UseVisualStyleBackColor = true;
            // 
            // lblOverlayFont
            // 
            resources.ApplyResources(this.lblOverlayFont, "lblOverlayFont");
            this.lblOverlayFont.Name = "lblOverlayFont";
            // 
            // btnSelectFont
            // 
            resources.ApplyResources(this.btnSelectFont, "btnSelectFont");
            this.btnSelectFont.Name = "btnSelectFont";
            this.btnSelectFont.UseVisualStyleBackColor = true;
            this.btnSelectFont.Click += new System.EventHandler(this.btnSelectFont_Click);
            // 
            // btnResetOverlayFont
            // 
            resources.ApplyResources(this.btnResetOverlayFont, "btnResetOverlayFont");
            this.btnResetOverlayFont.Name = "btnResetOverlayFont";
            this.btnResetOverlayFont.UseVisualStyleBackColor = true;
            this.btnResetOverlayFont.Click += new System.EventHandler(this.btnResetOverlayFont_Click);
            // 
            // grpOverlayFontExample
            // 
            resources.ApplyResources(this.grpOverlayFontExample, "grpOverlayFontExample");
            this.grpOverlayFontExample.Controls.Add(this.lblOverlayFontExample);
            this.grpOverlayFontExample.Name = "grpOverlayFontExample";
            this.grpOverlayFontExample.TabStop = false;
            // 
            // lblOverlayFontExample
            // 
            resources.ApplyResources(this.lblOverlayFontExample, "lblOverlayFontExample");
            this.lblOverlayFontExample.Name = "lblOverlayFontExample";
            // 
            // grpStats
            // 
            resources.ApplyResources(this.grpStats, "grpStats");
            this.grpStats.Controls.Add(this.chkChangeHoopsieLegends);
            this.grpStats.Controls.Add(this.chkAutoUpdate);
            this.grpStats.Controls.Add(this.lblPreviousWinsNote);
            this.grpStats.Controls.Add(this.lblPreviousWins);
            this.grpStats.Controls.Add(this.txtPreviousWins);
            this.grpStats.Name = "grpStats";
            this.grpStats.TabStop = false;
            // 
            // chkChangeHoopsieLegends
            // 
            resources.ApplyResources(this.chkChangeHoopsieLegends, "chkChangeHoopsieLegends");
            this.chkChangeHoopsieLegends.Name = "chkChangeHoopsieLegends";
            this.chkChangeHoopsieLegends.UseVisualStyleBackColor = true;
            // 
            // chkAutoUpdate
            // 
            resources.ApplyResources(this.chkAutoUpdate, "chkAutoUpdate");
            this.chkAutoUpdate.Name = "chkAutoUpdate";
            this.chkAutoUpdate.UseVisualStyleBackColor = true;
            // 
            // lblPreviousWinsNote
            // 
            resources.ApplyResources(this.lblPreviousWinsNote, "lblPreviousWinsNote");
            this.lblPreviousWinsNote.ForeColor = System.Drawing.Color.DimGray;
            this.lblPreviousWinsNote.Name = "lblPreviousWinsNote";
            // 
            // lblPreviousWins
            // 
            resources.ApplyResources(this.lblPreviousWins, "lblPreviousWins");
            this.lblPreviousWins.Name = "lblPreviousWins";
            // 
            // txtPreviousWins
            // 
            resources.ApplyResources(this.txtPreviousWins, "txtPreviousWins");
            this.txtPreviousWins.Name = "txtPreviousWins";
            this.txtPreviousWins.Validating += new System.ComponentModel.CancelEventHandler(this.txtPreviousWins_Validating);
            // 
            // grpGameOptions
            // 
            resources.ApplyResources(this.grpGameOptions, "grpGameOptions");
            this.grpGameOptions.Controls.Add(this.lblGameExeLocation);
            this.grpGameOptions.Controls.Add(this.txtGameExeLocation);
            this.grpGameOptions.Controls.Add(this.btnGameExeLocationBrowse);
            this.grpGameOptions.Controls.Add(this.chkAutoLaunchGameOnStart);
            this.grpGameOptions.Name = "grpGameOptions";
            this.grpGameOptions.TabStop = false;
            // 
            // lblGameExeLocation
            // 
            resources.ApplyResources(this.lblGameExeLocation, "lblGameExeLocation");
            this.lblGameExeLocation.Name = "lblGameExeLocation";
            // 
            // txtGameExeLocation
            // 
            resources.ApplyResources(this.txtGameExeLocation, "txtGameExeLocation");
            this.txtGameExeLocation.Name = "txtGameExeLocation";
            // 
            // btnGameExeLocationBrowse
            // 
            resources.ApplyResources(this.btnGameExeLocationBrowse, "btnGameExeLocationBrowse");
            this.btnGameExeLocationBrowse.Name = "btnGameExeLocationBrowse";
            this.btnGameExeLocationBrowse.UseVisualStyleBackColor = true;
            this.btnGameExeLocationBrowse.Click += new System.EventHandler(this.btnGameExeLocationBrowse_Click);
            // 
            // chkAutoLaunchGameOnStart
            // 
            resources.ApplyResources(this.chkAutoLaunchGameOnStart, "chkAutoLaunchGameOnStart");
            this.chkAutoLaunchGameOnStart.Name = "chkAutoLaunchGameOnStart";
            // 
            // grpSortingOptions
            // 
            resources.ApplyResources(this.grpSortingOptions, "grpSortingOptions");
            this.grpSortingOptions.Controls.Add(this.chkIgnoreLevelTypeWhenSorting);
            this.grpSortingOptions.Name = "grpSortingOptions";
            this.grpSortingOptions.TabStop = false;
            // 
            // chkIgnoreLevelTypeWhenSorting
            // 
            resources.ApplyResources(this.chkIgnoreLevelTypeWhenSorting, "chkIgnoreLevelTypeWhenSorting");
            this.chkIgnoreLevelTypeWhenSorting.Name = "chkIgnoreLevelTypeWhenSorting";
            this.chkIgnoreLevelTypeWhenSorting.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Settings
            // 
            this.AcceptButton = this.btnSave;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpGameOptions);
            this.Controls.Add(this.grpSortingOptions);
            this.Controls.Add(this.grpOverlay);
            this.Controls.Add(this.grpStats);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtLogPath);
            this.Controls.Add(this.lblLogPathNote);
            this.Controls.Add(this.lblLogPath);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Settings_Load);
            this.grpOverlay.ResumeLayout(false);
            this.grpOverlay.PerformLayout();
            this.grpCycleQualifyGold.ResumeLayout(false);
            this.grpCycleQualifyGold.PerformLayout();
            this.grpCycleFastestLongest.ResumeLayout(false);
            this.grpCycleFastestLongest.PerformLayout();
            this.grpCycleWinFinalStreak.ResumeLayout(false);
            this.grpCycleWinFinalStreak.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpOverlayFontExample.ResumeLayout(false);
            this.grpStats.ResumeLayout(false);
            this.grpStats.PerformLayout();
            this.grpGameOptions.ResumeLayout(false);
            this.grpGameOptions.PerformLayout();
            this.grpSortingOptions.ResumeLayout(false);
            this.grpSortingOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogPath;
        private System.Windows.Forms.Label lblLogPathNote;
        private System.Windows.Forms.TextBox txtLogPath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpOverlay;
        private System.Windows.Forms.Label lblCycleTimeSecondsTag;
        private System.Windows.Forms.Label lblCycleTimeSeconds;
        private System.Windows.Forms.TextBox txtCycleTimeSeconds;
        private System.Windows.Forms.GroupBox grpStats;
        private System.Windows.Forms.Label lblPreviousWinsNote;
        private System.Windows.Forms.Label lblPreviousWins;
        private System.Windows.Forms.TextBox txtPreviousWins;
        private System.Windows.Forms.CheckBox chkOverlayOnTop;
        private System.Windows.Forms.ComboBox cboFastestFilter;
        private System.Windows.Forms.Label lblFastestFilter;
        private System.Windows.Forms.ComboBox cboQualifyFilter;
        private System.Windows.Forms.Label lblQualifyFilter;
        private System.Windows.Forms.ComboBox cboWinsFilter;
        private System.Windows.Forms.Label lblWinsFilter;
        private System.Windows.Forms.CheckBox chkHideTimeInfo;
        private System.Windows.Forms.CheckBox chkHideRoundInfo;
        private System.Windows.Forms.CheckBox chkShowTabs;
        private System.Windows.Forms.CheckBox chkAutoUpdate;
        private System.Windows.Forms.ComboBox cboOverlayColor;
        private System.Windows.Forms.Label lblOverlayColor;
        private System.Windows.Forms.CheckBox chkFlipped;
        private System.Windows.Forms.CheckBox chkHideWinsInfo;
        private System.Windows.Forms.CheckBox chkHidePercentages;
        private System.Windows.Forms.CheckBox chkChangeHoopsieLegends;
        private System.Windows.Forms.GroupBox grpGameOptions;
        private System.Windows.Forms.Label lblGameExeLocation;
        private System.Windows.Forms.TextBox txtGameExeLocation;
        private System.Windows.Forms.Button btnGameExeLocationBrowse;
        private System.Windows.Forms.CheckBox chkAutoLaunchGameOnStart;
        private System.Windows.Forms.GroupBox grpSortingOptions;
        private System.Windows.Forms.CheckBox chkIgnoreLevelTypeWhenSorting;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpCycleQualifyGold;
        private System.Windows.Forms.RadioButton chkOnlyShowGold;
        private System.Windows.Forms.RadioButton chkOnlyShowQualify;
        private System.Windows.Forms.RadioButton chkCycleQualifyGold;
        private System.Windows.Forms.GroupBox grpCycleFastestLongest;
        private System.Windows.Forms.RadioButton chkOnlyShowLongest;
        private System.Windows.Forms.RadioButton chkOnlyShowFastest;
        private System.Windows.Forms.RadioButton chkCycleFastestLongest;
        private System.Windows.Forms.GroupBox grpCycleWinFinalStreak;
        private System.Windows.Forms.RadioButton chkOnlyShowFinalStreak;
        private System.Windows.Forms.RadioButton chkOnlyShowWinStreak;
        private System.Windows.Forms.RadioButton chkCycleWinFinalStreak;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton chkOnlyShowPing;
        private System.Windows.Forms.RadioButton chkOnlyShowPlayers;
        private System.Windows.Forms.RadioButton chkCyclePlayersPing;
        private System.Windows.Forms.Label lblOverlayFont;
        private System.Windows.Forms.Button btnSelectFont;
        private System.Windows.Forms.FontDialog dlgOverlayFont;
        private System.Windows.Forms.Label lblOverlayFontExample;
        private System.Windows.Forms.GroupBox grpOverlayFontExample;
        private System.Windows.Forms.Button btnResetOverlayFont;
        private System.Windows.Forms.ComboBox cboLanguage;
        private System.Windows.Forms.Label lblLanguage;
    }
}