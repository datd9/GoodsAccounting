namespace Magazin
{
    partial class FormCheckBuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheckBuy));
            this.buttonBack = new System.Windows.Forms.Button();
            this.dataGridViewOrderBuy = new System.Windows.Forms.DataGridView();
            this.buttonAcc = new System.Windows.Forms.Button();
            this.textBoxNameI = new System.Windows.Forms.TextBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.textBoxArt = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxAll = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderBuy)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(698, 415);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // dataGridViewOrderBuy
            // 
            this.dataGridViewOrderBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderBuy.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewOrderBuy.Name = "dataGridViewOrderBuy";
            this.dataGridViewOrderBuy.Size = new System.Drawing.Size(607, 426);
            this.dataGridViewOrderBuy.TabIndex = 1;
            this.dataGridViewOrderBuy.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewOrderBuy_MouseDoubleClick);
            // 
            // buttonAcc
            // 
            this.buttonAcc.Location = new System.Drawing.Point(660, 27);
            this.buttonAcc.Name = "buttonAcc";
            this.buttonAcc.Size = new System.Drawing.Size(80, 28);
            this.buttonAcc.TabIndex = 2;
            this.buttonAcc.Text = "Принять";
            this.buttonAcc.UseVisualStyleBackColor = true;
            this.buttonAcc.Click += new System.EventHandler(this.buttonAcc_Click);
            // 
            // textBoxNameI
            // 
            this.textBoxNameI.Location = new System.Drawing.Point(642, 102);
            this.textBoxNameI.Name = "textBoxNameI";
            this.textBoxNameI.Size = new System.Drawing.Size(15, 20);
            this.textBoxNameI.TabIndex = 3;
            this.textBoxNameI.Visible = false;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(642, 148);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(15, 20);
            this.textBoxCount.TabIndex = 4;
            this.textBoxCount.Visible = false;
            // 
            // textBoxArt
            // 
            this.textBoxArt.Location = new System.Drawing.Point(642, 193);
            this.textBoxArt.Name = "textBoxArt";
            this.textBoxArt.Size = new System.Drawing.Size(15, 20);
            this.textBoxArt.TabIndex = 5;
            this.textBoxArt.Visible = false;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(642, 243);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(15, 20);
            this.textBoxNumber.TabIndex = 6;
            this.textBoxNumber.Visible = false;
            // 
            // textBoxAll
            // 
            this.textBoxAll.Location = new System.Drawing.Point(642, 283);
            this.textBoxAll.Name = "textBoxAll";
            this.textBoxAll.Size = new System.Drawing.Size(15, 20);
            this.textBoxAll.TabIndex = 7;
            this.textBoxAll.Visible = false;
            // 
            // FormCheckBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxAll);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.textBoxArt);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.textBoxNameI);
            this.Controls.Add(this.buttonAcc);
            this.Controls.Add(this.dataGridViewOrderBuy);
            this.Controls.Add(this.buttonBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCheckBuy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Активные заявки на покупку";
            this.Load += new System.EventHandler(this.FormCheckBuy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderBuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridView dataGridViewOrderBuy;
        private System.Windows.Forms.Button buttonAcc;
        private System.Windows.Forms.TextBox textBoxNameI;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.TextBox textBoxArt;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxAll;
    }
}