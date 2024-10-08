namespace RentalApplicationJanuardi
{
    partial class MemberForm
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
            this.labelMemberForm = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIdMember = new System.Windows.Forms.TextBox();
            this.textBoxMemberName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnSaveMember = new System.Windows.Forms.Button();
            this.btnCancelMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMemberForm
            // 
            this.labelMemberForm.Location = new System.Drawing.Point(154, 9);
            this.labelMemberForm.Name = "labelMemberForm";
            this.labelMemberForm.Size = new System.Drawing.Size(100, 23);
            this.labelMemberForm.TabIndex = 0;
            this.labelMemberForm.Text = "ADD MEMBER";
            this.labelMemberForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Member ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Full Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone Number";
            // 
            // textBoxIdMember
            // 
            this.textBoxIdMember.Location = new System.Drawing.Point(166, 41);
            this.textBoxIdMember.Name = "textBoxIdMember";
            this.textBoxIdMember.ReadOnly = true;
            this.textBoxIdMember.Size = new System.Drawing.Size(216, 20);
            this.textBoxIdMember.TabIndex = 5;
            // 
            // textBoxMemberName
            // 
            this.textBoxMemberName.Location = new System.Drawing.Point(166, 75);
            this.textBoxMemberName.Name = "textBoxMemberName";
            this.textBoxMemberName.Size = new System.Drawing.Size(216, 20);
            this.textBoxMemberName.TabIndex = 6;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(166, 112);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(216, 20);
            this.textBoxAddress.TabIndex = 7;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(166, 151);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(216, 20);
            this.textBoxPhoneNumber.TabIndex = 8;
            // 
            // btnSaveMember
            // 
            this.btnSaveMember.Location = new System.Drawing.Point(226, 204);
            this.btnSaveMember.Name = "btnSaveMember";
            this.btnSaveMember.Size = new System.Drawing.Size(75, 23);
            this.btnSaveMember.TabIndex = 9;
            this.btnSaveMember.Text = "Save";
            this.btnSaveMember.UseVisualStyleBackColor = true;
            this.btnSaveMember.Click += new System.EventHandler(this.btnSaveMember_Click);
            // 
            // btnCancelMember
            // 
            this.btnCancelMember.Location = new System.Drawing.Point(307, 204);
            this.btnCancelMember.Name = "btnCancelMember";
            this.btnCancelMember.Size = new System.Drawing.Size(75, 23);
            this.btnCancelMember.TabIndex = 10;
            this.btnCancelMember.Text = "Cancel";
            this.btnCancelMember.UseVisualStyleBackColor = true;
            this.btnCancelMember.Click += new System.EventHandler(this.btnCancelMember_Click);
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 364);
            this.Controls.Add(this.btnCancelMember);
            this.Controls.Add(this.btnSaveMember);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxMemberName);
            this.Controls.Add(this.textBoxIdMember);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelMemberForm);
            this.Name = "MemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Member";
            this.Load += new System.EventHandler(this.MemberForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveMember;
        private System.Windows.Forms.Button btnCancelMember;
        public System.Windows.Forms.TextBox textBoxIdMember;
        public System.Windows.Forms.TextBox textBoxMemberName;
        public System.Windows.Forms.TextBox textBoxAddress;
        public System.Windows.Forms.TextBox textBoxPhoneNumber;
        public System.Windows.Forms.Label labelMemberForm;
    }
}