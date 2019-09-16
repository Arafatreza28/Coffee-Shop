namespace Coffee_Shop
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
            this.customerinformationLabel = new System.Windows.Forms.Label();
            this.customernameLabel = new System.Windows.Forms.Label();
            this.contactnoLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.orderLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.customernameTextBox = new System.Windows.Forms.TextBox();
            this.contactnoTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.orderComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.customer_informationPanel = new System.Windows.Forms.Panel();
            this.purchase_informationRichTextBox = new System.Windows.Forms.RichTextBox();
            this.customer_informationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerinformationLabel
            // 
            this.customerinformationLabel.AutoSize = true;
            this.customerinformationLabel.Location = new System.Drawing.Point(14, 32);
            this.customerinformationLabel.Name = "customerinformationLabel";
            this.customerinformationLabel.Size = new System.Drawing.Size(142, 17);
            this.customerinformationLabel.TabIndex = 0;
            this.customerinformationLabel.Text = "Customer Information";
            // 
            // customernameLabel
            // 
            this.customernameLabel.AutoSize = true;
            this.customernameLabel.Location = new System.Drawing.Point(33, 87);
            this.customernameLabel.Name = "customernameLabel";
            this.customernameLabel.Size = new System.Drawing.Size(109, 17);
            this.customernameLabel.TabIndex = 1;
            this.customernameLabel.Text = "Customer Name";
            // 
            // contactnoLabel
            // 
            this.contactnoLabel.AutoSize = true;
            this.contactnoLabel.Location = new System.Drawing.Point(33, 122);
            this.contactnoLabel.Name = "contactnoLabel";
            this.contactnoLabel.Size = new System.Drawing.Size(78, 17);
            this.contactnoLabel.TabIndex = 2;
            this.contactnoLabel.Text = "Contact No";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(33, 156);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(60, 17);
            this.addressLabel.TabIndex = 3;
            this.addressLabel.Text = "Address";
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Location = new System.Drawing.Point(33, 236);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(45, 17);
            this.orderLabel.TabIndex = 4;
            this.orderLabel.Text = "Order";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(33, 278);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(61, 17);
            this.quantityLabel.TabIndex = 5;
            this.quantityLabel.Text = "Quantity";
            // 
            // customernameTextBox
            // 
            this.customernameTextBox.Location = new System.Drawing.Point(210, 82);
            this.customernameTextBox.Name = "customernameTextBox";
            this.customernameTextBox.Size = new System.Drawing.Size(100, 22);
            this.customernameTextBox.TabIndex = 6;
            // 
            // contactnoTextBox
            // 
            this.contactnoTextBox.Location = new System.Drawing.Point(210, 117);
            this.contactnoTextBox.Name = "contactnoTextBox";
            this.contactnoTextBox.Size = new System.Drawing.Size(100, 22);
            this.contactnoTextBox.TabIndex = 7;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(210, 151);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 22);
            this.addressTextBox.TabIndex = 8;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(210, 273);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 22);
            this.quantityTextBox.TabIndex = 9;
            // 
            // orderComboBox
            // 
            this.orderComboBox.FormattingEnabled = true;
            this.orderComboBox.Items.AddRange(new object[] {
            "Black",
            "Cold",
            "Hot",
            "Regular"});
            this.orderComboBox.Location = new System.Drawing.Point(210, 229);
            this.orderComboBox.Name = "orderComboBox";
            this.orderComboBox.Size = new System.Drawing.Size(121, 24);
            this.orderComboBox.TabIndex = 10;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(210, 310);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // customer_informationPanel
            // 
            this.customer_informationPanel.Controls.Add(this.customerinformationLabel);
            this.customer_informationPanel.Controls.Add(this.saveButton);
            this.customer_informationPanel.Controls.Add(this.customernameLabel);
            this.customer_informationPanel.Controls.Add(this.quantityTextBox);
            this.customer_informationPanel.Controls.Add(this.orderComboBox);
            this.customer_informationPanel.Controls.Add(this.quantityLabel);
            this.customer_informationPanel.Controls.Add(this.contactnoLabel);
            this.customer_informationPanel.Controls.Add(this.addressLabel);
            this.customer_informationPanel.Controls.Add(this.addressTextBox);
            this.customer_informationPanel.Controls.Add(this.orderLabel);
            this.customer_informationPanel.Controls.Add(this.customernameTextBox);
            this.customer_informationPanel.Controls.Add(this.contactnoTextBox);
            this.customer_informationPanel.Location = new System.Drawing.Point(43, 29);
            this.customer_informationPanel.Name = "customer_informationPanel";
            this.customer_informationPanel.Size = new System.Drawing.Size(422, 369);
            this.customer_informationPanel.TabIndex = 12;
            // 
            // purchase_informationRichTextBox
            // 
            this.purchase_informationRichTextBox.Location = new System.Drawing.Point(541, 29);
            this.purchase_informationRichTextBox.Name = "purchase_informationRichTextBox";
            this.purchase_informationRichTextBox.Size = new System.Drawing.Size(232, 369);
            this.purchase_informationRichTextBox.TabIndex = 13;
            this.purchase_informationRichTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.purchase_informationRichTextBox);
            this.Controls.Add(this.customer_informationPanel);
            this.Name = "Form1";
            this.Text = "Coffee Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.customer_informationPanel.ResumeLayout(false);
            this.customer_informationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label customerinformationLabel;
        private System.Windows.Forms.Label customernameLabel;
        private System.Windows.Forms.Label contactnoLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox customernameTextBox;
        private System.Windows.Forms.TextBox contactnoTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.ComboBox orderComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel customer_informationPanel;
        private System.Windows.Forms.RichTextBox purchase_informationRichTextBox;
    }
}

