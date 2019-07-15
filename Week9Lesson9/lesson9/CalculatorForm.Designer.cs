namespace lesson9
{
    partial class CalculatorForm
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
            this.CalculatorButtonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.zerobutton = new System.Windows.Forms.Button();
            this.threebutton = new System.Windows.Forms.Button();
            this.twobutton = new System.Windows.Forms.Button();
            this.onebutton = new System.Windows.Forms.Button();
            this.sixbutton = new System.Windows.Forms.Button();
            this.fivebutton = new System.Windows.Forms.Button();
            this.fourbutton = new System.Windows.Forms.Button();
            this.Ninebutton = new System.Windows.Forms.Button();
            this.Eightbutton = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.resultlabel = new System.Windows.Forms.Label();
            this.Decimalbutton = new System.Windows.Forms.Button();
            this.Heightlabel = new System.Windows.Forms.Label();
            this.Donebutton = new System.Windows.Forms.Button();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.Backbutton = new System.Windows.Forms.Button();
            this.CalculatorButtonTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculatorButtonTableLayoutPanel
            // 
            this.CalculatorButtonTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CalculatorButtonTableLayoutPanel.ColumnCount = 4;
            this.CalculatorButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.resultlabel, 0, 0);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.threebutton, 2, 3);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.twobutton, 1, 3);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.onebutton, 0, 3);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.sixbutton, 2, 2);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.fivebutton, 1, 2);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.fourbutton, 0, 2);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.Ninebutton, 2, 1);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.Eightbutton, 1, 1);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.button7, 0, 1);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.Decimalbutton, 2, 4);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.Backbutton, 3, 1);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.Clearbutton, 3, 2);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.zerobutton, 0, 4);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.Donebutton, 3, 3);
            this.CalculatorButtonTableLayoutPanel.Font = new System.Drawing.Font("Arial", 14F);
            this.CalculatorButtonTableLayoutPanel.Location = new System.Drawing.Point(43, 167);
            this.CalculatorButtonTableLayoutPanel.Name = "CalculatorButtonTableLayoutPanel";
            this.CalculatorButtonTableLayoutPanel.RowCount = 5;
            this.CalculatorButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorButtonTableLayoutPanel.Size = new System.Drawing.Size(320, 351);
            this.CalculatorButtonTableLayoutPanel.TabIndex = 0;
            // 
            // zerobutton
            // 
            this.zerobutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zerobutton.BackColor = System.Drawing.Color.Blue;
            this.CalculatorButtonTableLayoutPanel.SetColumnSpan(this.zerobutton, 2);
            this.zerobutton.ForeColor = System.Drawing.Color.White;
            this.zerobutton.Location = new System.Drawing.Point(3, 283);
            this.zerobutton.Name = "zerobutton";
            this.zerobutton.Size = new System.Drawing.Size(154, 65);
            this.zerobutton.TabIndex = 10;
            this.zerobutton.Tag = "0";
            this.zerobutton.Text = "0";
            this.zerobutton.UseVisualStyleBackColor = false;
            this.zerobutton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // threebutton
            // 
            this.threebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.threebutton.BackColor = System.Drawing.Color.Blue;
            this.threebutton.ForeColor = System.Drawing.Color.White;
            this.threebutton.Location = new System.Drawing.Point(163, 213);
            this.threebutton.Name = "threebutton";
            this.threebutton.Size = new System.Drawing.Size(74, 64);
            this.threebutton.TabIndex = 8;
            this.threebutton.Tag = "3";
            this.threebutton.Text = "3";
            this.threebutton.UseVisualStyleBackColor = false;
            this.threebutton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // twobutton
            // 
            this.twobutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.twobutton.BackColor = System.Drawing.Color.Blue;
            this.twobutton.ForeColor = System.Drawing.Color.White;
            this.twobutton.Location = new System.Drawing.Point(83, 213);
            this.twobutton.Name = "twobutton";
            this.twobutton.Size = new System.Drawing.Size(74, 64);
            this.twobutton.TabIndex = 7;
            this.twobutton.Tag = "2";
            this.twobutton.Text = "2";
            this.twobutton.UseVisualStyleBackColor = false;
            this.twobutton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // onebutton
            // 
            this.onebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.onebutton.BackColor = System.Drawing.Color.Blue;
            this.onebutton.ForeColor = System.Drawing.Color.White;
            this.onebutton.Location = new System.Drawing.Point(3, 213);
            this.onebutton.Name = "onebutton";
            this.onebutton.Size = new System.Drawing.Size(74, 64);
            this.onebutton.TabIndex = 6;
            this.onebutton.Tag = "1";
            this.onebutton.Text = "1";
            this.onebutton.UseVisualStyleBackColor = false;
            this.onebutton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // sixbutton
            // 
            this.sixbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sixbutton.BackColor = System.Drawing.Color.Blue;
            this.sixbutton.ForeColor = System.Drawing.Color.White;
            this.sixbutton.Location = new System.Drawing.Point(163, 143);
            this.sixbutton.Name = "sixbutton";
            this.sixbutton.Size = new System.Drawing.Size(74, 64);
            this.sixbutton.TabIndex = 5;
            this.sixbutton.Tag = "6";
            this.sixbutton.Text = "6";
            this.sixbutton.UseVisualStyleBackColor = false;
            this.sixbutton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // fivebutton
            // 
            this.fivebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fivebutton.BackColor = System.Drawing.Color.Blue;
            this.fivebutton.ForeColor = System.Drawing.Color.White;
            this.fivebutton.Location = new System.Drawing.Point(83, 143);
            this.fivebutton.Name = "fivebutton";
            this.fivebutton.Size = new System.Drawing.Size(74, 64);
            this.fivebutton.TabIndex = 4;
            this.fivebutton.Tag = "5";
            this.fivebutton.Text = "5";
            this.fivebutton.UseVisualStyleBackColor = false;
            this.fivebutton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // fourbutton
            // 
            this.fourbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fourbutton.BackColor = System.Drawing.Color.Blue;
            this.fourbutton.ForeColor = System.Drawing.Color.White;
            this.fourbutton.Location = new System.Drawing.Point(3, 143);
            this.fourbutton.Name = "fourbutton";
            this.fourbutton.Size = new System.Drawing.Size(74, 64);
            this.fourbutton.TabIndex = 3;
            this.fourbutton.Tag = "4";
            this.fourbutton.Text = "4";
            this.fourbutton.UseVisualStyleBackColor = false;
            this.fourbutton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // Ninebutton
            // 
            this.Ninebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ninebutton.BackColor = System.Drawing.Color.Blue;
            this.Ninebutton.ForeColor = System.Drawing.Color.White;
            this.Ninebutton.Location = new System.Drawing.Point(163, 73);
            this.Ninebutton.Name = "Ninebutton";
            this.Ninebutton.Size = new System.Drawing.Size(74, 64);
            this.Ninebutton.TabIndex = 2;
            this.Ninebutton.Tag = "9";
            this.Ninebutton.Text = "9";
            this.Ninebutton.UseVisualStyleBackColor = false;
            this.Ninebutton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // Eightbutton
            // 
            this.Eightbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Eightbutton.BackColor = System.Drawing.Color.Blue;
            this.Eightbutton.ForeColor = System.Drawing.Color.White;
            this.Eightbutton.Location = new System.Drawing.Point(83, 73);
            this.Eightbutton.Name = "Eightbutton";
            this.Eightbutton.Size = new System.Drawing.Size(74, 64);
            this.Eightbutton.TabIndex = 1;
            this.Eightbutton.Tag = "8";
            this.Eightbutton.Text = "8";
            this.Eightbutton.UseVisualStyleBackColor = false;
            this.Eightbutton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.BackColor = System.Drawing.Color.Blue;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(3, 73);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(74, 64);
            this.button7.TabIndex = 0;
            this.button7.Tag = "7";
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // resultlabel
            // 
            this.resultlabel.BackColor = System.Drawing.Color.White;
            this.CalculatorButtonTableLayoutPanel.SetColumnSpan(this.resultlabel, 4);
            this.resultlabel.Font = new System.Drawing.Font("Arial", 26F);
            this.resultlabel.Location = new System.Drawing.Point(3, 0);
            this.resultlabel.Name = "resultlabel";
            this.resultlabel.Size = new System.Drawing.Size(314, 70);
            this.resultlabel.TabIndex = 12;
            this.resultlabel.Text = "0";
            this.resultlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resultlabel.Click += new System.EventHandler(this.Resultlabel_Click);
            // 
            // Decimalbutton
            // 
            this.Decimalbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Decimalbutton.BackColor = System.Drawing.Color.Blue;
            this.Decimalbutton.ForeColor = System.Drawing.Color.White;
            this.Decimalbutton.Location = new System.Drawing.Point(163, 283);
            this.Decimalbutton.Name = "Decimalbutton";
            this.Decimalbutton.Size = new System.Drawing.Size(74, 65);
            this.Decimalbutton.TabIndex = 13;
            this.Decimalbutton.Tag = "decimal";
            this.Decimalbutton.Text = ".";
            this.Decimalbutton.UseVisualStyleBackColor = false;
            this.Decimalbutton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // Heightlabel
            // 
            this.Heightlabel.BackColor = System.Drawing.Color.White;
            this.Heightlabel.Font = new System.Drawing.Font("Arial", 26F);
            this.Heightlabel.Location = new System.Drawing.Point(36, 20);
            this.Heightlabel.Name = "Heightlabel";
            this.Heightlabel.Size = new System.Drawing.Size(138, 69);
            this.Heightlabel.TabIndex = 15;
            this.Heightlabel.Tag = "height";
            this.Heightlabel.Text = "0";
            this.Heightlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Heightlabel.Click += new System.EventHandler(this.Heightlabel_Click);
            // 
            // Donebutton
            // 
            this.Donebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Donebutton.BackColor = System.Drawing.Color.DarkCyan;
            this.Donebutton.ForeColor = System.Drawing.Color.White;
            this.Donebutton.Location = new System.Drawing.Point(243, 213);
            this.Donebutton.Name = "Donebutton";
            this.CalculatorButtonTableLayoutPanel.SetRowSpan(this.Donebutton, 2);
            this.Donebutton.Size = new System.Drawing.Size(74, 135);
            this.Donebutton.TabIndex = 11;
            this.Donebutton.Tag = "done";
            this.Donebutton.Text = "Done";
            this.Donebutton.UseVisualStyleBackColor = false;
            this.Donebutton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // Clearbutton
            // 
            this.Clearbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Clearbutton.BackColor = System.Drawing.Color.Orange;
            this.Clearbutton.ForeColor = System.Drawing.Color.White;
            this.Clearbutton.Location = new System.Drawing.Point(243, 143);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(74, 64);
            this.Clearbutton.TabIndex = 5;
            this.Clearbutton.Tag = "clear";
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = false;
            this.Clearbutton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // Backbutton
            // 
            this.Backbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Backbutton.BackColor = System.Drawing.Color.Blue;
            this.Backbutton.BackgroundImage = global::lesson9.Properties.Resources.backbutton;
            this.Backbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Backbutton.ForeColor = System.Drawing.Color.White;
            this.Backbutton.Location = new System.Drawing.Point(243, 73);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(74, 64);
            this.Backbutton.TabIndex = 14;
            this.Backbutton.Tag = "back";
            this.Backbutton.UseVisualStyleBackColor = false;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 561);
            this.Controls.Add(this.Heightlabel);
            this.Controls.Add(this.CalculatorButtonTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.CalculatorButtonTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CalculatorButtonTableLayoutPanel;
        private System.Windows.Forms.Button zerobutton;
        private System.Windows.Forms.Button threebutton;
        private System.Windows.Forms.Button twobutton;
        private System.Windows.Forms.Button onebutton;
        private System.Windows.Forms.Button sixbutton;
        private System.Windows.Forms.Button fivebutton;
        private System.Windows.Forms.Button fourbutton;
        private System.Windows.Forms.Button Ninebutton;
        private System.Windows.Forms.Button Eightbutton;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label resultlabel;
        private System.Windows.Forms.Button Decimalbutton;
        private System.Windows.Forms.Label Heightlabel;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Button Donebutton;
    }
}

