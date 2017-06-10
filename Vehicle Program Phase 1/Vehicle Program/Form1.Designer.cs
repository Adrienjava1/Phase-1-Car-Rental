namespace Vehicle_Program
{
    partial class Form1
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
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtRegistration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtPerDayRental = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFuelQtyPurchase = new System.Windows.Forms.TextBox();
            this.txtKilometres = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFuelCost = new System.Windows.Forms.TextBox();
            this.btnTravel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(154, 239);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtManufacturer.Size = new System.Drawing.Size(100, 20);
            this.txtManufacturer.TabIndex = 9;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(154, 265);
            this.txtModel.Name = "txtModel";
            this.txtModel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 10;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(154, 291);
            this.txtYear.Name = "txtYear";
            this.txtYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 11;
            // 
            // txtRegistration
            // 
            this.txtRegistration.Location = new System.Drawing.Point(154, 317);
            this.txtRegistration.Name = "txtRegistration";
            this.txtRegistration.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRegistration.Size = new System.Drawing.Size(100, 20);
            this.txtRegistration.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 239);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Manufacturer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 268);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 291);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 317);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Registration:";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(154, 385);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 36);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "Insert Vehicle";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(452, 29);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(244, 173);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(25, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(421, 173);
            this.listBox1.TabIndex = 23;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // txtPerDayRental
            // 
            this.txtPerDayRental.Location = new System.Drawing.Point(696, 559);
            this.txtPerDayRental.Name = "txtPerDayRental";
            this.txtPerDayRental.ReadOnly = true;
            this.txtPerDayRental.Size = new System.Drawing.Size(10, 20);
            this.txtPerDayRental.TabIndex = 31;
            this.txtPerDayRental.Text = "100";
            this.txtPerDayRental.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 236);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Total Kilometres Travelled:";
            // 
            // txtFuelQtyPurchase
            // 
            this.txtFuelQtyPurchase.Location = new System.Drawing.Point(559, 273);
            this.txtFuelQtyPurchase.Name = "txtFuelQtyPurchase";
            this.txtFuelQtyPurchase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFuelQtyPurchase.Size = new System.Drawing.Size(100, 20);
            this.txtFuelQtyPurchase.TabIndex = 25;
            // 
            // txtKilometres
            // 
            this.txtKilometres.Location = new System.Drawing.Point(559, 234);
            this.txtKilometres.Name = "txtKilometres";
            this.txtKilometres.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtKilometres.Size = new System.Drawing.Size(100, 20);
            this.txtKilometres.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(421, 302);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Fuel Cost Per L:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 276);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Fuel Quantity Purchased L:";
            // 
            // txtFuelCost
            // 
            this.txtFuelCost.Location = new System.Drawing.Point(559, 302);
            this.txtFuelCost.Name = "txtFuelCost";
            this.txtFuelCost.Size = new System.Drawing.Size(100, 20);
            this.txtFuelCost.TabIndex = 33;
            // 
            // btnTravel
            // 
            this.btnTravel.Location = new System.Drawing.Point(559, 339);
            this.btnTravel.Name = "btnTravel";
            this.btnTravel.Size = new System.Drawing.Size(110, 46);
            this.btnTravel.TabIndex = 21;
            this.btnTravel.Text = "Submit";
            this.btnTravel.UseVisualStyleBackColor = true;
            this.btnTravel.Click += new System.EventHandler(this.btnTravel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 591);
            this.Controls.Add(this.btnTravel);
            this.Controls.Add(this.txtFuelCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPerDayRental);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtKilometres);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtFuelQtyPurchase);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRegistration);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtManufacturer);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtRegistration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtPerDayRental;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFuelQtyPurchase;
        private System.Windows.Forms.TextBox txtKilometres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFuelCost;
        private System.Windows.Forms.Button btnTravel;
    }
}

