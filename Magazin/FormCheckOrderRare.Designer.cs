namespace Magazin
{
    partial class FormCheckOrderRare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheckOrderRare));
            this.buttonBack = new System.Windows.Forms.Button();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxNameI = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxSaler = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxCond = new System.Windows.Forms.TextBox();
            this.buttonAccept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(861, 454);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.Size = new System.Drawing.Size(924, 426);
            this.dataGridViewOrders.TabIndex = 1;
            this.dataGridViewOrders.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewOrders_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поиск по наименованию:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(154, 444);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(271, 447);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(18, 20);
            this.textBoxId.TabIndex = 4;
            this.textBoxId.Visible = false;
            // 
            // textBoxNameI
            // 
            this.textBoxNameI.Location = new System.Drawing.Point(295, 447);
            this.textBoxNameI.Name = "textBoxNameI";
            this.textBoxNameI.Size = new System.Drawing.Size(18, 20);
            this.textBoxNameI.TabIndex = 5;
            this.textBoxNameI.Visible = false;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(319, 447);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(18, 20);
            this.textBoxPrice.TabIndex = 6;
            this.textBoxPrice.Visible = false;
            // 
            // textBoxSaler
            // 
            this.textBoxSaler.Location = new System.Drawing.Point(343, 447);
            this.textBoxSaler.Name = "textBoxSaler";
            this.textBoxSaler.Size = new System.Drawing.Size(18, 20);
            this.textBoxSaler.TabIndex = 7;
            this.textBoxSaler.Visible = false;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(367, 447);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(18, 20);
            this.textBoxNumber.TabIndex = 8;
            this.textBoxNumber.Visible = false;
            // 
            // textBoxCond
            // 
            this.textBoxCond.Location = new System.Drawing.Point(391, 447);
            this.textBoxCond.Name = "textBoxCond";
            this.textBoxCond.Size = new System.Drawing.Size(18, 20);
            this.textBoxCond.TabIndex = 9;
            this.textBoxCond.Visible = false;
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(427, 445);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(149, 23);
            this.buttonAccept.TabIndex = 10;
            this.buttonAccept.Text = "Выбрать победителя";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // FormCheckOrderRare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 489);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.textBoxCond);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.textBoxSaler);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxNameI);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.buttonBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCheckOrderRare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Активные заявки на аукцион";
            this.Load += new System.EventHandler(this.FormCheckOrderRare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxNameI;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxSaler;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxCond;
        private System.Windows.Forms.Button buttonAccept;
    }
}