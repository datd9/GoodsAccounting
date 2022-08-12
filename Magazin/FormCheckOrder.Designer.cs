namespace Magazin
{
    partial class FormCheckOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheckOrder));
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonEnterOrd = new System.Windows.Forms.Button();
            this.textBoxNameItem = new System.Windows.Forms.TextBox();
            this.textBoxCountItem = new System.Windows.Forms.TextBox();
            this.textBoxPriceItem = new System.Windows.Forms.TextBox();
            this.textBoxNameSaler = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(12, 25);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrders.Size = new System.Drawing.Size(582, 413);
            this.dataGridViewOrders.TabIndex = 0;
            this.dataGridViewOrders.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewOrders_MouseDoubleClick);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(703, 415);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonEnterOrd
            // 
            this.buttonEnterOrd.Location = new System.Drawing.Point(619, 25);
            this.buttonEnterOrd.Name = "buttonEnterOrd";
            this.buttonEnterOrd.Size = new System.Drawing.Size(118, 27);
            this.buttonEnterOrd.TabIndex = 2;
            this.buttonEnterOrd.Text = "Принять заказ";
            this.buttonEnterOrd.UseVisualStyleBackColor = true;
            this.buttonEnterOrd.Click += new System.EventHandler(this.buttonEnterOrd_Click);
            // 
            // textBoxNameItem
            // 
            this.textBoxNameItem.Location = new System.Drawing.Point(619, 101);
            this.textBoxNameItem.Name = "textBoxNameItem";
            this.textBoxNameItem.Size = new System.Drawing.Size(118, 20);
            this.textBoxNameItem.TabIndex = 3;
            // 
            // textBoxCountItem
            // 
            this.textBoxCountItem.Location = new System.Drawing.Point(619, 160);
            this.textBoxCountItem.Name = "textBoxCountItem";
            this.textBoxCountItem.Size = new System.Drawing.Size(118, 20);
            this.textBoxCountItem.TabIndex = 4;
            // 
            // textBoxPriceItem
            // 
            this.textBoxPriceItem.Location = new System.Drawing.Point(619, 222);
            this.textBoxPriceItem.Name = "textBoxPriceItem";
            this.textBoxPriceItem.Size = new System.Drawing.Size(118, 20);
            this.textBoxPriceItem.TabIndex = 5;
            // 
            // textBoxNameSaler
            // 
            this.textBoxNameSaler.Location = new System.Drawing.Point(619, 276);
            this.textBoxNameSaler.Name = "textBoxNameSaler";
            this.textBoxNameSaler.Size = new System.Drawing.Size(118, 20);
            this.textBoxNameSaler.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(616, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Наименование товара:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(622, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Количество товара:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(622, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Цена товара:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(625, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Продавец:";
            // 
            // FormCheckOrder
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
            this.Controls.Add(this.buttonEnterOrd);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridViewOrders);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCheckOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поступившие предложения";
            this.Load += new System.EventHandler(this.FormCheckOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonEnterOrd;
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