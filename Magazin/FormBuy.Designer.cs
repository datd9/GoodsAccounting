namespace Magazin
{
    partial class FormBuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuy));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.dataGridViewFood = new System.Windows.Forms.DataGridView();
            this.buttonAdditem = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.textBoxNameItem = new System.Windows.Forms.TextBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.textBoxPriceItem = new System.Windows.Forms.TextBox();
            this.textBoxAvailItem = new System.Windows.Forms.TextBox();
            this.textBoxSaler = new System.Windows.Forms.TextBox();
            this.labelNameI = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelAvail = new System.Windows.Forms.Label();
            this.labelSaler = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonWrittenOf = new System.Windows.Forms.Button();
            this.labelabv = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSearchArt = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.comboBoxCond = new System.Windows.Forms.ComboBox();
            this.buttonAuc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFood)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1140, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // dataGridViewFood
            // 
            this.dataGridViewFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFood.Location = new System.Drawing.Point(12, 36);
            this.dataGridViewFood.Name = "dataGridViewFood";
            this.dataGridViewFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFood.Size = new System.Drawing.Size(800, 414);
            this.dataGridViewFood.TabIndex = 3;
            this.dataGridViewFood.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewFood_MouseDoubleClick_1);
            // 
            // buttonAdditem
            // 
            this.buttonAdditem.Location = new System.Drawing.Point(12, 456);
            this.buttonAdditem.Name = "buttonAdditem";
            this.buttonAdditem.Size = new System.Drawing.Size(118, 37);
            this.buttonAdditem.TabIndex = 4;
            this.buttonAdditem.Text = "Вручную добавить новый товар";
            this.buttonAdditem.UseVisualStyleBackColor = true;
            this.buttonAdditem.Click += new System.EventHandler(this.buttonAdditem_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(136, 456);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(118, 37);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Удалить выбранный товар";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(813, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Поиск по наименованию:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(966, 36);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(129, 20);
            this.textBoxSearch.TabIndex = 7;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(986, 416);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(109, 37);
            this.buttonChange.TabIndex = 8;
            this.buttonChange.Text = "Изменить информацию";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(260, 460);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(129, 28);
            this.buttonExport.TabIndex = 9;
            this.buttonExport.Text = "Экспорт в Excel";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // textBoxNameItem
            // 
            this.textBoxNameItem.Location = new System.Drawing.Point(968, 143);
            this.textBoxNameItem.Name = "textBoxNameItem";
            this.textBoxNameItem.Size = new System.Drawing.Size(129, 20);
            this.textBoxNameItem.TabIndex = 10;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(968, 197);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(129, 20);
            this.textBoxCount.TabIndex = 11;
            // 
            // textBoxPriceItem
            // 
            this.textBoxPriceItem.Location = new System.Drawing.Point(968, 258);
            this.textBoxPriceItem.Name = "textBoxPriceItem";
            this.textBoxPriceItem.Size = new System.Drawing.Size(129, 20);
            this.textBoxPriceItem.TabIndex = 12;
            // 
            // textBoxAvailItem
            // 
            this.textBoxAvailItem.Location = new System.Drawing.Point(968, 322);
            this.textBoxAvailItem.Name = "textBoxAvailItem";
            this.textBoxAvailItem.Size = new System.Drawing.Size(129, 20);
            this.textBoxAvailItem.TabIndex = 13;
            // 
            // textBoxSaler
            // 
            this.textBoxSaler.Location = new System.Drawing.Point(968, 381);
            this.textBoxSaler.Name = "textBoxSaler";
            this.textBoxSaler.Size = new System.Drawing.Size(129, 20);
            this.textBoxSaler.TabIndex = 14;
            // 
            // labelNameI
            // 
            this.labelNameI.AutoSize = true;
            this.labelNameI.Location = new System.Drawing.Point(815, 146);
            this.labelNameI.Name = "labelNameI";
            this.labelNameI.Size = new System.Drawing.Size(124, 13);
            this.labelNameI.TabIndex = 15;
            this.labelNameI.Text = "Наименование товара:";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(815, 200);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(107, 13);
            this.labelCount.TabIndex = 16;
            this.labelCount.Text = "Количество товара:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(815, 261);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(103, 13);
            this.labelPrice.TabIndex = 17;
            this.labelPrice.Text = "Стоимость товара:";
            // 
            // labelAvail
            // 
            this.labelAvail.AutoSize = true;
            this.labelAvail.Location = new System.Drawing.Point(818, 328);
            this.labelAvail.Name = "labelAvail";
            this.labelAvail.Size = new System.Drawing.Size(91, 13);
            this.labelAvail.TabIndex = 18;
            this.labelAvail.Text = "Наличие товара:";
            // 
            // labelSaler
            // 
            this.labelSaler.AutoSize = true;
            this.labelSaler.Location = new System.Drawing.Point(821, 387);
            this.labelSaler.Name = "labelSaler";
            this.labelSaler.Size = new System.Drawing.Size(98, 13);
            this.labelSaler.TabIndex = 19;
            this.labelSaler.Text = "Продавец товара:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(873, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Изменение данных о товаре:";
            // 
            // buttonWrittenOf
            // 
            this.buttonWrittenOf.Location = new System.Drawing.Point(680, 460);
            this.buttonWrittenOf.Name = "buttonWrittenOf";
            this.buttonWrittenOf.Size = new System.Drawing.Size(132, 54);
            this.buttonWrittenOf.TabIndex = 21;
            this.buttonWrittenOf.Text = "Списать выбранный товар на переоценку";
            this.buttonWrittenOf.UseVisualStyleBackColor = true;
            this.buttonWrittenOf.Click += new System.EventHandler(this.buttonWrittenOf_Click);
            // 
            // labelabv
            // 
            this.labelabv.AutoSize = true;
            this.labelabv.Location = new System.Drawing.Point(658, 468);
            this.labelabv.Name = "labelabv";
            this.labelabv.Size = new System.Drawing.Size(0, 13);
            this.labelabv.TabIndex = 22;
            this.labelabv.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(813, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Поиск по артикулу:";
            // 
            // textBoxSearchArt
            // 
            this.textBoxSearchArt.Location = new System.Drawing.Point(966, 73);
            this.textBoxSearchArt.Name = "textBoxSearchArt";
            this.textBoxSearchArt.Size = new System.Drawing.Size(129, 20);
            this.textBoxSearchArt.TabIndex = 24;
            this.textBoxSearchArt.TextChanged += new System.EventHandler(this.textBoxSearchArt_TextChanged);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(1021, 507);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(107, 23);
            this.buttonBack.TabIndex = 25;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // comboBoxCond
            // 
            this.comboBoxCond.FormattingEnabled = true;
            this.comboBoxCond.Location = new System.Drawing.Point(398, 493);
            this.comboBoxCond.Name = "comboBoxCond";
            this.comboBoxCond.Size = new System.Drawing.Size(245, 21);
            this.comboBoxCond.TabIndex = 26;
            // 
            // buttonAuc
            // 
            this.buttonAuc.Location = new System.Drawing.Point(395, 462);
            this.buttonAuc.Name = "buttonAuc";
            this.buttonAuc.Size = new System.Drawing.Size(248, 25);
            this.buttonAuc.TabIndex = 27;
            this.buttonAuc.Text = "Выставить выбранный товар на аукцион";
            this.buttonAuc.UseVisualStyleBackColor = true;
            this.buttonAuc.Click += new System.EventHandler(this.buttonAuc_Click);
            // 
            // FormBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 542);
            this.Controls.Add(this.buttonAuc);
            this.Controls.Add(this.comboBoxCond);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxSearchArt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelabv);
            this.Controls.Add(this.buttonWrittenOf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSaler);
            this.Controls.Add(this.labelAvail);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelNameI);
            this.Controls.Add(this.textBoxSaler);
            this.Controls.Add(this.textBoxAvailItem);
            this.Controls.Add(this.textBoxPriceItem);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.textBoxNameItem);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdditem);
            this.Controls.Add(this.dataGridViewFood);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBuy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Общее положение товаров";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBuy_FormClosing);
            this.Load += new System.EventHandler(this.FormBuy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.DataGridView dataGridViewFood;
        private System.Windows.Forms.Button buttonAdditem;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.TextBox textBoxNameItem;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.TextBox textBoxPriceItem;
        private System.Windows.Forms.TextBox textBoxAvailItem;
        private System.Windows.Forms.TextBox textBoxSaler;
        private System.Windows.Forms.Label labelNameI;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelAvail;
        private System.Windows.Forms.Label labelSaler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonWrittenOf;
        private System.Windows.Forms.Label labelabv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSearchArt;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ComboBox comboBoxCond;
        private System.Windows.Forms.Button buttonAuc;
    }
}