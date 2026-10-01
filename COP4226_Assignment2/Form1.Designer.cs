namespace COP4226_Assignment2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couponsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalTxtBox = new System.Windows.Forms.TextBox();
            this.shippingTxtBox = new System.Windows.Forms.TextBox();
            this.taxTxtBox = new System.Windows.Forms.TextBox();
            this.couponsTxtBox = new System.Windows.Forms.TextBox();
            this.productTxtBox = new System.Windows.Forms.TextBox();
            this.deliveryCheckBox = new System.Windows.Forms.CheckBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.shippingLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.couponsLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.removeBttn = new System.Windows.Forms.Button();
            this.shoppingListComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shoppingLstListBox = new System.Windows.Forms.ListBox();
            this.menuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.shopToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(639, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(140, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // shopToolStripMenuItem
            // 
            this.shopToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.couponsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.productsToolStripMenuItem});
            this.shopToolStripMenuItem.Name = "shopToolStripMenuItem";
            this.shopToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.shopToolStripMenuItem.Text = "Shop";
            // 
            // couponsToolStripMenuItem
            // 
            this.couponsToolStripMenuItem.Name = "couponsToolStripMenuItem";
            this.couponsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.couponsToolStripMenuItem.Text = "Coupons";
            this.couponsToolStripMenuItem.Click += new System.EventHandler(this.couponsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(119, 6);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalTxtBox);
            this.groupBox1.Controls.Add(this.shippingTxtBox);
            this.groupBox1.Controls.Add(this.taxTxtBox);
            this.groupBox1.Controls.Add(this.couponsTxtBox);
            this.groupBox1.Controls.Add(this.productTxtBox);
            this.groupBox1.Controls.Add(this.deliveryCheckBox);
            this.groupBox1.Controls.Add(this.totalLabel);
            this.groupBox1.Controls.Add(this.shippingLabel);
            this.groupBox1.Controls.Add(this.taxLabel);
            this.groupBox1.Controls.Add(this.couponsLabel);
            this.groupBox1.Controls.Add(this.productLabel);
            this.groupBox1.Controls.Add(this.removeBttn);
            this.groupBox1.Controls.Add(this.shoppingListComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.shoppingLstListBox);
            this.groupBox1.Location = new System.Drawing.Point(26, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 388);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shopping List";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // totalTxtBox
            // 
            this.totalTxtBox.Location = new System.Drawing.Point(412, 215);
            this.totalTxtBox.Name = "totalTxtBox";
            this.totalTxtBox.Size = new System.Drawing.Size(100, 20);
            this.totalTxtBox.TabIndex = 15;
            // 
            // shippingTxtBox
            // 
            this.shippingTxtBox.Location = new System.Drawing.Point(412, 169);
            this.shippingTxtBox.Name = "shippingTxtBox";
            this.shippingTxtBox.Size = new System.Drawing.Size(100, 20);
            this.shippingTxtBox.TabIndex = 14;
            // 
            // taxTxtBox
            // 
            this.taxTxtBox.Location = new System.Drawing.Point(412, 120);
            this.taxTxtBox.Name = "taxTxtBox";
            this.taxTxtBox.Size = new System.Drawing.Size(100, 20);
            this.taxTxtBox.TabIndex = 13;
            // 
            // couponsTxtBox
            // 
            this.couponsTxtBox.Location = new System.Drawing.Point(412, 70);
            this.couponsTxtBox.Name = "couponsTxtBox";
            this.couponsTxtBox.Size = new System.Drawing.Size(100, 20);
            this.couponsTxtBox.TabIndex = 12;
            // 
            // productTxtBox
            // 
            this.productTxtBox.Location = new System.Drawing.Point(412, 29);
            this.productTxtBox.Name = "productTxtBox";
            this.productTxtBox.Size = new System.Drawing.Size(100, 20);
            this.productTxtBox.TabIndex = 11;
            this.productTxtBox.TextChanged += new System.EventHandler(this.productTxtBox_TextChanged);
            // 
            // deliveryCheckBox
            // 
            this.deliveryCheckBox.AutoSize = true;
            this.deliveryCheckBox.Location = new System.Drawing.Point(412, 322);
            this.deliveryCheckBox.Name = "deliveryCheckBox";
            this.deliveryCheckBox.Size = new System.Drawing.Size(70, 17);
            this.deliveryCheckBox.TabIndex = 10;
            this.deliveryCheckBox.Text = "Delivery?";
            this.deliveryCheckBox.UseVisualStyleBackColor = true;
            this.deliveryCheckBox.CheckedChanged += new System.EventHandler(this.deliveryCheckBox_CheckedChanged);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(337, 218);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(34, 13);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "Total:";
            // 
            // shippingLabel
            // 
            this.shippingLabel.AutoSize = true;
            this.shippingLabel.Location = new System.Drawing.Point(335, 172);
            this.shippingLabel.Name = "shippingLabel";
            this.shippingLabel.Size = new System.Drawing.Size(54, 13);
            this.shippingLabel.TabIndex = 8;
            this.shippingLabel.Text = "Shipping: ";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(335, 123);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(28, 13);
            this.taxLabel.TabIndex = 7;
            this.taxLabel.Text = "Tax:";
            // 
            // couponsLabel
            // 
            this.couponsLabel.AutoSize = true;
            this.couponsLabel.Location = new System.Drawing.Point(337, 73);
            this.couponsLabel.Name = "couponsLabel";
            this.couponsLabel.Size = new System.Drawing.Size(52, 13);
            this.couponsLabel.TabIndex = 6;
            this.couponsLabel.Text = "Coupons:";
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(335, 32);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(52, 13);
            this.productLabel.TabIndex = 5;
            this.productLabel.Text = "Products:";
            // 
            // removeBttn
            // 
            this.removeBttn.BackColor = System.Drawing.Color.LightGray;
            this.removeBttn.Location = new System.Drawing.Point(217, 313);
            this.removeBttn.Name = "removeBttn";
            this.removeBttn.Size = new System.Drawing.Size(75, 39);
            this.removeBttn.TabIndex = 4;
            this.removeBttn.Text = "Remove";
            this.removeBttn.UseVisualStyleBackColor = false;
            this.removeBttn.Click += new System.EventHandler(this.removeBttn_Click);
            // 
            // shoppingListComboBox
            // 
            this.shoppingListComboBox.FormattingEnabled = true;
            this.shoppingListComboBox.Items.AddRange(new object[] {
            "(COUPON)",
            "(PRODUCT)"});
            this.shoppingListComboBox.Location = new System.Drawing.Point(76, 323);
            this.shoppingListComboBox.Name = "shoppingListComboBox";
            this.shoppingListComboBox.Size = new System.Drawing.Size(121, 21);
            this.shoppingListComboBox.TabIndex = 3;
            this.shoppingListComboBox.SelectedIndexChanged += new System.EventHandler(this.shoppingListComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contains?";
            // 
            // shoppingLstListBox
            // 
            this.shoppingLstListBox.FormattingEnabled = true;
            this.shoppingLstListBox.Location = new System.Drawing.Point(19, 19);
            this.shoppingLstListBox.Name = "shoppingLstListBox";
            this.shoppingLstListBox.Size = new System.Drawing.Size(312, 212);
            this.shoppingLstListBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 476);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Shop List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couponsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox totalTxtBox;
        private System.Windows.Forms.TextBox shippingTxtBox;
        private System.Windows.Forms.TextBox taxTxtBox;
        private System.Windows.Forms.TextBox couponsTxtBox;
        private System.Windows.Forms.TextBox productTxtBox;
        private System.Windows.Forms.CheckBox deliveryCheckBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label shippingLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label couponsLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Button removeBttn;
        private System.Windows.Forms.ComboBox shoppingListComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox shoppingLstListBox;
    }
}

