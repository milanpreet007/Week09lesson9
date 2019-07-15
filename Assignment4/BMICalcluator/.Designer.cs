namespace BMICalcluator
{
    partial class BMIcalculator
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
            this.BMItableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CalculateBMIbutton = new System.Windows.Forms.Button();
            this.ImpericalradioButton = new System.Windows.Forms.RadioButton();
            this.Heightlabel = new System.Windows.Forms.Label();
            this.HeightTextbox = new System.Windows.Forms.TextBox();
            this.MetricradioButton = new System.Windows.Forms.RadioButton();
            this.BMIresulttextBox = new System.Windows.Forms.TextBox();
            this.Weightlabel = new System.Windows.Forms.Label();
            this.WeighttextBox = new System.Windows.Forms.TextBox();
            this.BMItableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMItableLayoutPanel
            // 
            this.BMItableLayoutPanel.ColumnCount = 2;
            this.BMItableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMItableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMItableLayoutPanel.Controls.Add(this.CalculateBMIbutton, 0, 4);
            this.BMItableLayoutPanel.Controls.Add(this.ImpericalradioButton, 0, 1);
            this.BMItableLayoutPanel.Controls.Add(this.Heightlabel, 0, 2);
            this.BMItableLayoutPanel.Controls.Add(this.HeightTextbox, 1, 2);
            this.BMItableLayoutPanel.Controls.Add(this.MetricradioButton, 1, 1);
            this.BMItableLayoutPanel.Controls.Add(this.BMIresulttextBox, 1, 4);
            this.BMItableLayoutPanel.Controls.Add(this.Weightlabel, 0, 3);
            this.BMItableLayoutPanel.Controls.Add(this.WeighttextBox, 1, 3);
            this.BMItableLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BMItableLayoutPanel.Location = new System.Drawing.Point(12, 1);
            this.BMItableLayoutPanel.Name = "BMItableLayoutPanel";
            this.BMItableLayoutPanel.RowCount = 5;
            this.BMItableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.73913F));
            this.BMItableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.73913F));
            this.BMItableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.73913F));
            this.BMItableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.3913F));
            this.BMItableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.3913F));
            this.BMItableLayoutPanel.Size = new System.Drawing.Size(320, 480);
            this.BMItableLayoutPanel.TabIndex = 0;
            this.BMItableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BMItableLayoutPanel_Paint);
            // 
            // CalculateBMIbutton
            // 
            this.CalculateBMIbutton.Location = new System.Drawing.Point(3, 398);
            this.CalculateBMIbutton.Name = "CalculateBMIbutton";
            this.CalculateBMIbutton.Size = new System.Drawing.Size(126, 68);
            this.CalculateBMIbutton.TabIndex = 1;
            this.CalculateBMIbutton.Text = "Calculate BMI";
            this.CalculateBMIbutton.UseVisualStyleBackColor = true;
            this.CalculateBMIbutton.Click += new System.EventHandler(this.CalculateBMIbutton_Click);
            // 
            // ImpericalradioButton
            // 
            this.ImpericalradioButton.AutoSize = true;
            this.ImpericalradioButton.Location = new System.Drawing.Point(3, 107);
            this.ImpericalradioButton.Name = "ImpericalradioButton";
            this.ImpericalradioButton.Size = new System.Drawing.Size(104, 28);
            this.ImpericalradioButton.TabIndex = 0;
            this.ImpericalradioButton.TabStop = true;
            this.ImpericalradioButton.Text = "Imperical";
            this.ImpericalradioButton.UseVisualStyleBackColor = true;
            // 
            // Heightlabel
            // 
            this.Heightlabel.AutoSize = true;
            this.Heightlabel.Location = new System.Drawing.Point(3, 208);
            this.Heightlabel.Name = "Heightlabel";
            this.Heightlabel.Size = new System.Drawing.Size(95, 24);
            this.Heightlabel.TabIndex = 2;
            this.Heightlabel.Text = "My Height";
            // 
            // HeightTextbox
            // 
            this.HeightTextbox.Location = new System.Drawing.Point(163, 211);
            this.HeightTextbox.Name = "HeightTextbox";
            this.HeightTextbox.Size = new System.Drawing.Size(100, 29);
            this.HeightTextbox.TabIndex = 3;
            // 
            // MetricradioButton
            // 
            this.MetricradioButton.AutoSize = true;
            this.MetricradioButton.Location = new System.Drawing.Point(163, 107);
            this.MetricradioButton.Name = "MetricradioButton";
            this.MetricradioButton.Size = new System.Drawing.Size(79, 28);
            this.MetricradioButton.TabIndex = 1;
            this.MetricradioButton.TabStop = true;
            this.MetricradioButton.Text = "Metric";
            this.MetricradioButton.UseVisualStyleBackColor = true;
            // 
            // BMIresulttextBox
            // 
            this.BMIresulttextBox.Location = new System.Drawing.Point(163, 398);
            this.BMIresulttextBox.Multiline = true;
            this.BMIresulttextBox.Name = "BMIresulttextBox";
            this.BMIresulttextBox.Size = new System.Drawing.Size(100, 20);
            this.BMIresulttextBox.TabIndex = 4;
            // 
            // Weightlabel
            // 
            this.Weightlabel.AutoSize = true;
            this.Weightlabel.Location = new System.Drawing.Point(3, 312);
            this.Weightlabel.Name = "Weightlabel";
            this.Weightlabel.Size = new System.Drawing.Size(99, 24);
            this.Weightlabel.TabIndex = 6;
            this.Weightlabel.Text = "My Weight";
            this.Weightlabel.Click += new System.EventHandler(this.Label2_Click);
            // 
            // WeighttextBox
            // 
            this.WeighttextBox.Location = new System.Drawing.Point(163, 315);
            this.WeighttextBox.Name = "WeighttextBox";
            this.WeighttextBox.Size = new System.Drawing.Size(100, 29);
            this.WeighttextBox.TabIndex = 7;
            // 
            // BMIcalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.BMItableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMIcalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.BMItableLayoutPanel.ResumeLayout(false);
            this.BMItableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BMItableLayoutPanel;
        private System.Windows.Forms.RadioButton ImpericalradioButton;
        private System.Windows.Forms.RadioButton MetricradioButton;
        private System.Windows.Forms.Label Heightlabel;
        private System.Windows.Forms.Button CalculateBMIbutton;
        private System.Windows.Forms.TextBox HeightTextbox;
        private System.Windows.Forms.TextBox BMIresulttextBox;
        private System.Windows.Forms.Label Weightlabel;
        private System.Windows.Forms.TextBox WeighttextBox;
    }
}

