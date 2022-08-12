namespace Magazin
{
    partial class FormAcceptOrderBuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAcceptOrderBuy));
            this.dataGridViewAccOrdBuy = new System.Windows.Forms.DataGridView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccOrdBuy)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAccOrdBuy
            // 
            this.dataGridViewAccOrdBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccOrdBuy.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewAccOrdBuy.Name = "dataGridViewAccOrdBuy";
            this.dataGridViewAccOrdBuy.Size = new System.Drawing.Size(776, 397);
            this.dataGridViewAccOrdBuy.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(684, 415);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сформировать отчет комиссионера";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormAcceptOrderBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridViewAccOrdBuy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAcceptOrderBuy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Принятые заказы на покупку";
            this.Load += new System.EventHandler(this.FormAcceptOrderBuy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccOrdBuy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAccOrdBuy;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button button1;
    }
}