namespace Assignment_5
{
    partial class SelectForm
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
            this.hardwareListlabel = new System.Windows.Forms.Label();
            this.HardwareListdataGridView = new System.Windows.Forms.DataGridView();
            this.yourSelectionlabel = new System.Windows.Forms.Label();
            this.selectedItemViewtextBox = new System.Windows.Forms.TextBox();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.nextbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HardwareListdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // hardwareListlabel
            // 
            this.hardwareListlabel.AutoSize = true;
            this.hardwareListlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardwareListlabel.Location = new System.Drawing.Point(26, 13);
            this.hardwareListlabel.Name = "hardwareListlabel";
            this.hardwareListlabel.Size = new System.Drawing.Size(305, 25);
            this.hardwareListlabel.TabIndex = 0;
            this.hardwareListlabel.Text = "Dollar Computer Hardware List";
            // 
            // HardwareListdataGridView
            // 
            this.HardwareListdataGridView.AllowUserToAddRows = false;
            this.HardwareListdataGridView.AllowUserToDeleteRows = false;
            this.HardwareListdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HardwareListdataGridView.Location = new System.Drawing.Point(23, 65);
            this.HardwareListdataGridView.Name = "HardwareListdataGridView";
            this.HardwareListdataGridView.ReadOnly = true;
            this.HardwareListdataGridView.Size = new System.Drawing.Size(749, 150);
            this.HardwareListdataGridView.TabIndex = 1;
            // 
            // yourSelectionlabel
            // 
            this.yourSelectionlabel.AutoSize = true;
            this.yourSelectionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourSelectionlabel.Location = new System.Drawing.Point(18, 235);
            this.yourSelectionlabel.Name = "yourSelectionlabel";
            this.yourSelectionlabel.Size = new System.Drawing.Size(153, 25);
            this.yourSelectionlabel.TabIndex = 2;
            this.yourSelectionlabel.Text = "Your Selection";
            // 
            // selectedItemViewtextBox
            // 
            this.selectedItemViewtextBox.Location = new System.Drawing.Point(195, 239);
            this.selectedItemViewtextBox.Name = "selectedItemViewtextBox";
            this.selectedItemViewtextBox.Size = new System.Drawing.Size(340, 20);
            this.selectedItemViewtextBox.TabIndex = 3;
            // 
            // cancelbutton
            // 
            this.cancelbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbutton.Location = new System.Drawing.Point(533, 508);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(96, 41);
            this.cancelbutton.TabIndex = 4;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // nextbutton
            // 
            this.nextbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextbutton.Location = new System.Drawing.Point(661, 508);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(96, 41);
            this.nextbutton.TabIndex = 5;
            this.nextbutton.Text = "Next";
            this.nextbutton.UseVisualStyleBackColor = true;
            this.nextbutton.Click += new System.EventHandler(this.Nextbutton_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.nextbutton);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.selectedItemViewtextBox);
            this.Controls.Add(this.yourSelectionlabel);
            this.Controls.Add(this.HardwareListdataGridView);
            this.Controls.Add(this.hardwareListlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Form";
            ((System.ComponentModel.ISupportInitialize)(this.HardwareListdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hardwareListlabel;
        private System.Windows.Forms.DataGridView HardwareListdataGridView;
        private System.Windows.Forms.Label yourSelectionlabel;
        private System.Windows.Forms.TextBox selectedItemViewtextBox;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button nextbutton;
    }
}