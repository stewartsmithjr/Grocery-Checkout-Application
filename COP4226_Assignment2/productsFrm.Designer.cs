namespace COP4226_Assignment2
{
    partial class productsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productsFrm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.productsListBox = new System.Windows.Forms.ListBox();
            this.addToListBttn = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.productsListBox);
            this.groupBox1.Location = new System.Drawing.Point(101, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select an item";
            // 
            // productsListBox
            // 
            this.productsListBox.FormattingEnabled = true;
            this.productsListBox.Items.AddRange(new object[] {
            "Bread (PRODUCT)",
            "Milk (PRODUCT)",
            "Sugar (PRODUCT)",
            "Coffee (PRODUCT)"});
            this.productsListBox.Location = new System.Drawing.Point(27, 19);
            this.productsListBox.Name = "productsListBox";
            this.productsListBox.Size = new System.Drawing.Size(338, 225);
            this.productsListBox.TabIndex = 0;
            // 
            // addToListBttn
            // 
            this.addToListBttn.Location = new System.Drawing.Point(191, 356);
            this.addToListBttn.Name = "addToListBttn";
            this.addToListBttn.Size = new System.Drawing.Size(100, 46);
            this.addToListBttn.TabIndex = 1;
            this.addToListBttn.Text = "Add to List";
            this.addToListBttn.UseVisualStyleBackColor = true;
            this.addToListBttn.Click += new System.EventHandler(this.addToListBttn_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(353, 356);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(88, 46);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // productsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addToListBttn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "productsFrm";
            this.Text = "Buy Products";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox productsListBox;
        private System.Windows.Forms.Button addToListBttn;
        private System.Windows.Forms.Button closeButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}