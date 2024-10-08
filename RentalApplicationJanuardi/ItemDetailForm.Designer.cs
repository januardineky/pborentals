namespace RentalApplicationJanuardi
{
    partial class ItemDetailForm
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
            this.labelDetailForm = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxProductId = new System.Windows.Forms.TextBox();
            this.textBoxIdDetail = new System.Windows.Forms.TextBox();
            this.textBoxDetailNote = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDetailForm
            // 
            this.labelDetailForm.AutoSize = true;
            this.labelDetailForm.Location = new System.Drawing.Point(176, 13);
            this.labelDetailForm.Name = "labelDetailForm";
            this.labelDetailForm.Size = new System.Drawing.Size(35, 13);
            this.labelDetailForm.TabIndex = 0;
            this.labelDetailForm.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item Detail ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Item Detail Note";
            // 
            // textBoxProductId
            // 
            this.textBoxProductId.Location = new System.Drawing.Point(148, 52);
            this.textBoxProductId.Name = "textBoxProductId";
            this.textBoxProductId.Size = new System.Drawing.Size(206, 20);
            this.textBoxProductId.TabIndex = 4;
            // 
            // textBoxIdDetail
            // 
            this.textBoxIdDetail.Location = new System.Drawing.Point(148, 86);
            this.textBoxIdDetail.Name = "textBoxIdDetail";
            this.textBoxIdDetail.Size = new System.Drawing.Size(206, 20);
            this.textBoxIdDetail.TabIndex = 5;
            // 
            // textBoxDetailNote
            // 
            this.textBoxDetailNote.Location = new System.Drawing.Point(148, 128);
            this.textBoxDetailNote.Name = "textBoxDetailNote";
            this.textBoxDetailNote.Size = new System.Drawing.Size(206, 20);
            this.textBoxDetailNote.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ItemDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 309);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxDetailNote);
            this.Controls.Add(this.textBoxIdDetail);
            this.Controls.Add(this.textBoxProductId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDetailForm);
            this.Name = "ItemDetailForm";
            this.Text = "ItemDetailForm";
            this.Load += new System.EventHandler(this.ItemDetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label labelDetailForm;
        public System.Windows.Forms.TextBox textBoxProductId;
        public System.Windows.Forms.TextBox textBoxIdDetail;
        public System.Windows.Forms.TextBox textBoxDetailNote;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
    }
}