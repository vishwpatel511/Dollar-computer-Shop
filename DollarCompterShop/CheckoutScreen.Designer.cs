namespace DollarCompterShop
{
    partial class CheckoutScreen
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.confirmOrderLayout = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OSTextField = new System.Windows.Forms.TextBox();
            this.ManufacturerTextField = new System.Windows.Forms.TextBox();
            this.modelTextField = new System.Windows.Forms.TextBox();
            this.platformTextField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.conditionTextField = new System.Windows.Forms.TextBox();
            this.productIdTextField = new System.Windows.Forms.TextBox();
            this.ProductIdLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.WebCamTextField = new System.Windows.Forms.TextBox();
            this.CPUSpeedTextField = new System.Windows.Forms.TextBox();
            this.CPUBrandtextField = new System.Windows.Forms.TextBox();
            this.CPUTypeTextField = new System.Windows.Forms.TextBox();
            this.hddTextField = new System.Windows.Forms.TextBox();
            this.GPUTypeTextField = new System.Windows.Forms.TextBox();
            this.lcdsizeTextField = new System.Windows.Forms.TextBox();
            this.CPUNumberTextField = new System.Windows.Forms.TextBox();
            this.memoryTextField = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductPriceLabel = new System.Windows.Forms.Label();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.GrandtotalLabel = new System.Windows.Forms.Label();
            this.ProductTotalTextField = new System.Windows.Forms.TextBox();
            this.TaxTextField = new System.Windows.Forms.TextBox();
            this.GrandTotalTextField = new System.Windows.Forms.TextBox();
            this.confirmOrderLayout.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.totalGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CancelButton.Location = new System.Drawing.Point(670, 612);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(112, 37);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.Location = new System.Drawing.Point(483, 612);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Confirm order";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // confirmOrderLayout
            // 
            this.confirmOrderLayout.Controls.Add(this.totalGroupBox);
            this.confirmOrderLayout.Controls.Add(this.groupBox3);
            this.confirmOrderLayout.Controls.Add(this.conditionTextField);
            this.confirmOrderLayout.Controls.Add(this.productIdTextField);
            this.confirmOrderLayout.Controls.Add(this.ProductIdLabel);
            this.confirmOrderLayout.Controls.Add(this.ConditionLabel);
            this.confirmOrderLayout.Controls.Add(this.groupBox2);
            this.confirmOrderLayout.Location = new System.Drawing.Point(12, 12);
            this.confirmOrderLayout.Name = "confirmOrderLayout";
            this.confirmOrderLayout.Size = new System.Drawing.Size(809, 576);
            this.confirmOrderLayout.TabIndex = 4;
            this.confirmOrderLayout.TabStop = false;
            this.confirmOrderLayout.Text = "Confirm order";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OSTextField);
            this.groupBox2.Controls.Add(this.ManufacturerTextField);
            this.groupBox2.Controls.Add(this.modelTextField);
            this.groupBox2.Controls.Add(this.platformTextField);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(21, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 261);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product info";
            // 
            // OSTextField
            // 
            this.OSTextField.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.OSTextField.Enabled = false;
            this.OSTextField.Location = new System.Drawing.Point(137, 133);
            this.OSTextField.Name = "OSTextField";
            this.OSTextField.ReadOnly = true;
            this.OSTextField.Size = new System.Drawing.Size(270, 26);
            this.OSTextField.TabIndex = 8;
            // 
            // ManufacturerTextField
            // 
            this.ManufacturerTextField.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ManufacturerTextField.Enabled = false;
            this.ManufacturerTextField.Location = new System.Drawing.Point(137, 90);
            this.ManufacturerTextField.Name = "ManufacturerTextField";
            this.ManufacturerTextField.ReadOnly = true;
            this.ManufacturerTextField.Size = new System.Drawing.Size(131, 26);
            this.ManufacturerTextField.TabIndex = 7;
            // 
            // modelTextField
            // 
            this.modelTextField.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.modelTextField.Enabled = false;
            this.modelTextField.Location = new System.Drawing.Point(137, 186);
            this.modelTextField.Name = "modelTextField";
            this.modelTextField.ReadOnly = true;
            this.modelTextField.Size = new System.Drawing.Size(270, 26);
            this.modelTextField.TabIndex = 6;
            // 
            // platformTextField
            // 
            this.platformTextField.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.platformTextField.Enabled = false;
            this.platformTextField.Location = new System.Drawing.Point(137, 39);
            this.platformTextField.Name = "platformTextField";
            this.platformTextField.ReadOnly = true;
            this.platformTextField.Size = new System.Drawing.Size(131, 26);
            this.platformTextField.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Platform: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Manufacturer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "OS: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Model: ";
            // 
            // conditionTextField
            // 
            this.conditionTextField.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.conditionTextField.Enabled = false;
            this.conditionTextField.Location = new System.Drawing.Point(322, 50);
            this.conditionTextField.Name = "conditionTextField";
            this.conditionTextField.ReadOnly = true;
            this.conditionTextField.Size = new System.Drawing.Size(101, 26);
            this.conditionTextField.TabIndex = 13;
            // 
            // productIdTextField
            // 
            this.productIdTextField.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.productIdTextField.Enabled = false;
            this.productIdTextField.Location = new System.Drawing.Point(109, 50);
            this.productIdTextField.Name = "productIdTextField";
            this.productIdTextField.ReadOnly = true;
            this.productIdTextField.Size = new System.Drawing.Size(101, 26);
            this.productIdTextField.TabIndex = 12;
            // 
            // ProductIdLabel
            // 
            this.ProductIdLabel.AutoSize = true;
            this.ProductIdLabel.Location = new System.Drawing.Point(17, 50);
            this.ProductIdLabel.Name = "ProductIdLabel";
            this.ProductIdLabel.Size = new System.Drawing.Size(86, 20);
            this.ProductIdLabel.TabIndex = 9;
            this.ProductIdLabel.Text = "Product Id:";
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(232, 50);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(84, 20);
            this.ConditionLabel.TabIndex = 11;
            this.ConditionLabel.Text = "Condition: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.WebCamTextField);
            this.groupBox3.Controls.Add(this.CPUSpeedTextField);
            this.groupBox3.Controls.Add(this.CPUBrandtextField);
            this.groupBox3.Controls.Add(this.CPUTypeTextField);
            this.groupBox3.Controls.Add(this.hddTextField);
            this.groupBox3.Controls.Add(this.GPUTypeTextField);
            this.groupBox3.Controls.Add(this.lcdsizeTextField);
            this.groupBox3.Controls.Add(this.CPUNumberTextField);
            this.groupBox3.Controls.Add(this.memoryTextField);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(21, 382);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(769, 171);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tech specification:";
            // 
            // WebCamTextField
            // 
            this.WebCamTextField.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.WebCamTextField.Enabled = false;
            this.WebCamTextField.Location = new System.Drawing.Point(532, 122);
            this.WebCamTextField.Name = "WebCamTextField";
            this.WebCamTextField.ReadOnly = true;
            this.WebCamTextField.Size = new System.Drawing.Size(211, 26);
            this.WebCamTextField.TabIndex = 21;
            // 
            // CPUSpeedTextField
            // 
            this.CPUSpeedTextField.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CPUSpeedTextField.Enabled = false;
            this.CPUSpeedTextField.Location = new System.Drawing.Point(334, 119);
            this.CPUSpeedTextField.Name = "CPUSpeedTextField";
            this.CPUSpeedTextField.ReadOnly = true;
            this.CPUSpeedTextField.Size = new System.Drawing.Size(101, 26);
            this.CPUSpeedTextField.TabIndex = 20;
            // 
            // CPUBrandtextField
            // 
            this.CPUBrandtextField.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CPUBrandtextField.Enabled = false;
            this.CPUBrandtextField.Location = new System.Drawing.Point(119, 83);
            this.CPUBrandtextField.Name = "CPUBrandtextField";
            this.CPUBrandtextField.ReadOnly = true;
            this.CPUBrandtextField.Size = new System.Drawing.Size(101, 26);
            this.CPUBrandtextField.TabIndex = 19;
            // 
            // CPUTypeTextField
            // 
            this.CPUTypeTextField.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CPUTypeTextField.Enabled = false;
            this.CPUTypeTextField.Location = new System.Drawing.Point(119, 125);
            this.CPUTypeTextField.Name = "CPUTypeTextField";
            this.CPUTypeTextField.ReadOnly = true;
            this.CPUTypeTextField.Size = new System.Drawing.Size(101, 26);
            this.CPUTypeTextField.TabIndex = 18;
            // 
            // hddTextField
            // 
            this.hddTextField.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.hddTextField.Enabled = false;
            this.hddTextField.Location = new System.Drawing.Point(532, 41);
            this.hddTextField.Name = "hddTextField";
            this.hddTextField.ReadOnly = true;
            this.hddTextField.Size = new System.Drawing.Size(211, 26);
            this.hddTextField.TabIndex = 17;
            // 
            // GPUTypeTextField
            // 
            this.GPUTypeTextField.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GPUTypeTextField.Enabled = false;
            this.GPUTypeTextField.Location = new System.Drawing.Point(532, 83);
            this.GPUTypeTextField.Name = "GPUTypeTextField";
            this.GPUTypeTextField.ReadOnly = true;
            this.GPUTypeTextField.Size = new System.Drawing.Size(211, 26);
            this.GPUTypeTextField.TabIndex = 16;
            // 
            // lcdsizeTextField
            // 
            this.lcdsizeTextField.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lcdsizeTextField.Enabled = false;
            this.lcdsizeTextField.Location = new System.Drawing.Point(334, 38);
            this.lcdsizeTextField.Name = "lcdsizeTextField";
            this.lcdsizeTextField.ReadOnly = true;
            this.lcdsizeTextField.Size = new System.Drawing.Size(101, 26);
            this.lcdsizeTextField.TabIndex = 15;
            // 
            // CPUNumberTextField
            // 
            this.CPUNumberTextField.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CPUNumberTextField.Enabled = false;
            this.CPUNumberTextField.Location = new System.Drawing.Point(334, 77);
            this.CPUNumberTextField.Name = "CPUNumberTextField";
            this.CPUNumberTextField.ReadOnly = true;
            this.CPUNumberTextField.Size = new System.Drawing.Size(101, 26);
            this.CPUNumberTextField.TabIndex = 14;
            // 
            // memoryTextField
            // 
            this.memoryTextField.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.memoryTextField.Enabled = false;
            this.memoryTextField.Location = new System.Drawing.Point(119, 38);
            this.memoryTextField.Name = "memoryTextField";
            this.memoryTextField.ReadOnly = true;
            this.memoryTextField.Size = new System.Drawing.Size(97, 26);
            this.memoryTextField.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "Memory: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "CPU Brand: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "CPU Type:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(235, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "LCD size:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(230, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "CPU Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "CPU Speed: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(459, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "HDD: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "GPU Type: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Web Cam:";
            // 
            // totalGroupBox
            // 
            this.totalGroupBox.Controls.Add(this.GrandTotalTextField);
            this.totalGroupBox.Controls.Add(this.TaxTextField);
            this.totalGroupBox.Controls.Add(this.ProductTotalTextField);
            this.totalGroupBox.Controls.Add(this.GrandtotalLabel);
            this.totalGroupBox.Controls.Add(this.SalesTaxLabel);
            this.totalGroupBox.Controls.Add(this.ProductPriceLabel);
            this.totalGroupBox.Location = new System.Drawing.Point(471, 103);
            this.totalGroupBox.Name = "totalGroupBox";
            this.totalGroupBox.Size = new System.Drawing.Size(319, 261);
            this.totalGroupBox.TabIndex = 5;
            this.totalGroupBox.TabStop = false;
            this.totalGroupBox.Text = "Order total";
            // 
            // ProductPriceLabel
            // 
            this.ProductPriceLabel.AutoSize = true;
            this.ProductPriceLabel.Location = new System.Drawing.Point(10, 96);
            this.ProductPriceLabel.Name = "ProductPriceLabel";
            this.ProductPriceLabel.Size = new System.Drawing.Size(52, 20);
            this.ProductPriceLabel.TabIndex = 0;
            this.ProductPriceLabel.Text = "Total: ";
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(10, 133);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(86, 20);
            this.SalesTaxLabel.TabIndex = 1;
            this.SalesTaxLabel.Text = "Sales Tax: ";
            // 
            // GrandtotalLabel
            // 
            this.GrandtotalLabel.AutoSize = true;
            this.GrandtotalLabel.Location = new System.Drawing.Point(10, 171);
            this.GrandtotalLabel.Name = "GrandtotalLabel";
            this.GrandtotalLabel.Size = new System.Drawing.Size(101, 20);
            this.GrandtotalLabel.TabIndex = 2;
            this.GrandtotalLabel.Text = "Grand Total: ";
            // 
            // ProductTotalTextField
            // 
            this.ProductTotalTextField.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ProductTotalTextField.Location = new System.Drawing.Point(156, 95);
            this.ProductTotalTextField.Name = "ProductTotalTextField";
            this.ProductTotalTextField.ReadOnly = true;
            this.ProductTotalTextField.Size = new System.Drawing.Size(100, 26);
            this.ProductTotalTextField.TabIndex = 3;
            // 
            // TaxTextField
            // 
            this.TaxTextField.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TaxTextField.Location = new System.Drawing.Point(156, 133);
            this.TaxTextField.Name = "TaxTextField";
            this.TaxTextField.ReadOnly = true;
            this.TaxTextField.Size = new System.Drawing.Size(100, 26);
            this.TaxTextField.TabIndex = 4;
            // 
            // GrandTotalTextField
            // 
            this.GrandTotalTextField.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GrandTotalTextField.Location = new System.Drawing.Point(156, 171);
            this.GrandTotalTextField.Name = "GrandTotalTextField";
            this.GrandTotalTextField.ReadOnly = true;
            this.GrandTotalTextField.Size = new System.Drawing.Size(100, 26);
            this.GrandTotalTextField.TabIndex = 5;
            // 
            // CheckoutScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 661);
            this.Controls.Add(this.confirmOrderLayout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CancelButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "CheckoutScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckoutScreen";
            this.Activated += new System.EventHandler(this.CheckoutScreen_Activated);
            this.confirmOrderLayout.ResumeLayout(false);
            this.confirmOrderLayout.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.totalGroupBox.ResumeLayout(false);
            this.totalGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox confirmOrderLayout;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox OSTextField;
        private System.Windows.Forms.TextBox ManufacturerTextField;
        private System.Windows.Forms.TextBox modelTextField;
        private System.Windows.Forms.TextBox platformTextField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox conditionTextField;
        private System.Windows.Forms.TextBox productIdTextField;
        private System.Windows.Forms.Label ProductIdLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox WebCamTextField;
        private System.Windows.Forms.TextBox CPUSpeedTextField;
        private System.Windows.Forms.TextBox CPUBrandtextField;
        private System.Windows.Forms.TextBox CPUTypeTextField;
        private System.Windows.Forms.TextBox hddTextField;
        private System.Windows.Forms.TextBox GPUTypeTextField;
        private System.Windows.Forms.TextBox lcdsizeTextField;
        private System.Windows.Forms.TextBox CPUNumberTextField;
        private System.Windows.Forms.TextBox memoryTextField;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox totalGroupBox;
        private System.Windows.Forms.TextBox GrandTotalTextField;
        private System.Windows.Forms.TextBox TaxTextField;
        private System.Windows.Forms.TextBox ProductTotalTextField;
        private System.Windows.Forms.Label GrandtotalLabel;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Label ProductPriceLabel;
    }
}