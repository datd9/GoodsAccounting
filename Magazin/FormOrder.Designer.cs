namespace Magazin
{
    partial class FormOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBoxNameItem = new System.Windows.Forms.TextBox();
            this.textBoxCountItem = new System.Windows.Forms.TextBox();
            this.textBoxPriceItem = new System.Windows.Forms.TextBox();
            this.textBoxNameSaler = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(133, 376);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "Ок";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(586, 376);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Отмена";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxNameItem
            // 
            this.textBoxNameItem.Location = new System.Drawing.Point(322, 61);
            this.textBoxNameItem.Name = "textBoxNameItem";
            this.textBoxNameItem.Size = new System.Drawing.Size(164, 20);
            this.textBoxNameItem.TabIndex = 2;
            // 
            // textBoxCountItem
            // 
            this.textBoxCountItem.Location = new System.Drawing.Point(322, 145);
            this.textBoxCountItem.Name = "textBoxCountItem";
            this.textBoxCountItem.Size = new System.Drawing.Size(164, 20);
            this.textBoxCountItem.TabIndex = 3;
            // 
            // textBoxPriceItem
            // 
            this.textBoxPriceItem.Location = new System.Drawing.Point(322, 227);
            this.textBoxPriceItem.Name = "textBoxPriceItem";
            this.textBoxPriceItem.Size = new System.Drawing.Size(164, 20);
            this.textBoxPriceItem.TabIndex = 4;
            // 
            // textBoxNameSaler
            // 
            this.textBoxNameSaler.Location = new System.Drawing.Point(322, 315);
            this.textBoxNameSaler.Name = "textBoxNameSaler";
            this.textBoxNameSaler.Size = new System.Drawing.Size(164, 20);
            this.textBoxNameSaler.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите наименование товара:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Введите количество товара:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введите цену товара:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Введите ваше имя / Название вашей организации: ";
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNameSaler);
            this.Controls.Add(this.textBoxPriceItem);
            this.Controls.Add(this.textBoxCountItem);
            this.Controls.Add(this.textBoxNameItem);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заявка на продажу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textBoxNameItem;
        private System.Windows.Forms.TextBox textBoxCountItem;
        private System.Windows.Forms.TextBox textBoxPriceItem;
        private System.Windows.Forms.TextBox textBoxNameSaler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}