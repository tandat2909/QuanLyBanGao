
namespace testdatabase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtCate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCateAdd = new System.Windows.Forms.Button();
            this.cbxCate = new System.Windows.Forms.ComboBox();
            this.btnCateDelete = new System.Windows.Forms.Button();
            this.btnCateUpdate = new System.Windows.Forms.Button();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.lbProduct = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnProductUpdate = new System.Windows.Forms.Button();
            this.cbxProduct = new System.Windows.Forms.ComboBox();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.txtProPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(139, 228);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(100, 23);
            this.txtusername.TabIndex = 3;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(336, 227);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(100, 23);
            this.txtpassword.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(139, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtCate
            // 
            this.txtCate.Location = new System.Drawing.Point(95, 350);
            this.txtCate.Name = "txtCate";
            this.txtCate.Size = new System.Drawing.Size(177, 23);
            this.txtCate.TabIndex = 7;
            this.txtCate.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Category Add";
            // 
            // btnCateAdd
            // 
            this.btnCateAdd.Location = new System.Drawing.Point(300, 350);
            this.btnCateAdd.Name = "btnCateAdd";
            this.btnCateAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCateAdd.TabIndex = 9;
            this.btnCateAdd.Text = "Add";
            this.btnCateAdd.UseVisualStyleBackColor = true;
            this.btnCateAdd.Click += new System.EventHandler(this.btnCateAdd_Click);
            // 
            // cbxCate
            // 
            this.cbxCate.FormattingEnabled = true;
            this.cbxCate.Location = new System.Drawing.Point(414, 353);
            this.cbxCate.Name = "cbxCate";
            this.cbxCate.Size = new System.Drawing.Size(121, 23);
            this.cbxCate.TabIndex = 10;
            this.cbxCate.SelectedIndexChanged += new System.EventHandler(this.cbxCate_SelectedIndexChanged);
            // 
            // btnCateDelete
            // 
            this.btnCateDelete.Location = new System.Drawing.Point(659, 349);
            this.btnCateDelete.Name = "btnCateDelete";
            this.btnCateDelete.Size = new System.Drawing.Size(75, 23);
            this.btnCateDelete.TabIndex = 11;
            this.btnCateDelete.Text = "Delete";
            this.btnCateDelete.UseVisualStyleBackColor = true;
            this.btnCateDelete.Click += new System.EventHandler(this.btnCateDelete_Click);
            // 
            // btnCateUpdate
            // 
            this.btnCateUpdate.Location = new System.Drawing.Point(555, 350);
            this.btnCateUpdate.Name = "btnCateUpdate";
            this.btnCateUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCateUpdate.TabIndex = 12;
            this.btnCateUpdate.Text = "Update";
            this.btnCateUpdate.UseVisualStyleBackColor = true;
            this.btnCateUpdate.Click += new System.EventHandler(this.btnCateUpdate_Click);
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(460, 405);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(75, 23);
            this.btnProductAdd.TabIndex = 13;
            this.btnProductAdd.Text = "Add";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // lbProduct
            // 
            this.lbProduct.AutoSize = true;
            this.lbProduct.Location = new System.Drawing.Point(0, 409);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(80, 15);
            this.lbProduct.TabIndex = 14;
            this.lbProduct.Text = "Category Add";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(95, 406);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(92, 23);
            this.txtProductName.TabIndex = 15;
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.Location = new System.Drawing.Point(555, 405);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnProductUpdate.TabIndex = 16;
            this.btnProductUpdate.Text = "Update";
            this.btnProductUpdate.UseVisualStyleBackColor = true;
            // 
            // cbxProduct
            // 
            this.cbxProduct.FormattingEnabled = true;
            this.cbxProduct.Location = new System.Drawing.Point(300, 406);
            this.cbxProduct.Name = "cbxProduct";
            this.cbxProduct.Size = new System.Drawing.Size(121, 23);
            this.cbxProduct.TabIndex = 17;
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.Location = new System.Drawing.Point(659, 405);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(75, 23);
            this.btnProductDelete.TabIndex = 18;
            this.btnProductDelete.Text = "Delete";
            this.btnProductDelete.UseVisualStyleBackColor = true;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // txtProPrice
            // 
            this.txtProPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtProPrice.Location = new System.Drawing.Point(197, 405);
            this.txtProPrice.Name = "txtProPrice";
            this.txtProPrice.Size = new System.Drawing.Size(92, 23);
            this.txtProPrice.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtProPrice);
            this.Controls.Add(this.btnProductDelete);
            this.Controls.Add(this.cbxProduct);
            this.Controls.Add(this.btnProductUpdate);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lbProduct);
            this.Controls.Add(this.btnProductAdd);
            this.Controls.Add(this.btnCateUpdate);
            this.Controls.Add(this.btnCateDelete);
            this.Controls.Add(this.cbxCate);
            this.Controls.Add(this.btnCateAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCate);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtCate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCateAdd;
        private System.Windows.Forms.ComboBox cbxCate;
        private System.Windows.Forms.Button btnCateDelete;
        private System.Windows.Forms.Button btnCateUpdate;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.Label lbProduct;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnProductUpdate;
        private System.Windows.Forms.ComboBox cbxProduct;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.TextBox txtProPrice;
    }
}

