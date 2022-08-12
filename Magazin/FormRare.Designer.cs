namespace Magazin
{
    partial class FormRare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRare));
            this.dataGridViewRare = new System.Windows.Forms.DataGridView();
            this.buttonAddR = new System.Windows.Forms.Button();
            this.buttonDelR = new System.Windows.Forms.Button();
            this.labelS = new System.Windows.Forms.Label();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelSC = new System.Windows.Forms.Label();
            this.textBoxSC = new System.Windows.Forms.TextBox();
            this.buttonExp = new System.Windows.Forms.Button();
            this.textBoxNameItem = new System.Windows.Forms.TextBox();
            this.textBoxCond = new System.Windows.Forms.TextBox();
            this.textBoxStartPrice = new System.Windows.Forms.TextBox();
            this.textBoxAvail = new System.Windows.Forms.TextBox();
            this.labelChange = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRare)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRare
            // 
            this.dataGridViewRare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRare.Location = new System.Drawing.Point(12, 25);
            this.dataGridViewRare.Name = "dataGridViewRare";
            this.dataGridViewRare.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRare.Size = new System.Drawing.Size(553, 413);
            this.dataGridViewRare.TabIndex = 0;
            this.dataGridViewRare.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewRare_MouseDoubleClick);
            // 
            // buttonAddR
            // 
            this.buttonAddR.Location = new System.Drawing.Point(582, 100);
            this.buttonAddR.Name = "buttonAddR";
            this.buttonAddR.Size = new System.Drawing.Size(104, 41);
            this.buttonAddR.TabIndex = 1;
            this.buttonAddR.Text = "Добавить товар";
            this.buttonAddR.UseVisualStyleBackColor = true;
            this.buttonAddR.Click += new System.EventHandler(this.buttonAddR_Click);
            // 
            // buttonDelR
            // 
            this.buttonDelR.Location = new System.Drawing.Point(707, 100);
            this.buttonDelR.Name = "buttonDelR";
            this.buttonDelR.Size = new System.Drawing.Size(104, 41);
            this.buttonDelR.TabIndex = 2;
            this.buttonDelR.Text = "Удалить товар";
            this.buttonDelR.UseVisualStyleBackColor = true;
            this.buttonDelR.Click += new System.EventHandler(this.buttonDelR_Click);
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Location = new System.Drawing.Point(571, 25);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(139, 13);
            this.labelS.TabIndex = 3;
            this.labelS.Text = "Поиск по наименованию: ";
            // 
            // textBoxS
            // 
            this.textBoxS.Location = new System.Drawing.Point(725, 25);
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.Size = new System.Drawing.Size(118, 20);
            this.textBoxS.TabIndex = 4;
            this.textBoxS.TextChanged += new System.EventHandler(this.textBoxS_TextChanged_1);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(736, 415);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelSC
            // 
            this.labelSC.AutoSize = true;
            this.labelSC.Location = new System.Drawing.Point(571, 62);
            this.labelSC.Name = "labelSC";
            this.labelSC.Size = new System.Drawing.Size(115, 13);
            this.labelSC.TabIndex = 6;
            this.labelSC.Text = "Поиск по состоянию:";
            // 
            // textBoxSC
            // 
            this.textBoxSC.Location = new System.Drawing.Point(725, 62);
            this.textBoxSC.Name = "textBoxSC";
            this.textBoxSC.Size = new System.Drawing.Size(118, 20);
            this.textBoxSC.TabIndex = 7;
            this.textBoxSC.TextChanged += new System.EventHandler(this.textBoxSC_TextChanged);
            // 
            // buttonExp
            // 
            this.buttonExp.Location = new System.Drawing.Point(597, 415);
            this.buttonExp.Name = "buttonExp";
            this.buttonExp.Size = new System.Drawing.Size(89, 23);
            this.buttonExp.TabIndex = 8;
            this.buttonExp.Text = "Экспорт";
            this.buttonExp.UseVisualStyleBackColor = true;
            this.buttonExp.Click += new System.EventHandler(this.buttonExp_Click);
            // 
            // textBoxNameItem
            // 
            this.textBoxNameItem.Location = new System.Drawing.Point(743, 179);
            this.textBoxNameItem.Name = "textBoxNameItem";
            this.textBoxNameItem.Size = new System.Drawing.Size(100, 20);
            this.textBoxNameItem.TabIndex = 9;
            // 
            // textBoxCond
            // 
            this.textBoxCond.Location = new System.Drawing.Point(743, 221);
            this.textBoxCond.Name = "textBoxCond";
            this.textBoxCond.Size = new System.Drawing.Size(100, 20);
            this.textBoxCond.TabIndex = 10;
            // 
            // textBoxStartPrice
            // 
            this.textBoxStartPrice.Location = new System.Drawing.Point(743, 266);
            this.textBoxStartPrice.Name = "textBoxStartPrice";
            this.textBoxStartPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartPrice.TabIndex = 11;
            // 
            // textBoxAvail
            // 
            this.textBoxAvail.Location = new System.Drawing.Point(743, 306);
            this.textBoxAvail.Name = "textBoxAvail";
            this.textBoxAvail.Size = new System.Drawing.Size(100, 20);
            this.textBoxAvail.TabIndex = 12;
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Location = new System.Drawing.Point(628, 144);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(155, 13);
            this.labelChange.TabIndex = 13;
            this.labelChange.Text = "Изменение данных о товаре:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(571, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Наименование товара:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(571, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Состояние товара:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Начальная стоимость товара:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(571, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Наличие товара:";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(643, 341);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(140, 29);
            this.buttonUpdate.TabIndex = 18;
            this.buttonUpdate.Text = "Изменить информацию";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // FormRare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 456);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelChange);
            this.Controls.Add(this.textBoxAvail);
            this.Controls.Add(this.textBoxStartPrice);
            this.Controls.Add(this.textBoxCond);
            this.Controls.Add(this.textBoxNameItem);
            this.Controls.Add(this.buttonExp);
            this.Controls.Add(this.textBoxSC);
            this.Controls.Add(this.labelSC);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxS);
            this.Controls.Add(this.labelS);
            this.Controls.Add(this.buttonDelR);
            this.Controls.Add(this.buttonAddR);
            this.Controls.Add(this.dataGridViewRare);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аукционные товары";
            this.Load += new System.EventHandler(this.FormRare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRare;
        private System.Windows.Forms.Button buttonAddR;
        private System.Windows.Forms.Button buttonDelR;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.TextBox textBoxS;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelSC;
        private System.Windows.Forms.TextBox textBoxSC;
        private System.Windows.Forms.Button buttonExp;
        private System.Windows.Forms.TextBox textBoxNameItem;
        private System.Windows.Forms.TextBox textBoxCond;
        private System.Windows.Forms.TextBox textBoxStartPrice;
        private System.Windows.Forms.TextBox textBoxAvail;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonUpdate;
    }
}