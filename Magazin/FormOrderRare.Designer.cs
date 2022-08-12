namespace Magazin
{
    partial class FormOrderRare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrderRare));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewRareOn = new System.Windows.Forms.DataGridView();
            this.buttonAccpet = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNameUser = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrise = new System.Windows.Forms.TextBox();
            this.textBoxNameItem = new System.Windows.Forms.TextBox();
            this.textBoxCound = new System.Windows.Forms.TextBox();
            this.textBoxStartPrice = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRareOn)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(685, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewRareOn
            // 
            this.dataGridViewRareOn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRareOn.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewRareOn.Name = "dataGridViewRareOn";
            this.dataGridViewRareOn.Size = new System.Drawing.Size(556, 426);
            this.dataGridViewRareOn.TabIndex = 1;
            this.dataGridViewRareOn.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewRareOn_MouseDoubleClick);
            // 
            // buttonAccpet
            // 
            this.buttonAccpet.Location = new System.Drawing.Point(606, 216);
            this.buttonAccpet.Name = "buttonAccpet";
            this.buttonAccpet.Size = new System.Drawing.Size(108, 31);
            this.buttonAccpet.TabIndex = 2;
            this.buttonAccpet.Text = "Отправить заявку";
            this.buttonAccpet.UseVisualStyleBackColor = true;
            this.buttonAccpet.Click += new System.EventHandler(this.buttonAccpet_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(574, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(104, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Введите ваше имя:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(574, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите ваш номер телефона:";
            // 
            // textBoxNameUser
            // 
            this.textBoxNameUser.Location = new System.Drawing.Point(577, 28);
            this.textBoxNameUser.Name = "textBoxNameUser";
            this.textBoxNameUser.Size = new System.Drawing.Size(159, 20);
            this.textBoxNameUser.TabIndex = 5;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(577, 101);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(159, 20);
            this.textBoxNumber.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Введите вашу цену:";
            // 
            // textBoxPrise
            // 
            this.textBoxPrise.Location = new System.Drawing.Point(574, 170);
            this.textBoxPrise.Name = "textBoxPrise";
            this.textBoxPrise.Size = new System.Drawing.Size(159, 20);
            this.textBoxPrise.TabIndex = 8;
            // 
            // textBoxNameItem
            // 
            this.textBoxNameItem.Location = new System.Drawing.Point(574, 274);
            this.textBoxNameItem.Name = "textBoxNameItem";
            this.textBoxNameItem.Size = new System.Drawing.Size(28, 20);
            this.textBoxNameItem.TabIndex = 9;
            this.textBoxNameItem.Visible = false;
            // 
            // textBoxCound
            // 
            this.textBoxCound.Location = new System.Drawing.Point(574, 300);
            this.textBoxCound.Name = "textBoxCound";
            this.textBoxCound.Size = new System.Drawing.Size(28, 20);
            this.textBoxCound.TabIndex = 10;
            this.textBoxCound.Visible = false;
            // 
            // textBoxStartPrice
            // 
            this.textBoxStartPrice.Location = new System.Drawing.Point(574, 326);
            this.textBoxStartPrice.Name = "textBoxStartPrice";
            this.textBoxStartPrice.Size = new System.Drawing.Size(28, 20);
            this.textBoxStartPrice.TabIndex = 11;
            this.textBoxStartPrice.Visible = false;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(574, 352);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(28, 20);
            this.textBoxId.TabIndex = 12;
            this.textBoxId.Visible = false;
            // 
            // FormOrderRare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxStartPrice);
            this.Controls.Add(this.textBoxCound);
            this.Controls.Add(this.textBoxNameItem);
            this.Controls.Add(this.textBoxPrise);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.textBoxNameUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonAccpet);
            this.Controls.Add(this.dataGridViewRareOn);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOrderRare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оставьте заявку на аукцион";
            this.Load += new System.EventHandler(this.FormOrderRare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRareOn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewRareOn;
        private System.Windows.Forms.Button buttonAccpet;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNameUser;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrise;
        private System.Windows.Forms.TextBox textBoxNameItem;
        private System.Windows.Forms.TextBox textBoxCound;
        private System.Windows.Forms.TextBox textBoxStartPrice;
        private System.Windows.Forms.TextBox textBoxId;
    }
}