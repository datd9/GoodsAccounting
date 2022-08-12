namespace Magazin
{
    partial class FormOrderBuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrderBuy));
            this.buttonBack = new System.Windows.Forms.Button();
            this.dataGridViewOrdOn = new System.Windows.Forms.DataGridView();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCountItem = new System.Windows.Forms.Label();
            this.labelArt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSearch2 = new System.Windows.Forms.TextBox();
            this.labelNameI = new System.Windows.Forms.Label();
            this.labelCountCheck = new System.Windows.Forms.Label();
            this.textBoxNameI = new System.Windows.Forms.TextBox();
            this.textBoxCountCheck = new System.Windows.Forms.TextBox();
            this.textBoxArt = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdOn)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(673, 394);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(81, 25);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // dataGridViewOrdOn
            // 
            this.dataGridViewOrdOn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrdOn.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewOrdOn.Name = "dataGridViewOrdOn";
            this.dataGridViewOrdOn.Size = new System.Drawing.Size(486, 407);
            this.dataGridViewOrdOn.TabIndex = 1;
            this.dataGridViewOrdOn.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewOrdOn_MouseDoubleClick);
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(621, 156);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonOrder.TabIndex = 2;
            this.buttonOrder.Text = "Заказать";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(507, 72);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(311, 20);
            this.textBoxCount.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите товар и напишите нужное количество для заказа:";
            // 
            // labelCountItem
            // 
            this.labelCountItem.AutoSize = true;
            this.labelCountItem.Location = new System.Drawing.Point(386, 428);
            this.labelCountItem.Name = "labelCountItem";
            this.labelCountItem.Size = new System.Drawing.Size(0, 13);
            this.labelCountItem.TabIndex = 5;
            this.labelCountItem.Visible = false;
            // 
            // labelArt
            // 
            this.labelArt.AutoSize = true;
            this.labelArt.Location = new System.Drawing.Point(430, 428);
            this.labelArt.Name = "labelArt";
            this.labelArt.Size = new System.Drawing.Size(0, 13);
            this.labelArt.TabIndex = 6;
            this.labelArt.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Поиск товара по наименованию:";
            // 
            // textBoxSearch2
            // 
            this.textBoxSearch2.Location = new System.Drawing.Point(684, 9);
            this.textBoxSearch2.Name = "textBoxSearch2";
            this.textBoxSearch2.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch2.TabIndex = 8;
            this.textBoxSearch2.TextChanged += new System.EventHandler(this.textBoxSearch2_TextChanged);
            // 
            // labelNameI
            // 
            this.labelNameI.AutoSize = true;
            this.labelNameI.Location = new System.Drawing.Point(180, 428);
            this.labelNameI.Name = "labelNameI";
            this.labelNameI.Size = new System.Drawing.Size(0, 13);
            this.labelNameI.TabIndex = 9;
            this.labelNameI.Visible = false;
            // 
            // labelCountCheck
            // 
            this.labelCountCheck.AutoSize = true;
            this.labelCountCheck.Location = new System.Drawing.Point(25, 428);
            this.labelCountCheck.Name = "labelCountCheck";
            this.labelCountCheck.Size = new System.Drawing.Size(0, 13);
            this.labelCountCheck.TabIndex = 10;
            this.labelCountCheck.Visible = false;
            // 
            // textBoxNameI
            // 
            this.textBoxNameI.Location = new System.Drawing.Point(47, 425);
            this.textBoxNameI.Name = "textBoxNameI";
            this.textBoxNameI.Size = new System.Drawing.Size(23, 20);
            this.textBoxNameI.TabIndex = 11;
            this.textBoxNameI.Visible = false;
            // 
            // textBoxCountCheck
            // 
            this.textBoxCountCheck.Location = new System.Drawing.Point(151, 425);
            this.textBoxCountCheck.Name = "textBoxCountCheck";
            this.textBoxCountCheck.Size = new System.Drawing.Size(23, 20);
            this.textBoxCountCheck.TabIndex = 12;
            this.textBoxCountCheck.Visible = false;
            // 
            // textBoxArt
            // 
            this.textBoxArt.Location = new System.Drawing.Point(239, 425);
            this.textBoxArt.Name = "textBoxArt";
            this.textBoxArt.Size = new System.Drawing.Size(23, 20);
            this.textBoxArt.TabIndex = 13;
            this.textBoxArt.Visible = false;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(507, 130);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(311, 20);
            this.textBoxNumber.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Введите номер вашего телефона:";
            // 
            // FormOrderBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.textBoxArt);
            this.Controls.Add(this.textBoxCountCheck);
            this.Controls.Add(this.textBoxNameI);
            this.Controls.Add(this.labelCountCheck);
            this.Controls.Add(this.labelNameI);
            this.Controls.Add(this.textBoxSearch2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelArt);
            this.Controls.Add(this.labelCountItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.dataGridViewOrdOn);
            this.Controls.Add(this.buttonBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOrderBuy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товар для заказа в наличие";
            this.Load += new System.EventHandler(this.FormOrderBuy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdOn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridView dataGridViewOrdOn;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCountItem;
        private System.Windows.Forms.Label labelArt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSearch2;
        private System.Windows.Forms.Label labelNameI;
        private System.Windows.Forms.Label labelCountCheck;
        private System.Windows.Forms.TextBox textBoxNameI;
        private System.Windows.Forms.TextBox textBoxCountCheck;
        private System.Windows.Forms.TextBox textBoxArt;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label3;
    }
}