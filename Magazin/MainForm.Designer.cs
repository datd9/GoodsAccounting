namespace Magazin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonRare = new System.Windows.Forms.Button();
            this.buttonItemOn = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.buttonWrittenOf = new System.Windows.Forms.Button();
            this.buttonCheckOrdBuy = new System.Windows.Forms.Button();
            this.buttonAccOrdBuy = new System.Windows.Forms.Button();
            this.buttonAucOrd = new System.Windows.Forms.Button();
            this.buttonChowAcAuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(197, 251);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(139, 34);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(197, 91);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(139, 34);
            this.buttonBuy.TabIndex = 11;
            this.buttonBuy.Text = "Общий список обычных товаров";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // buttonRare
            // 
            this.buttonRare.Location = new System.Drawing.Point(195, 44);
            this.buttonRare.Name = "buttonRare";
            this.buttonRare.Size = new System.Drawing.Size(140, 41);
            this.buttonRare.TabIndex = 14;
            this.buttonRare.Text = "Список аукционных товаров";
            this.buttonRare.UseVisualStyleBackColor = true;
            this.buttonRare.Click += new System.EventHandler(this.buttonRare_Click);
            // 
            // buttonItemOn
            // 
            this.buttonItemOn.Location = new System.Drawing.Point(197, 132);
            this.buttonItemOn.Name = "buttonItemOn";
            this.buttonItemOn.Size = new System.Drawing.Size(140, 40);
            this.buttonItemOn.TabIndex = 15;
            this.buttonItemOn.Text = "Товары, которые есть в наличие";
            this.buttonItemOn.UseVisualStyleBackColor = true;
            this.buttonItemOn.Click += new System.EventHandler(this.buttonItemOn_Click);
            // 
            // buttonOrders
            // 
            this.buttonOrders.Location = new System.Drawing.Point(12, 45);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(140, 40);
            this.buttonOrders.TabIndex = 16;
            this.buttonOrders.Text = "Список заявок на продажу";
            this.buttonOrders.UseVisualStyleBackColor = true;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // buttonWrittenOf
            // 
            this.buttonWrittenOf.Location = new System.Drawing.Point(197, 178);
            this.buttonWrittenOf.Name = "buttonWrittenOf";
            this.buttonWrittenOf.Size = new System.Drawing.Size(139, 43);
            this.buttonWrittenOf.TabIndex = 17;
            this.buttonWrittenOf.Text = "Отобразить списанный на переоценку товар";
            this.buttonWrittenOf.UseVisualStyleBackColor = true;
            this.buttonWrittenOf.Click += new System.EventHandler(this.buttonWrittenOf_Click);
            // 
            // buttonCheckOrdBuy
            // 
            this.buttonCheckOrdBuy.Location = new System.Drawing.Point(12, 91);
            this.buttonCheckOrdBuy.Name = "buttonCheckOrdBuy";
            this.buttonCheckOrdBuy.Size = new System.Drawing.Size(140, 34);
            this.buttonCheckOrdBuy.TabIndex = 18;
            this.buttonCheckOrdBuy.Text = "Список заявок на покупку";
            this.buttonCheckOrdBuy.UseVisualStyleBackColor = true;
            this.buttonCheckOrdBuy.Click += new System.EventHandler(this.buttonCheckOrdBuy_Click);
            // 
            // buttonAccOrdBuy
            // 
            this.buttonAccOrdBuy.Location = new System.Drawing.Point(369, 45);
            this.buttonAccOrdBuy.Name = "buttonAccOrdBuy";
            this.buttonAccOrdBuy.Size = new System.Drawing.Size(140, 40);
            this.buttonAccOrdBuy.TabIndex = 19;
            this.buttonAccOrdBuy.Text = "Отобразить успешные заказы";
            this.buttonAccOrdBuy.UseVisualStyleBackColor = true;
            this.buttonAccOrdBuy.Click += new System.EventHandler(this.buttonAccOrdBuy_Click);
            // 
            // buttonAucOrd
            // 
            this.buttonAucOrd.Location = new System.Drawing.Point(12, 138);
            this.buttonAucOrd.Name = "buttonAucOrd";
            this.buttonAucOrd.Size = new System.Drawing.Size(140, 34);
            this.buttonAucOrd.TabIndex = 20;
            this.buttonAucOrd.Text = "Список заявок на аукцион";
            this.buttonAucOrd.UseVisualStyleBackColor = true;
            this.buttonAucOrd.Click += new System.EventHandler(this.buttonAucOrd_Click);
            // 
            // buttonChowAcAuc
            // 
            this.buttonChowAcAuc.Location = new System.Drawing.Point(369, 91);
            this.buttonChowAcAuc.Name = "buttonChowAcAuc";
            this.buttonChowAcAuc.Size = new System.Drawing.Size(140, 38);
            this.buttonChowAcAuc.TabIndex = 21;
            this.buttonChowAcAuc.Text = "Отобразить завершенные аукционы";
            this.buttonChowAcAuc.UseVisualStyleBackColor = true;
            this.buttonChowAcAuc.Click += new System.EventHandler(this.buttonChowAcAuc_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 302);
            this.Controls.Add(this.buttonChowAcAuc);
            this.Controls.Add(this.buttonAucOrd);
            this.Controls.Add(this.buttonAccOrdBuy);
            this.Controls.Add(this.buttonCheckOrdBuy);
            this.Controls.Add(this.buttonWrittenOf);
            this.Controls.Add(this.buttonOrders);
            this.Controls.Add(this.buttonItemOn);
            this.Controls.Add(this.buttonRare);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.buttonExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно администратора";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Button buttonRare;
        private System.Windows.Forms.Button buttonItemOn;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Button buttonWrittenOf;
        private System.Windows.Forms.Button buttonCheckOrdBuy;
        private System.Windows.Forms.Button buttonAccOrdBuy;
        private System.Windows.Forms.Button buttonAucOrd;
        private System.Windows.Forms.Button buttonChowAcAuc;
    }
}

