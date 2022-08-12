namespace Magazin
{
    partial class MainCLForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainCLForm));
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonEx = new System.Windows.Forms.Button();
            this.buttonOpenInv = new System.Windows.Forms.Button();
            this.buttonAuc = new System.Windows.Forms.Button();
            this.buttonOrd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(275, 87);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonEx
            // 
            this.buttonEx.Location = new System.Drawing.Point(5, 87);
            this.buttonEx.Name = "buttonEx";
            this.buttonEx.Size = new System.Drawing.Size(75, 23);
            this.buttonEx.TabIndex = 1;
            this.buttonEx.Text = "Выход";
            this.buttonEx.UseVisualStyleBackColor = true;
            this.buttonEx.Click += new System.EventHandler(this.buttonEx_Click);
            // 
            // buttonOpenInv
            // 
            this.buttonOpenInv.Location = new System.Drawing.Point(239, 12);
            this.buttonOpenInv.Name = "buttonOpenInv";
            this.buttonOpenInv.Size = new System.Drawing.Size(111, 58);
            this.buttonOpenInv.TabIndex = 2;
            this.buttonOpenInv.Text = "Открыть наличие обычного товара";
            this.buttonOpenInv.UseVisualStyleBackColor = true;
            this.buttonOpenInv.Click += new System.EventHandler(this.buttonOpenInv_Click);
            // 
            // buttonAuc
            // 
            this.buttonAuc.Location = new System.Drawing.Point(5, 12);
            this.buttonAuc.Name = "buttonAuc";
            this.buttonAuc.Size = new System.Drawing.Size(114, 58);
            this.buttonAuc.TabIndex = 3;
            this.buttonAuc.Text = "Оставить заявку на аукцион";
            this.buttonAuc.UseVisualStyleBackColor = true;
            this.buttonAuc.Click += new System.EventHandler(this.buttonAuc_Click);
            // 
            // buttonOrd
            // 
            this.buttonOrd.Location = new System.Drawing.Point(125, 12);
            this.buttonOrd.Name = "buttonOrd";
            this.buttonOrd.Size = new System.Drawing.Size(108, 58);
            this.buttonOrd.TabIndex = 4;
            this.buttonOrd.Text = "Оставьте заявку на продажу";
            this.buttonOrd.UseVisualStyleBackColor = true;
            this.buttonOrd.Click += new System.EventHandler(this.buttonOrd_Click);
            // 
            // MainCLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 129);
            this.Controls.Add(this.buttonOrd);
            this.Controls.Add(this.buttonAuc);
            this.Controls.Add(this.buttonOpenInv);
            this.Controls.Add(this.buttonEx);
            this.Controls.Add(this.buttonBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainCLForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Профиль пользователя";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonEx;
        private System.Windows.Forms.Button buttonOpenInv;
        private System.Windows.Forms.Button buttonAuc;
        private System.Windows.Forms.Button buttonOrd;
    }
}