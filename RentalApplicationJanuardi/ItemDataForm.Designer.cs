namespace RentalApplicationJanuardi
{
    partial class ItemDataForm
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
            this.labelItemForm = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textbBoxDescription = new System.Windows.Forms.RichTextBox();
            this.textbBoxProductName = new System.Windows.Forms.RichTextBox();
            this.textbBoxIdProduct = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelItemForm
            // 
            this.labelItemForm.AutoSize = true;
            this.labelItemForm.Location = new System.Drawing.Point(190, 9);
            this.labelItemForm.Name = "labelItemForm";
            this.labelItemForm.Size = new System.Drawing.Size(59, 26);
            this.labelItemForm.TabIndex = 0;
            this.labelItemForm.Text = "\r\nADD ITEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            // 
            // textbBoxDescription
            // 
            this.textbBoxDescription.Location = new System.Drawing.Point(117, 151);
            this.textbBoxDescription.Name = "textbBoxDescription";
            this.textbBoxDescription.Size = new System.Drawing.Size(298, 69);
            this.textbBoxDescription.TabIndex = 6;
            this.textbBoxDescription.Text = "";
            // 
            // textbBoxProductName
            // 
            this.textbBoxProductName.Location = new System.Drawing.Point(117, 106);
            this.textbBoxProductName.Name = "textbBoxProductName";
            this.textbBoxProductName.Size = new System.Drawing.Size(298, 23);
            this.textbBoxProductName.TabIndex = 7;
            this.textbBoxProductName.Text = "";
            // 
            // textbBoxIdProduct
            // 
            this.textbBoxIdProduct.Location = new System.Drawing.Point(117, 62);
            this.textbBoxIdProduct.Name = "textbBoxIdProduct";
            this.textbBoxIdProduct.ReadOnly = true;
            this.textbBoxIdProduct.Size = new System.Drawing.Size(298, 21);
            this.textbBoxIdProduct.TabIndex = 8;
            this.textbBoxIdProduct.Text = "";
            this.textbBoxIdProduct.TextChanged += new System.EventHandler(this.textbBoxIdProduct_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(339, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ItemDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 399);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textbBoxIdProduct);
            this.Controls.Add(this.textbBoxProductName);
            this.Controls.Add(this.textbBoxDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelItemForm);
            this.Name = "ItemDataForm";
            this.Text = "ItemDataForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label labelItemForm;
        public System.Windows.Forms.RichTextBox textbBoxProductName;
        public System.Windows.Forms.RichTextBox textbBoxDescription;
        public System.Windows.Forms.RichTextBox textbBoxIdProduct;
    }
}