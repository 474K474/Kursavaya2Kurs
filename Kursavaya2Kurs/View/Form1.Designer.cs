namespace Kursavaya2Kurs
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Addbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.weighttxt = new System.Windows.Forms.TextBox();
            this.quantitytxt = new System.Windows.Forms.TextBox();
            this.ProductInfoBox = new System.Windows.Forms.RichTextBox();
            this.ProductList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Paybtn = new System.Windows.Forms.Button();
            this.Delbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bonusRichTextBox = new System.Windows.Forms.RichTextBox();
            this.moneyRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MonBonrb = new System.Windows.Forms.RadioButton();
            this.Bonusrb = new System.Windows.Forms.RadioButton();
            this.Moneyrb = new System.Windows.Forms.RadioButton();
            this.CartList = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Addbtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.weighttxt);
            this.groupBox1.Controls.Add(this.quantitytxt);
            this.groupBox1.Controls.Add(this.ProductInfoBox);
            this.groupBox1.Controls.Add(this.ProductList);
            this.groupBox1.Location = new System.Drawing.Point(23, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 376);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Catalog";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Product Info";
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(205, 314);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(143, 47);
            this.Addbtn.TabIndex = 6;
            this.Addbtn.Text = "Add Product";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "weight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "quantity";
            // 
            // weighttxt
            // 
            this.weighttxt.Location = new System.Drawing.Point(205, 221);
            this.weighttxt.Name = "weighttxt";
            this.weighttxt.Size = new System.Drawing.Size(143, 22);
            this.weighttxt.TabIndex = 3;
            // 
            // quantitytxt
            // 
            this.quantitytxt.Location = new System.Drawing.Point(205, 161);
            this.quantitytxt.Name = "quantitytxt";
            this.quantitytxt.Size = new System.Drawing.Size(143, 22);
            this.quantitytxt.TabIndex = 2;
            // 
            // ProductInfoBox
            // 
            this.ProductInfoBox.Location = new System.Drawing.Point(205, 42);
            this.ProductInfoBox.Name = "ProductInfoBox";
            this.ProductInfoBox.Size = new System.Drawing.Size(233, 67);
            this.ProductInfoBox.TabIndex = 1;
            this.ProductInfoBox.Text = "";
            // 
            // ProductList
            // 
            this.ProductList.FormattingEnabled = true;
            this.ProductList.ItemHeight = 16;
            this.ProductList.Location = new System.Drawing.Point(6, 21);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(176, 340);
            this.ProductList.TabIndex = 0;
            this.ProductList.SelectedIndexChanged += new System.EventHandler(this.ProductList_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.totalLabel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Paybtn);
            this.groupBox2.Controls.Add(this.Delbtn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.bonusRichTextBox);
            this.groupBox2.Controls.Add(this.moneyRichTextBox);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.CartList);
            this.groupBox2.Location = new System.Drawing.Point(517, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 375);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cart";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(292, 282);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(66, 16);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "totalLabel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cost";
            // 
            // Paybtn
            // 
            this.Paybtn.Location = new System.Drawing.Point(305, 314);
            this.Paybtn.Name = "Paybtn";
            this.Paybtn.Size = new System.Drawing.Size(61, 47);
            this.Paybtn.TabIndex = 8;
            this.Paybtn.Text = "Pay";
            this.Paybtn.UseVisualStyleBackColor = true;
            this.Paybtn.Click += new System.EventHandler(this.Paybtn_Click);
            // 
            // Delbtn
            // 
            this.Delbtn.Location = new System.Drawing.Point(223, 314);
            this.Delbtn.Name = "Delbtn";
            this.Delbtn.Size = new System.Drawing.Size(76, 47);
            this.Delbtn.TabIndex = 7;
            this.Delbtn.Text = "Del Product";
            this.Delbtn.UseVisualStyleBackColor = true;
            this.Delbtn.Click += new System.EventHandler(this.Delbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bonus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Money";
            // 
            // bonusRichTextBox
            // 
            this.bonusRichTextBox.Location = new System.Drawing.Point(223, 246);
            this.bonusRichTextBox.Name = "bonusRichTextBox";
            this.bonusRichTextBox.Size = new System.Drawing.Size(143, 21);
            this.bonusRichTextBox.TabIndex = 4;
            this.bonusRichTextBox.Text = "";
            // 
            // moneyRichTextBox
            // 
            this.moneyRichTextBox.Location = new System.Drawing.Point(223, 202);
            this.moneyRichTextBox.Name = "moneyRichTextBox";
            this.moneyRichTextBox.Size = new System.Drawing.Size(143, 21);
            this.moneyRichTextBox.TabIndex = 3;
            this.moneyRichTextBox.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MonBonrb);
            this.groupBox3.Controls.Add(this.Bonusrb);
            this.groupBox3.Controls.Add(this.Moneyrb);
            this.groupBox3.Location = new System.Drawing.Point(223, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(143, 148);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pay Metod";
            // 
            // MonBonrb
            // 
            this.MonBonrb.AutoSize = true;
            this.MonBonrb.Location = new System.Drawing.Point(16, 105);
            this.MonBonrb.Name = "MonBonrb";
            this.MonBonrb.Size = new System.Drawing.Size(120, 20);
            this.MonBonrb.TabIndex = 2;
            this.MonBonrb.TabStop = true;
            this.MonBonrb.Text = "Money + Bonus";
            this.MonBonrb.UseVisualStyleBackColor = true;
            // 
            // Bonusrb
            // 
            this.Bonusrb.AutoSize = true;
            this.Bonusrb.Location = new System.Drawing.Point(16, 68);
            this.Bonusrb.Name = "Bonusrb";
            this.Bonusrb.Size = new System.Drawing.Size(66, 20);
            this.Bonusrb.TabIndex = 1;
            this.Bonusrb.TabStop = true;
            this.Bonusrb.Text = "Bonus";
            this.Bonusrb.UseVisualStyleBackColor = true;
            // 
            // Moneyrb
            // 
            this.Moneyrb.AutoSize = true;
            this.Moneyrb.Location = new System.Drawing.Point(16, 33);
            this.Moneyrb.Name = "Moneyrb";
            this.Moneyrb.Size = new System.Drawing.Size(69, 20);
            this.Moneyrb.TabIndex = 0;
            this.Moneyrb.TabStop = true;
            this.Moneyrb.Text = "Money";
            this.Moneyrb.UseVisualStyleBackColor = true;
            // 
            // CartList
            // 
            this.CartList.FormattingEnabled = true;
            this.CartList.ItemHeight = 16;
            this.CartList.Location = new System.Drawing.Point(16, 21);
            this.CartList.Name = "CartList";
            this.CartList.Size = new System.Drawing.Size(168, 340);
            this.CartList.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 448);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Magazin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox ProductInfoBox;
        private System.Windows.Forms.ListBox ProductList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton MonBonrb;
        private System.Windows.Forms.RadioButton Bonusrb;
        private System.Windows.Forms.RadioButton Moneyrb;
        private System.Windows.Forms.ListBox CartList;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox weighttxt;
        private System.Windows.Forms.TextBox quantitytxt;
        private System.Windows.Forms.RichTextBox bonusRichTextBox;
        private System.Windows.Forms.RichTextBox moneyRichTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Paybtn;
        private System.Windows.Forms.Button Delbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label label6;
    }
}

