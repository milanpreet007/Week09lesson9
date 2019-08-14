﻿namespace Assignment_5
{
    partial class OrderForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.ordermenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemComponentsgroupBox = new System.Windows.Forms.GroupBox();
            this.modeltextBox = new System.Windows.Forms.TextBox();
            this.platformtextBox = new System.Windows.Forms.TextBox();
            this.manufacturertextBox = new System.Windows.Forms.TextBox();
            this.conditiontextBox = new System.Windows.Forms.TextBox();
            this.modellabel = new System.Windows.Forms.Label();
            this.manufacturerlabel = new System.Windows.Forms.Label();
            this.platformlabel = new System.Windows.Forms.Label();
            this.conditionlabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yourpricegroupBox = new System.Windows.Forms.GroupBox();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.Totallabel = new System.Windows.Forms.Label();
            this.salestextBox = new System.Windows.Forms.TextBox();
            this.pricetextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pricelabel = new System.Windows.Forms.Label();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.finishbutton = new System.Windows.Forms.Button();
            this.Backbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productprintForm = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.ordermenuStrip.SuspendLayout();
            this.systemComponentsgroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.yourpricegroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ordermenuStrip
            // 
            this.ordermenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.ordermenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ordermenuStrip.Name = "ordermenuStrip";
            this.ordermenuStrip.Size = new System.Drawing.Size(800, 24);
            this.ordermenuStrip.TabIndex = 0;
            this.ordermenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // systemComponentsgroupBox
            // 
            this.systemComponentsgroupBox.Controls.Add(this.modeltextBox);
            this.systemComponentsgroupBox.Controls.Add(this.platformtextBox);
            this.systemComponentsgroupBox.Controls.Add(this.manufacturertextBox);
            this.systemComponentsgroupBox.Controls.Add(this.conditiontextBox);
            this.systemComponentsgroupBox.Controls.Add(this.modellabel);
            this.systemComponentsgroupBox.Controls.Add(this.manufacturerlabel);
            this.systemComponentsgroupBox.Controls.Add(this.platformlabel);
            this.systemComponentsgroupBox.Controls.Add(this.conditionlabel);
            this.systemComponentsgroupBox.Location = new System.Drawing.Point(17, 42);
            this.systemComponentsgroupBox.Name = "systemComponentsgroupBox";
            this.systemComponentsgroupBox.Size = new System.Drawing.Size(424, 105);
            this.systemComponentsgroupBox.TabIndex = 8;
            this.systemComponentsgroupBox.TabStop = false;
            this.systemComponentsgroupBox.Text = "System Components";
            // 
            // modeltextBox
            // 
            this.modeltextBox.Location = new System.Drawing.Point(317, 72);
            this.modeltextBox.Name = "modeltextBox";
            this.modeltextBox.Size = new System.Drawing.Size(89, 20);
            this.modeltextBox.TabIndex = 7;
            // 
            // platformtextBox
            // 
            this.platformtextBox.Location = new System.Drawing.Point(317, 35);
            this.platformtextBox.Name = "platformtextBox";
            this.platformtextBox.Size = new System.Drawing.Size(89, 20);
            this.platformtextBox.TabIndex = 6;
            // 
            // manufacturertextBox
            // 
            this.manufacturertextBox.Location = new System.Drawing.Point(116, 69);
            this.manufacturertextBox.Name = "manufacturertextBox";
            this.manufacturertextBox.Size = new System.Drawing.Size(100, 20);
            this.manufacturertextBox.TabIndex = 5;
            // 
            // conditiontextBox
            // 
            this.conditiontextBox.Location = new System.Drawing.Point(100, 30);
            this.conditiontextBox.Name = "conditiontextBox";
            this.conditiontextBox.Size = new System.Drawing.Size(103, 20);
            this.conditiontextBox.TabIndex = 4;
            // 
            // modellabel
            // 
            this.modellabel.AutoSize = true;
            this.modellabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modellabel.Location = new System.Drawing.Point(241, 67);
            this.modellabel.Name = "modellabel";
            this.modellabel.Size = new System.Drawing.Size(63, 24);
            this.modellabel.TabIndex = 3;
            this.modellabel.Text = "Model";
            // 
            // manufacturerlabel
            // 
            this.manufacturerlabel.AutoSize = true;
            this.manufacturerlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturerlabel.Location = new System.Drawing.Point(6, 67);
            this.manufacturerlabel.Name = "manufacturerlabel";
            this.manufacturerlabel.Size = new System.Drawing.Size(104, 20);
            this.manufacturerlabel.TabIndex = 2;
            this.manufacturerlabel.Text = "Manufacturer";
            // 
            // platformlabel
            // 
            this.platformlabel.AutoSize = true;
            this.platformlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platformlabel.Location = new System.Drawing.Point(227, 30);
            this.platformlabel.Name = "platformlabel";
            this.platformlabel.Size = new System.Drawing.Size(77, 24);
            this.platformlabel.TabIndex = 1;
            this.platformlabel.Text = "Platform";
            // 
            // conditionlabel
            // 
            this.conditionlabel.AutoSize = true;
            this.conditionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionlabel.Location = new System.Drawing.Point(20, 27);
            this.conditionlabel.Name = "conditionlabel";
            this.conditionlabel.Size = new System.Drawing.Size(76, 20);
            this.conditionlabel.TabIndex = 0;
            this.conditionlabel.Text = "Condition";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(17, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 243);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "System Components";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(98, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(242, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(132, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(161, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(100, 30);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(148, 20);
            this.textBox4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Manufacturer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Platform";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Condition";
            // 
            // yourpricegroupBox
            // 
            this.yourpricegroupBox.Controls.Add(this.TotaltextBox);
            this.yourpricegroupBox.Controls.Add(this.Totallabel);
            this.yourpricegroupBox.Controls.Add(this.salestextBox);
            this.yourpricegroupBox.Controls.Add(this.pricetextBox);
            this.yourpricegroupBox.Controls.Add(this.label6);
            this.yourpricegroupBox.Controls.Add(this.pricelabel);
            this.yourpricegroupBox.Controls.Add(this.shapeContainer1);
            this.yourpricegroupBox.Location = new System.Drawing.Point(469, 234);
            this.yourpricegroupBox.Name = "yourpricegroupBox";
            this.yourpricegroupBox.Size = new System.Drawing.Size(319, 131);
            this.yourpricegroupBox.TabIndex = 9;
            this.yourpricegroupBox.TabStop = false;
            this.yourpricegroupBox.Text = "Your Price";
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(103, 101);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.Size = new System.Drawing.Size(100, 20);
            this.TotaltextBox.TabIndex = 7;
            // 
            // Totallabel
            // 
            this.Totallabel.AutoSize = true;
            this.Totallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totallabel.Location = new System.Drawing.Point(6, 99);
            this.Totallabel.Name = "Totallabel";
            this.Totallabel.Size = new System.Drawing.Size(44, 20);
            this.Totallabel.TabIndex = 6;
            this.Totallabel.Text = "Total";
            // 
            // salestextBox
            // 
            this.salestextBox.Location = new System.Drawing.Point(103, 69);
            this.salestextBox.Name = "salestextBox";
            this.salestextBox.Size = new System.Drawing.Size(100, 20);
            this.salestextBox.TabIndex = 5;
            // 
            // pricetextBox
            // 
            this.pricetextBox.Location = new System.Drawing.Point(100, 30);
            this.pricetextBox.Name = "pricetextBox";
            this.pricetextBox.Size = new System.Drawing.Size(103, 20);
            this.pricetextBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Sales Tax";
            // 
            // pricelabel
            // 
            this.pricelabel.AutoSize = true;
            this.pricelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelabel.Location = new System.Drawing.Point(20, 27);
            this.pricelabel.Name = "pricelabel";
            this.pricelabel.Size = new System.Drawing.Size(44, 20);
            this.pricelabel.TabIndex = 0;
            this.pricelabel.Text = "Price";
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbutton.Location = new System.Drawing.Point(593, 383);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(79, 37);
            this.Cancelbutton.TabIndex = 13;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // finishbutton
            // 
            this.finishbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishbutton.Location = new System.Drawing.Point(709, 383);
            this.finishbutton.Name = "finishbutton";
            this.finishbutton.Size = new System.Drawing.Size(79, 37);
            this.finishbutton.TabIndex = 14;
            this.finishbutton.Text = "Finish";
            this.finishbutton.UseVisualStyleBackColor = true;
            // 
            // Backbutton
            // 
            this.Backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbutton.Location = new System.Drawing.Point(493, 383);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(79, 37);
            this.Backbutton.TabIndex = 15;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Assignment_5.Properties.Resources.desktop_computer_system_250x250;
            this.pictureBox1.Location = new System.Drawing.Point(493, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 126);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.backToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.backToolStripMenuItem.Text = "&Back";
            // 
            // productprintForm
            // 
            this.productprintForm.DocumentName = "document";
            this.productprintForm.Form = this;
            this.productprintForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.productprintForm.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("productprintForm.PrinterSettings")));
            this.productprintForm.PrintFileName = null;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(313, 112);
            this.shapeContainer1.TabIndex = 8;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 0;
            this.lineShape1.X2 = 255;
            this.lineShape1.Y1 = 78;
            this.lineShape1.Y2 = 78;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.finishbutton);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.yourpricegroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.systemComponentsgroupBox);
            this.Controls.Add(this.ordermenuStrip);
            this.MainMenuStrip = this.ordermenuStrip;
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.ordermenuStrip.ResumeLayout(false);
            this.ordermenuStrip.PerformLayout();
            this.systemComponentsgroupBox.ResumeLayout(false);
            this.systemComponentsgroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.yourpricegroupBox.ResumeLayout(false);
            this.yourpricegroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ordermenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox systemComponentsgroupBox;
        private System.Windows.Forms.TextBox modeltextBox;
        private System.Windows.Forms.TextBox platformtextBox;
        private System.Windows.Forms.TextBox manufacturertextBox;
        private System.Windows.Forms.TextBox conditiontextBox;
        private System.Windows.Forms.Label modellabel;
        private System.Windows.Forms.Label manufacturerlabel;
        private System.Windows.Forms.Label platformlabel;
        private System.Windows.Forms.Label conditionlabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox yourpricegroupBox;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.Label Totallabel;
        private System.Windows.Forms.TextBox salestextBox;
        private System.Windows.Forms.TextBox pricetextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label pricelabel;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button finishbutton;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm productprintForm;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}