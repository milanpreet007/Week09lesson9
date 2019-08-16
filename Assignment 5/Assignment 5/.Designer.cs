namespace Assignment_5
{
    partial class StartForm
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
            this.Startneworderbutton = new System.Windows.Forms.Button();
            this.openASavedOrderbutton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Startneworderbutton
            // 
            this.Startneworderbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Startneworderbutton.Location = new System.Drawing.Point(218, 179);
            this.Startneworderbutton.Name = "Startneworderbutton";
            this.Startneworderbutton.Size = new System.Drawing.Size(215, 44);
            this.Startneworderbutton.TabIndex = 0;
            this.Startneworderbutton.Text = "Start a new order";
            this.Startneworderbutton.UseVisualStyleBackColor = true;
            this.Startneworderbutton.Click += new System.EventHandler(this.Startneworderbutton_Click);
            // 
            // openASavedOrderbutton
            // 
            this.openASavedOrderbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openASavedOrderbutton.Location = new System.Drawing.Point(218, 242);
            this.openASavedOrderbutton.Name = "openASavedOrderbutton";
            this.openASavedOrderbutton.Size = new System.Drawing.Size(215, 44);
            this.openASavedOrderbutton.TabIndex = 1;
            this.openASavedOrderbutton.Text = "Open a saved order";
            this.openASavedOrderbutton.UseVisualStyleBackColor = true;
            this.openASavedOrderbutton.Click += new System.EventHandler(this.OpenASavedOrderbutton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(218, 309);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(215, 44);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.openASavedOrderbutton);
            this.Controls.Add(this.Startneworderbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Startneworderbutton;
        private System.Windows.Forms.Button openASavedOrderbutton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
    }
}

