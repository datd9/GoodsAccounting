namespace Magazin
{
    partial class FormAddRare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddRare));
            this.textBoxNameR = new System.Windows.Forms.TextBox();
            this.comboBoxCondition = new System.Windows.Forms.ComboBox();
            this.textBoxPriceR = new System.Windows.Forms.TextBox();
            this.buttonOkR = new System.Windows.Forms.Button();
            this.buttonCancelR = new System.Windows.Forms.Button();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNameR
            // 
            this.textBoxNameR.Location = new System.Drawing.Point(196, 69);
            this.textBoxNameR.Name = "textBoxNameR";
            this.textBoxNameR.Size = new System.Drawing.Size(204, 20);
            this.textBoxNameR.TabIndex = 0;
            // 
            // comboBoxCondition
            // 
            this.comboBoxCondition.FormattingEnabled = true;
            this.comboBoxCondition.Items.AddRange(new object[] {
            "Отличное",
            "Хорошее",
            "Среднее",
            "Плохое",
            "Очень плохое"});
            this.comboBoxCondition.Location = new System.Drawing.Point(196, 137);
            this.comboBoxCondition.Name = "comboBoxCondition";
            this.comboBoxCondition.Size = new System.Drawing.Size(204, 21);
            this.comboBoxCondition.TabIndex = 1;
            // 
            // textBoxPriceR
            // 
            this.textBoxPriceR.Location = new System.Drawing.Point(196, 213);
            this.textBoxPriceR.Name = "textBoxPriceR";
            this.textBoxPriceR.Size = new System.Drawing.Size(204, 20);
            this.textBoxPriceR.TabIndex = 2;
            // 
            // buttonOkR
            // 
            this.buttonOkR.Location = new System.Drawing.Point(60, 368);
            this.buttonOkR.Name = "buttonOkR";
            this.buttonOkR.Size = new System.Drawing.Size(75, 23);
            this.buttonOkR.TabIndex = 3;
            this.buttonOkR.Text = "Ок";
            this.buttonOkR.UseVisualStyleBackColor = true;
            this.buttonOkR.Click += new System.EventHandler(this.buttonOkR_Click);
            // 
            // buttonCancelR
            // 
            this.buttonCancelR.Location = new System.Drawing.Point(413, 368);
            this.buttonCancelR.Name = "buttonCancelR";
            this.buttonCancelR.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelR.TabIndex = 4;
            this.buttonCancelR.Text = "Отмена";
            this.buttonCancelR.UseVisualStyleBackColor = true;
            this.buttonCancelR.Click += new System.EventHandler(this.buttonCancelR_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(196, 289);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(204, 21);
            this.comboBoxStatus.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите наименование товара:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Выберите тип состояние товара:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введите начальную стоимость товара:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Выберите тип наличия товара:";
            // 
            // FormAddRare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.buttonCancelR);
            this.Controls.Add(this.buttonOkR);
            this.Controls.Add(this.textBoxPriceR);
            this.Controls.Add(this.comboBoxCondition);
            this.Controls.Add(this.textBoxNameR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddRare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление товара";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNameR;
        private System.Windows.Forms.ComboBox comboBoxCondition;
        private System.Windows.Forms.TextBox textBoxPriceR;
        private System.Windows.Forms.Button buttonOkR;
        private System.Windows.Forms.Button buttonCancelR;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}