namespace COMP123_S2019_FinalTestC.Views
{
    partial class CharacterGenerationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.IdentityPage = new System.Windows.Forms.TabPage();
            this.IdentityTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.GenerateNameButton = new System.Windows.Forms.Button();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameDataLabel = new System.Windows.Forms.Label();
            this.LastNameDataLabel = new System.Windows.Forms.Label();
            this.AbilityPage = new System.Windows.Forms.TabPage();
            this.AbilitiestableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.StrengthDataLabel = new System.Windows.Forms.Label();
            this.DexterityLabel = new System.Windows.Forms.Label();
            this.StrengthLabel = new System.Windows.Forms.Label();
            this.GenerateAbilitiesButton = new System.Windows.Forms.Button();
            this.EnduranceLabel = new System.Windows.Forms.Label();
            this.IntellectLabel = new System.Windows.Forms.Label();
            this.EducationLabel = new System.Windows.Forms.Label();
            this.SocialStandingLabel = new System.Windows.Forms.Label();
            this.DexterityDataLabel = new System.Windows.Forms.Label();
            this.EnduranceDataLabel = new System.Windows.Forms.Label();
            this.IntellectDataLabel = new System.Windows.Forms.Label();
            this.EducationDataLabel = new System.Windows.Forms.Label();
            this.SocialStandingDataLabel = new System.Windows.Forms.Label();
            this.SkillsPage = new System.Windows.Forms.TabPage();
            this.CharacterSheetPage = new System.Windows.Forms.TabPage();
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Skilllabel = new System.Windows.Forms.Label();
            this.FirstSkilllabel = new System.Windows.Forms.Label();
            this.SecondSkilllabel = new System.Windows.Forms.Label();
            this.ThirdSkilllabel = new System.Windows.Forms.Label();
            this.FourthSkilllabel = new System.Windows.Forms.Label();
            this.GenerateSkillsbutton = new System.Windows.Forms.Button();
            this.MainTabControl.SuspendLayout();
            this.IdentityPage.SuspendLayout();
            this.IdentityTableLayoutPanel.SuspendLayout();
            this.AbilityPage.SuspendLayout();
            this.AbilitiestableLayoutPanel.SuspendLayout();
            this.SkillsPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.IdentityPage);
            this.MainTabControl.Controls.Add(this.AbilityPage);
            this.MainTabControl.Controls.Add(this.SkillsPage);
            this.MainTabControl.Controls.Add(this.CharacterSheetPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(549, 335);
            this.MainTabControl.TabIndex = 0;
            // 
            // IdentityPage
            // 
            this.IdentityPage.Controls.Add(this.IdentityTableLayoutPanel);
            this.IdentityPage.Location = new System.Drawing.Point(4, 33);
            this.IdentityPage.Margin = new System.Windows.Forms.Padding(2);
            this.IdentityPage.Name = "IdentityPage";
            this.IdentityPage.Padding = new System.Windows.Forms.Padding(2);
            this.IdentityPage.Size = new System.Drawing.Size(541, 298);
            this.IdentityPage.TabIndex = 0;
            this.IdentityPage.Text = "Identity";
            this.IdentityPage.UseVisualStyleBackColor = true;
            // 
            // IdentityTableLayoutPanel
            // 
            this.IdentityTableLayoutPanel.ColumnCount = 4;
            this.IdentityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.Controls.Add(this.FirstNameLabel, 0, 0);
            this.IdentityTableLayoutPanel.Controls.Add(this.GenerateNameButton, 2, 3);
            this.IdentityTableLayoutPanel.Controls.Add(this.LastNameLabel, 0, 1);
            this.IdentityTableLayoutPanel.Controls.Add(this.FirstNameDataLabel, 1, 0);
            this.IdentityTableLayoutPanel.Controls.Add(this.LastNameDataLabel, 1, 1);
            this.IdentityTableLayoutPanel.Location = new System.Drawing.Point(5, 5);
            this.IdentityTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.IdentityTableLayoutPanel.Name = "IdentityTableLayoutPanel";
            this.IdentityTableLayoutPanel.RowCount = 4;
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.Size = new System.Drawing.Size(530, 241);
            this.IdentityTableLayoutPanel.TabIndex = 0;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameLabel.Location = new System.Drawing.Point(2, 0);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(128, 60);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name";
            this.FirstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GenerateNameButton
            // 
            this.GenerateNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdentityTableLayoutPanel.SetColumnSpan(this.GenerateNameButton, 2);
            this.GenerateNameButton.Location = new System.Drawing.Point(266, 182);
            this.GenerateNameButton.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateNameButton.Name = "GenerateNameButton";
            this.GenerateNameButton.Size = new System.Drawing.Size(262, 57);
            this.GenerateNameButton.TabIndex = 1;
            this.GenerateNameButton.Text = "Generate Name";
            this.GenerateNameButton.UseVisualStyleBackColor = true;
            this.GenerateNameButton.Click += new System.EventHandler(this.GenerateNameButton_Click);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameLabel.Location = new System.Drawing.Point(2, 60);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(128, 60);
            this.LastNameLabel.TabIndex = 1;
            this.LastNameLabel.Text = "Last Name";
            this.LastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FirstNameDataLabel
            // 
            this.FirstNameDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FirstNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdentityTableLayoutPanel.SetColumnSpan(this.FirstNameDataLabel, 3);
            this.FirstNameDataLabel.Location = new System.Drawing.Point(134, 0);
            this.FirstNameDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstNameDataLabel.Name = "FirstNameDataLabel";
            this.FirstNameDataLabel.Size = new System.Drawing.Size(394, 60);
            this.FirstNameDataLabel.TabIndex = 0;
            this.FirstNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LastNameDataLabel
            // 
            this.LastNameDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LastNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdentityTableLayoutPanel.SetColumnSpan(this.LastNameDataLabel, 3);
            this.LastNameDataLabel.Location = new System.Drawing.Point(134, 60);
            this.LastNameDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastNameDataLabel.Name = "LastNameDataLabel";
            this.LastNameDataLabel.Size = new System.Drawing.Size(394, 60);
            this.LastNameDataLabel.TabIndex = 0;
            this.LastNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AbilityPage
            // 
            this.AbilityPage.Controls.Add(this.AbilitiestableLayoutPanel);
            this.AbilityPage.Location = new System.Drawing.Point(4, 33);
            this.AbilityPage.Margin = new System.Windows.Forms.Padding(2);
            this.AbilityPage.Name = "AbilityPage";
            this.AbilityPage.Padding = new System.Windows.Forms.Padding(2);
            this.AbilityPage.Size = new System.Drawing.Size(541, 298);
            this.AbilityPage.TabIndex = 1;
            this.AbilityPage.Text = "Abilities";
            this.AbilityPage.UseVisualStyleBackColor = true;
            // 
            // AbilitiestableLayoutPanel
            // 
            this.AbilitiestableLayoutPanel.ColumnCount = 4;
            this.AbilitiestableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.AbilitiestableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AbilitiestableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AbilitiestableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilitiestableLayoutPanel.Controls.Add(this.StrengthDataLabel, 1, 0);
            this.AbilitiestableLayoutPanel.Controls.Add(this.DexterityLabel, 0, 1);
            this.AbilitiestableLayoutPanel.Controls.Add(this.StrengthLabel, 0, 0);
            this.AbilitiestableLayoutPanel.Controls.Add(this.GenerateAbilitiesButton, 2, 7);
            this.AbilitiestableLayoutPanel.Controls.Add(this.EnduranceLabel, 0, 2);
            this.AbilitiestableLayoutPanel.Controls.Add(this.IntellectLabel, 0, 3);
            this.AbilitiestableLayoutPanel.Controls.Add(this.EducationLabel, 0, 4);
            this.AbilitiestableLayoutPanel.Controls.Add(this.SocialStandingLabel, 0, 5);
            this.AbilitiestableLayoutPanel.Controls.Add(this.DexterityDataLabel, 1, 1);
            this.AbilitiestableLayoutPanel.Controls.Add(this.EnduranceDataLabel, 1, 2);
            this.AbilitiestableLayoutPanel.Controls.Add(this.IntellectDataLabel, 1, 3);
            this.AbilitiestableLayoutPanel.Controls.Add(this.EducationDataLabel, 1, 4);
            this.AbilitiestableLayoutPanel.Controls.Add(this.SocialStandingDataLabel, 1, 5);
            this.AbilitiestableLayoutPanel.Location = new System.Drawing.Point(8, 5);
            this.AbilitiestableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.AbilitiestableLayoutPanel.Name = "AbilitiestableLayoutPanel";
            this.AbilitiestableLayoutPanel.RowCount = 8;
            this.AbilitiestableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiestableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiestableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiestableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiestableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiestableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiestableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiestableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiestableLayoutPanel.Size = new System.Drawing.Size(527, 292);
            this.AbilitiestableLayoutPanel.TabIndex = 0;
            // 
            // StrengthDataLabel
            // 
            this.StrengthDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StrengthDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StrengthDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StrengthDataLabel.Location = new System.Drawing.Point(186, 0);
            this.StrengthDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StrengthDataLabel.Name = "StrengthDataLabel";
            this.StrengthDataLabel.Size = new System.Drawing.Size(101, 36);
            this.StrengthDataLabel.TabIndex = 2;
            this.StrengthDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DexterityLabel
            // 
            this.DexterityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DexterityLabel.Location = new System.Drawing.Point(2, 36);
            this.DexterityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DexterityLabel.Name = "DexterityLabel";
            this.DexterityLabel.Size = new System.Drawing.Size(180, 36);
            this.DexterityLabel.TabIndex = 6;
            this.DexterityLabel.Text = "Dexterity";
            this.DexterityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StrengthLabel
            // 
            this.StrengthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StrengthLabel.Location = new System.Drawing.Point(2, 0);
            this.StrengthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StrengthLabel.Name = "StrengthLabel";
            this.StrengthLabel.Size = new System.Drawing.Size(180, 36);
            this.StrengthLabel.TabIndex = 2;
            this.StrengthLabel.Text = "Strength";
            this.StrengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GenerateAbilitiesButton
            // 
            this.GenerateAbilitiesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AbilitiestableLayoutPanel.SetColumnSpan(this.GenerateAbilitiesButton, 2);
            this.GenerateAbilitiesButton.Location = new System.Drawing.Point(291, 254);
            this.GenerateAbilitiesButton.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateAbilitiesButton.Name = "GenerateAbilitiesButton";
            this.GenerateAbilitiesButton.Size = new System.Drawing.Size(234, 36);
            this.GenerateAbilitiesButton.TabIndex = 2;
            this.GenerateAbilitiesButton.Text = "Generate Abilities";
            this.GenerateAbilitiesButton.UseVisualStyleBackColor = true;
            // 
            // EnduranceLabel
            // 
            this.EnduranceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnduranceLabel.Location = new System.Drawing.Point(2, 72);
            this.EnduranceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnduranceLabel.Name = "EnduranceLabel";
            this.EnduranceLabel.Size = new System.Drawing.Size(180, 36);
            this.EnduranceLabel.TabIndex = 7;
            this.EnduranceLabel.Text = "Endurance";
            this.EnduranceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IntellectLabel
            // 
            this.IntellectLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntellectLabel.Location = new System.Drawing.Point(2, 108);
            this.IntellectLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IntellectLabel.Name = "IntellectLabel";
            this.IntellectLabel.Size = new System.Drawing.Size(180, 36);
            this.IntellectLabel.TabIndex = 3;
            this.IntellectLabel.Text = "Intellect";
            this.IntellectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EducationLabel
            // 
            this.EducationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EducationLabel.Location = new System.Drawing.Point(2, 144);
            this.EducationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EducationLabel.Name = "EducationLabel";
            this.EducationLabel.Size = new System.Drawing.Size(180, 36);
            this.EducationLabel.TabIndex = 4;
            this.EducationLabel.Text = "Education";
            this.EducationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SocialStandingLabel
            // 
            this.SocialStandingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SocialStandingLabel.Location = new System.Drawing.Point(2, 180);
            this.SocialStandingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SocialStandingLabel.Name = "SocialStandingLabel";
            this.SocialStandingLabel.Size = new System.Drawing.Size(180, 36);
            this.SocialStandingLabel.TabIndex = 5;
            this.SocialStandingLabel.Text = "Social Standing";
            this.SocialStandingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DexterityDataLabel
            // 
            this.DexterityDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DexterityDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DexterityDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DexterityDataLabel.Location = new System.Drawing.Point(186, 36);
            this.DexterityDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DexterityDataLabel.Name = "DexterityDataLabel";
            this.DexterityDataLabel.Size = new System.Drawing.Size(101, 36);
            this.DexterityDataLabel.TabIndex = 8;
            this.DexterityDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EnduranceDataLabel
            // 
            this.EnduranceDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnduranceDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EnduranceDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnduranceDataLabel.Location = new System.Drawing.Point(186, 72);
            this.EnduranceDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnduranceDataLabel.Name = "EnduranceDataLabel";
            this.EnduranceDataLabel.Size = new System.Drawing.Size(101, 36);
            this.EnduranceDataLabel.TabIndex = 9;
            this.EnduranceDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IntellectDataLabel
            // 
            this.IntellectDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntellectDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.IntellectDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IntellectDataLabel.Location = new System.Drawing.Point(186, 108);
            this.IntellectDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IntellectDataLabel.Name = "IntellectDataLabel";
            this.IntellectDataLabel.Size = new System.Drawing.Size(101, 36);
            this.IntellectDataLabel.TabIndex = 10;
            this.IntellectDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EducationDataLabel
            // 
            this.EducationDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EducationDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EducationDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EducationDataLabel.Location = new System.Drawing.Point(186, 144);
            this.EducationDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EducationDataLabel.Name = "EducationDataLabel";
            this.EducationDataLabel.Size = new System.Drawing.Size(101, 36);
            this.EducationDataLabel.TabIndex = 11;
            this.EducationDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SocialStandingDataLabel
            // 
            this.SocialStandingDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SocialStandingDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SocialStandingDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SocialStandingDataLabel.Location = new System.Drawing.Point(186, 180);
            this.SocialStandingDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SocialStandingDataLabel.Name = "SocialStandingDataLabel";
            this.SocialStandingDataLabel.Size = new System.Drawing.Size(101, 36);
            this.SocialStandingDataLabel.TabIndex = 12;
            this.SocialStandingDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SkillsPage
            // 
            this.SkillsPage.Controls.Add(this.GenerateSkillsbutton);
            this.SkillsPage.Controls.Add(this.tableLayoutPanel1);
            this.SkillsPage.Location = new System.Drawing.Point(4, 33);
            this.SkillsPage.Margin = new System.Windows.Forms.Padding(2);
            this.SkillsPage.Name = "SkillsPage";
            this.SkillsPage.Size = new System.Drawing.Size(541, 298);
            this.SkillsPage.TabIndex = 2;
            this.SkillsPage.Text = "Skills";
            this.SkillsPage.UseVisualStyleBackColor = true;
            // 
            // CharacterSheetPage
            // 
            this.CharacterSheetPage.Location = new System.Drawing.Point(4, 33);
            this.CharacterSheetPage.Margin = new System.Windows.Forms.Padding(2);
            this.CharacterSheetPage.Name = "CharacterSheetPage";
            this.CharacterSheetPage.Size = new System.Drawing.Size(541, 298);
            this.CharacterSheetPage.TabIndex = 3;
            this.CharacterSheetPage.Text = "Character Sheet";
            this.CharacterSheetPage.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(442, 352);
            this.NextButton.Margin = new System.Windows.Forms.Padding(2);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(96, 47);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(11, 352);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(96, 47);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.Skilllabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.FirstSkilllabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SecondSkilllabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ThirdSkilllabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.FourthSkilllabel, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(293, 250);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Skilllabel
            // 
            this.Skilllabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Skilllabel.Location = new System.Drawing.Point(3, 0);
            this.Skilllabel.Name = "Skilllabel";
            this.Skilllabel.Size = new System.Drawing.Size(67, 50);
            this.Skilllabel.TabIndex = 0;
            this.Skilllabel.Text = "Skills";
            this.Skilllabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FirstSkilllabel
            // 
            this.FirstSkilllabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstSkilllabel.BackColor = System.Drawing.Color.LightGray;
            this.FirstSkilllabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstSkilllabel.Location = new System.Drawing.Point(3, 50);
            this.FirstSkilllabel.Name = "FirstSkilllabel";
            this.FirstSkilllabel.Size = new System.Drawing.Size(67, 50);
            this.FirstSkilllabel.TabIndex = 1;
            // 
            // SecondSkilllabel
            // 
            this.SecondSkilllabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondSkilllabel.BackColor = System.Drawing.Color.LightGray;
            this.SecondSkilllabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SecondSkilllabel.Location = new System.Drawing.Point(3, 100);
            this.SecondSkilllabel.Name = "SecondSkilllabel";
            this.SecondSkilllabel.Size = new System.Drawing.Size(67, 50);
            this.SecondSkilllabel.TabIndex = 2;
            // 
            // ThirdSkilllabel
            // 
            this.ThirdSkilllabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThirdSkilllabel.BackColor = System.Drawing.Color.LightGray;
            this.ThirdSkilllabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThirdSkilllabel.Location = new System.Drawing.Point(3, 150);
            this.ThirdSkilllabel.Name = "ThirdSkilllabel";
            this.ThirdSkilllabel.Size = new System.Drawing.Size(67, 50);
            this.ThirdSkilllabel.TabIndex = 3;
            // 
            // FourthSkilllabel
            // 
            this.FourthSkilllabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FourthSkilllabel.BackColor = System.Drawing.Color.LightGray;
            this.FourthSkilllabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FourthSkilllabel.Location = new System.Drawing.Point(3, 200);
            this.FourthSkilllabel.Name = "FourthSkilllabel";
            this.FourthSkilllabel.Size = new System.Drawing.Size(67, 50);
            this.FourthSkilllabel.TabIndex = 4;
            // 
            // GenerateSkillsbutton
            // 
            this.GenerateSkillsbutton.Location = new System.Drawing.Point(398, 234);
            this.GenerateSkillsbutton.Name = "GenerateSkillsbutton";
            this.GenerateSkillsbutton.Size = new System.Drawing.Size(122, 61);
            this.GenerateSkillsbutton.TabIndex = 1;
            this.GenerateSkillsbutton.Text = "Generate Skills";
            this.GenerateSkillsbutton.UseVisualStyleBackColor = true;
            this.GenerateSkillsbutton.Click += new System.EventHandler(this.GenerateSkillsbutton_Click);
            // 
            // CharacterGenerationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.ClientSize = new System.Drawing.Size(549, 408);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.MainTabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CharacterGenerationForm";
            this.Text = "Character Generator";
            this.Load += new System.EventHandler(this.CharacterGenerationForm_Load);
            this.MainTabControl.ResumeLayout(false);
            this.IdentityPage.ResumeLayout(false);
            this.IdentityTableLayoutPanel.ResumeLayout(false);
            this.AbilityPage.ResumeLayout(false);
            this.AbilitiestableLayoutPanel.ResumeLayout(false);
            this.SkillsPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage IdentityPage;
        private System.Windows.Forms.TabPage AbilityPage;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TabPage SkillsPage;
        private System.Windows.Forms.TabPage CharacterSheetPage;
        private System.Windows.Forms.TableLayoutPanel IdentityTableLayoutPanel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Button GenerateNameButton;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameDataLabel;
        private System.Windows.Forms.Label LastNameDataLabel;
        private System.Windows.Forms.TableLayoutPanel AbilitiestableLayoutPanel;
        private System.Windows.Forms.Label StrengthDataLabel;
        private System.Windows.Forms.Label DexterityLabel;
        private System.Windows.Forms.Label StrengthLabel;
        private System.Windows.Forms.Button GenerateAbilitiesButton;
        private System.Windows.Forms.Label EnduranceLabel;
        private System.Windows.Forms.Label IntellectLabel;
        private System.Windows.Forms.Label EducationLabel;
        private System.Windows.Forms.Label SocialStandingLabel;
        private System.Windows.Forms.Label DexterityDataLabel;
        private System.Windows.Forms.Label EnduranceDataLabel;
        private System.Windows.Forms.Label IntellectDataLabel;
        private System.Windows.Forms.Label EducationDataLabel;
        private System.Windows.Forms.Label SocialStandingDataLabel;
        private System.Windows.Forms.Button GenerateSkillsbutton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Skilllabel;
        private System.Windows.Forms.Label FirstSkilllabel;
        private System.Windows.Forms.Label SecondSkilllabel;
        private System.Windows.Forms.Label ThirdSkilllabel;
        private System.Windows.Forms.Label FourthSkilllabel;
    }
}
