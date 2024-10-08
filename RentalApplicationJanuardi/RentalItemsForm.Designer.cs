namespace RentalApplicationJanuardi
{
    partial class RentalItemsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxItem = new System.Windows.Forms.ListBox();
            this.dataGridViewDetailItems = new System.Windows.Forms.DataGridView();
            this.listBoxRentalItem = new System.Windows.Forms.ListBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMemberId = new System.Windows.Forms.TextBox();
            this.textBoxMemberName = new System.Windows.Forms.TextBox();
            this.btnAddRental = new System.Windows.Forms.Button();
            this.btnRemoveRental = new System.Windows.Forms.Button();
            this.btnSaveRental = new System.Windows.Forms.Button();
            this.btnCancelRental = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetailItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "RENTAL NEW ITEMS";
            // 
            // listBoxItem
            // 
            this.listBoxItem.FormattingEnabled = true;
            this.listBoxItem.Location = new System.Drawing.Point(9, 59);
            this.listBoxItem.Name = "listBoxItem";
            this.listBoxItem.Size = new System.Drawing.Size(199, 82);
            this.listBoxItem.TabIndex = 3;
            this.listBoxItem.SelectedIndexChanged += new System.EventHandler(this.listBoxItem_SelectedIndexChanged);
            // 
            // dataGridViewDetailItems
            // 
            this.dataGridViewDetailItems.AllowUserToOrderColumns = true;
            this.dataGridViewDetailItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetailItems.Location = new System.Drawing.Point(9, 201);
            this.dataGridViewDetailItems.Name = "dataGridViewDetailItems";
            this.dataGridViewDetailItems.Size = new System.Drawing.Size(199, 92);
            this.dataGridViewDetailItems.TabIndex = 4;
            // 
            // listBoxRentalItem
            // 
            this.listBoxRentalItem.FormattingEnabled = true;
            this.listBoxRentalItem.Location = new System.Drawing.Point(214, 201);
            this.listBoxRentalItem.Name = "listBoxRentalItem";
            this.listBoxRentalItem.Size = new System.Drawing.Size(203, 95);
            this.listBoxRentalItem.TabIndex = 3;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(214, 59);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(203, 82);
            this.textBoxDescription.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Item List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Item Detail List";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Rental Item List";
            // 
            // textBoxMemberId
            // 
            this.textBoxMemberId.Location = new System.Drawing.Point(9, 313);
            this.textBoxMemberId.Name = "textBoxMemberId";
            this.textBoxMemberId.ReadOnly = true;
            this.textBoxMemberId.Size = new System.Drawing.Size(199, 20);
            this.textBoxMemberId.TabIndex = 7;
            // 
            // textBoxMemberName
            // 
            this.textBoxMemberName.Location = new System.Drawing.Point(215, 313);
            this.textBoxMemberName.Name = "textBoxMemberName";
            this.textBoxMemberName.ReadOnly = true;
            this.textBoxMemberName.Size = new System.Drawing.Size(202, 20);
            this.textBoxMemberName.TabIndex = 8;
            // 
            // btnAddRental
            // 
            this.btnAddRental.Location = new System.Drawing.Point(9, 340);
            this.btnAddRental.Name = "btnAddRental";
            this.btnAddRental.Size = new System.Drawing.Size(103, 23);
            this.btnAddRental.TabIndex = 9;
            this.btnAddRental.Text = "Add To Rental List";
            this.btnAddRental.UseVisualStyleBackColor = true;
            this.btnAddRental.Click += new System.EventHandler(this.btnAddRental_Click);
            // 
            // btnRemoveRental
            // 
            this.btnRemoveRental.Location = new System.Drawing.Point(118, 340);
            this.btnRemoveRental.Name = "btnRemoveRental";
            this.btnRemoveRental.Size = new System.Drawing.Size(136, 23);
            this.btnRemoveRental.TabIndex = 10;
            this.btnRemoveRental.Text = "Remove From Rental List";
            this.btnRemoveRental.UseVisualStyleBackColor = true;
            this.btnRemoveRental.Click += new System.EventHandler(this.btnRemoveRental_Click);
            // 
            // btnSaveRental
            // 
            this.btnSaveRental.Location = new System.Drawing.Point(261, 340);
            this.btnSaveRental.Name = "btnSaveRental";
            this.btnSaveRental.Size = new System.Drawing.Size(75, 23);
            this.btnSaveRental.TabIndex = 11;
            this.btnSaveRental.Text = "Save";
            this.btnSaveRental.UseVisualStyleBackColor = true;
            this.btnSaveRental.Click += new System.EventHandler(this.btnSaveRental_Click);
            // 
            // btnCancelRental
            // 
            this.btnCancelRental.Location = new System.Drawing.Point(342, 340);
            this.btnCancelRental.Name = "btnCancelRental";
            this.btnCancelRental.Size = new System.Drawing.Size(75, 23);
            this.btnCancelRental.TabIndex = 12;
            this.btnCancelRental.Text = "Cancel";
            this.btnCancelRental.UseVisualStyleBackColor = true;
            this.btnCancelRental.Click += new System.EventHandler(this.btnCancelRental_Click);
            // 
            // RentalItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 375);
            this.Controls.Add(this.btnCancelRental);
            this.Controls.Add(this.btnSaveRental);
            this.Controls.Add(this.btnRemoveRental);
            this.Controls.Add(this.btnAddRental);
            this.Controls.Add(this.textBoxMemberName);
            this.Controls.Add(this.textBoxMemberId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.dataGridViewDetailItems);
            this.Controls.Add(this.listBoxRentalItem);
            this.Controls.Add(this.listBoxItem);
            this.Controls.Add(this.label1);
            this.Name = "RentalItemsForm";
            this.Text = "RentalItemsForm";
            this.Load += new System.EventHandler(this.RentalItemsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetailItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox listBoxItem;
        public System.Windows.Forms.DataGridView dataGridViewDetailItems;
        public System.Windows.Forms.ListBox listBoxRentalItem;
        public System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxMemberId;
        public System.Windows.Forms.TextBox textBoxMemberName;
        private System.Windows.Forms.Button btnAddRental;
        private System.Windows.Forms.Button btnRemoveRental;
        private System.Windows.Forms.Button btnSaveRental;
        private System.Windows.Forms.Button btnCancelRental;

    }
}