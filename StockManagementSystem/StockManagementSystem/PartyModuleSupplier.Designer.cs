namespace StockManagementSystem
{
    partial class PartyModuleSupplier
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.textBoxContactPerson = new System.Windows.Forms.TextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.dataGridViewSupplier = new System.Windows.Forms.DataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contact";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Contact Person";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(524, 16);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(251, 26);
            this.textBoxCode.TabIndex = 6;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(524, 69);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(251, 26);
            this.textBoxName.TabIndex = 7;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(524, 123);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(251, 26);
            this.textBoxAddress.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(524, 181);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(251, 26);
            this.textBoxEmail.TabIndex = 9;
            // 
            // textBoxContact
            // 
            this.textBoxContact.Location = new System.Drawing.Point(524, 232);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(251, 26);
            this.textBoxContact.TabIndex = 10;
            // 
            // textBoxContactPerson
            // 
            this.textBoxContactPerson.Location = new System.Drawing.Point(524, 283);
            this.textBoxContactPerson.Name = "textBoxContactPerson";
            this.textBoxContactPerson.Size = new System.Drawing.Size(251, 26);
            this.textBoxContactPerson.TabIndex = 11;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(669, 335);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(106, 37);
            this.ButtonSave.TabIndex = 12;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // dataGridViewSupplier
            // 
            this.dataGridViewSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL});
            this.dataGridViewSupplier.Location = new System.Drawing.Point(149, 402);
            this.dataGridViewSupplier.Name = "dataGridViewSupplier";
            this.dataGridViewSupplier.RowTemplate.Height = 28;
            this.dataGridViewSupplier.Size = new System.Drawing.Size(921, 212);
            this.dataGridViewSupplier.TabIndex = 13;
            this.dataGridViewSupplier.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewSupplier_RowPostPaint);
            // 
            // SL
            // 
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            // 
            // PartyModuleSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 682);
            this.Controls.Add(this.dataGridViewSupplier);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.textBoxContactPerson);
            this.Controls.Add(this.textBoxContact);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PartyModuleSupplier";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.PartyModuleSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.TextBox textBoxContactPerson;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.DataGridView dataGridViewSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
    }
}