
namespace QLCuaHangGao
{
    partial class FormChangePassword
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
            this.txtPassOld = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPassNew = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPassOld
            // 
            this.txtPassOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassOld.Location = new System.Drawing.Point(151, 28);
            this.txtPassOld.Name = "txtPassOld";
            this.txtPassOld.PasswordChar = '*';
            this.txtPassOld.Size = new System.Drawing.Size(186, 26);
            this.txtPassOld.TabIndex = 11;
            this.txtPassOld.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "Mật Khẩu Cũ";
            // 
            // txtPassNew
            // 
            this.txtPassNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPassNew.Location = new System.Drawing.Point(151, 71);
            this.txtPassNew.Name = "txtPassNew";
            this.txtPassNew.PasswordChar = '*';
            this.txtPassNew.Size = new System.Drawing.Size(186, 26);
            this.txtPassNew.TabIndex = 13;
            this.txtPassNew.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mật Khẩu Mới";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 58);
            this.button1.TabIndex = 14;
            this.button1.Text = "Đổi Mật Khẩu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 217);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPassNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassOld);
            this.Controls.Add(this.label8);
            this.Name = "FormChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormChangePassword";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassOld;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPassNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}