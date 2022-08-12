namespace Magazin
{
    partial class FormAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdd));
            this.buttonCanc = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxNamei = new System.Windows.Forms.TextBox();
            this.textBoxCounti = new System.Windows.Forms.TextBox();
            this.textBoxPricei = new System.Windows.Forms.TextBox();
            this.comboBoxAvail = new System.Windows.Forms.ComboBox();
            this.textBoxArtic = new System.Windows.Forms.TextBox();
            this.textBoxSaler = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCanc
            // 
            this.buttonCanc.Location = new System.Drawing.Point(391, 471);
            this.buttonCanc.Name = "buttonCanc";
            this.buttonCanc.Size = new System.Drawing.Size(81, 27);
            this.buttonCanc.TabIndex = 0;
            this.buttonCanc.Text = "Отмена";
            this.buttonCanc.UseVisualStyleBackColor = true;
            this.buttonCanc.Click += new System.EventHandler(this.buttonCanc_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(50, 473);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Ок";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textBoxNamei
            // 
            this.textBoxNamei.Location = new System.Drawing.Point(194, 74);
            this.textBoxNamei.Name = "textBoxNamei";
            this.textBoxNamei.Size = new System.Drawing.Size(167, 20);
            this.textBoxNamei.TabIndex = 2;
            // 
            // textBoxCounti
            // 
            this.textBoxCounti.Location = new System.Drawing.Point(194, 130);
            this.textBoxCounti.Name = "textBoxCounti";
            this.textBoxCounti.Size = new System.Drawing.Size(167, 20);
            this.textBoxCounti.TabIndex = 3;
            // 
            // textBoxPricei
            // 
            this.textBoxPricei.Location = new System.Drawing.Point(194, 186);
            this.textBoxPricei.Name = "textBoxPricei";
            this.textBoxPricei.Size = new System.Drawing.Size(167, 20);
            this.textBoxPricei.TabIndex = 4;
            // 
            // comboBoxAvail
            // 
            this.comboBoxAvail.FormattingEnabled = true;
            this.comboBoxAvail.Location = new System.Drawing.Point(194, 242);
            this.comboBoxAvail.Name = "comboBoxAvail";
            this.comboBoxAvail.Size = new System.Drawing.Size(167, 21);
            this.comboBoxAvail.TabIndex = 5;
            // 
            // textBoxArtic
            // 
            this.textBoxArtic.Location = new System.Drawing.Point(194, 308);
            this.textBoxArtic.Name = "textBoxArtic";
            this.textBoxArtic.Size = new System.Drawing.Size(167, 20);
            this.textBoxArtic.TabIndex = 6;
            // 
            // textBoxSaler
            // 
            this.textBoxSaler.Location = new System.Drawing.Point(194, 370);
            this.textBoxSaler.Name = "textBoxSaler";
            this.textBoxSaler.Size = new System.Drawing.Size(167, 20);
            this.textBoxSaler.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите наименование товара:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Введите количество товара:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Введите стоимость товара:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Выберите тип наличия товара:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Введите артикул товара:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Введите продавца товара:";
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 552);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSaler);
            this.Controls.Add(this.textBoxArtic);
            this.Controls.Add(this.comboBoxAvail);
            this.Controls.Add(this.textBoxPricei);
            this.Controls.Add(this.textBoxCounti);
            this.Controls.Add(this.textBoxNamei);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCanc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление товара";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCanc;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBoxNamei;
        private System.Windows.Forms.TextBox textBoxCounti;
        private System.Windows.Forms.TextBox textBoxPricei;
        private System.Windows.Forms.ComboBox comboBoxAvail;
        private System.Windows.Forms.TextBox textBoxArtic;
        private System.Windows.Forms.TextBox textBoxSaler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}