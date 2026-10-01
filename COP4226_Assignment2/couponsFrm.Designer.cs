namespace COP4226_Assignment2
{
    partial class couponsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(couponsFrm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.couponsListBox = new System.Windows.Forms.ListBox();
            this.addtListBttn = new System.Windows.Forms.Button();
            this.closeBttn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.couponsListBox);
            this.groupBox1.Location = new System.Drawing.Point(103, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 291);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select an item";
            // 
            // couponsListBox
            // 
            this.couponsListBox.FormattingEnabled = true;
            this.couponsListBox.Items.AddRange(new object[] {
            "Milk (COUPON)",
            "Sugar (COUPON)",
            "Coffee (COUPON)"});
            this.couponsListBox.Location = new System.Drawing.Point(25, 19);
            this.couponsListBox.Name = "couponsListBox";
            this.couponsListBox.Size = new System.Drawing.Size(357, 251);
            this.couponsListBox.TabIndex = 0;
            this.couponsListBox.SelectedIndexChanged += new System.EventHandler(this.couponsListBox_SelectedIndexChanged);
            // 
            // addtListBttn
            // 
            this.addtListBttn.Location = new System.Drawing.Point(201, 361);
            this.addtListBttn.Name = "addtListBttn";
            this.addtListBttn.Size = new System.Drawing.Size(121, 55);
            this.addtListBttn.TabIndex = 1;
            this.addtListBttn.Text = "Add to List";
            this.addtListBttn.UseVisualStyleBackColor = true;
            this.addtListBttn.Click += new System.EventHandler(this.addtListBttn_Click);
            // 
            // closeBttn
            // 
            this.closeBttn.Location = new System.Drawing.Point(328, 361);
            this.closeBttn.Name = "closeBttn";
            this.closeBttn.Size = new System.Drawing.Size(121, 55);
            this.closeBttn.TabIndex = 2;
            this.closeBttn.Text = "Close";
            this.closeBttn.UseVisualStyleBackColor = true;
            this.closeBttn.Click += new System.EventHandler(this.closeBttn_Click);
            // 
            // couponsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeBttn);
            this.Controls.Add(this.addtListBttn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "couponsFrm";
            this.Text = "Add Coupons";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox couponsListBox;
        private System.Windows.Forms.Button addtListBttn;
        private System.Windows.Forms.Button closeBttn;
    }
}