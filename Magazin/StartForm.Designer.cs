namespace Magazin
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.buttonAdm = new System.Windows.Forms.Button();
            this.buttonEx = new System.Windows.Forms.Button();
            this.buttonCl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdm
            // 
            this.buttonAdm.Location = new System.Drawing.Point(214, 55);
            this.buttonAdm.Name = "buttonAdm";
            this.buttonAdm.Size = new System.Drawing.Size(114, 79);
            this.buttonAdm.TabIndex = 0;
            this.buttonAdm.Text = "Войти как администратор";
            this.buttonAdm.UseVisualStyleBackColor = true;
            this.buttonAdm.Click += new System.EventHandler(this.buttonAdm_Click);
            // 
            // buttonEx
            // 
            this.buttonEx.Location = new System.Drawing.Point(116, 176);
            this.buttonEx.Name = "buttonEx";
            this.buttonEx.Size = new System.Drawing.Size(80, 26);
            this.buttonEx.TabIndex = 1;
            this.buttonEx.Text = "Выйти";
            this.buttonEx.UseVisualStyleBackColor = true;
            this.buttonEx.Click += new System.EventHandler(this.buttonEx_Click);
            // 
            // buttonCl
            // 
            this.buttonCl.Location = new System.Drawing.Point(12, 55);
            this.buttonCl.Name = "buttonCl";
            this.buttonCl.Size = new System.Drawing.Size(114, 79);
            this.buttonCl.TabIndex = 2;
            this.buttonCl.Text = "Войти как пользователь";
            this.buttonCl.UseVisualStyleBackColor = true;
            this.buttonCl.Click += new System.EventHandler(this.buttonCl_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 212);
            this.Controls.Add(this.buttonCl);
            this.Controls.Add(this.buttonEx);
            this.Controls.Add(this.buttonAdm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выберете тип пользователя";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdm;
        private System.Windows.Forms.Button buttonEx;
        private System.Windows.Forms.Button buttonCl;
    }
}