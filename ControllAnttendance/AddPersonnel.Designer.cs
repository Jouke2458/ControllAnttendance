namespace ControllAnttendance
{
    partial class AddPersonnelss
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoadPhoto = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Names = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MiddleName = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::ControllAnttendance.Properties.Resources.default_photo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoadPhoto
            // 
            this.LoadPhoto.Location = new System.Drawing.Point(12, 177);
            this.LoadPhoto.Name = "LoadPhoto";
            this.LoadPhoto.Size = new System.Drawing.Size(118, 23);
            this.LoadPhoto.TabIndex = 1;
            this.LoadPhoto.Text = "Загрузить";
            this.LoadPhoto.UseVisualStyleBackColor = true;
            this.LoadPhoto.Click += new System.EventHandler(this.LoadPhoto_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 2;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(212, 12);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(118, 20);
            this.LastName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Имя";
            // 
            // Names
            // 
            this.Names.Location = new System.Drawing.Point(212, 38);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(118, 20);
            this.Names.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Отчество";
            // 
            // MiddleName
            // 
            this.MiddleName.Location = new System.Drawing.Point(212, 64);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(118, 20);
            this.MiddleName.TabIndex = 7;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(318, 398);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(118, 23);
            this.Send.TabIndex = 9;
            this.Send.Text = "Отправить";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddPersonnelss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 433);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MiddleName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Names);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LoadPhoto);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddPersonnelss";
            this.Text = "Add Personnel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LoadPhoto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Names;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MiddleName;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}