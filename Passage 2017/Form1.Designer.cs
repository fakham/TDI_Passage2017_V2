namespace Passage_2017
{
    partial class Form1
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
            this.button_Supprimer = new System.Windows.Forms.Button();
            this.button_Enregistrer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Supprimer
            // 
            this.button_Supprimer.Location = new System.Drawing.Point(166, 94);
            this.button_Supprimer.Name = "button_Supprimer";
            this.button_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.button_Supprimer.TabIndex = 0;
            this.button_Supprimer.Text = "Supprimer";
            this.button_Supprimer.UseVisualStyleBackColor = true;
            this.button_Supprimer.Click += new System.EventHandler(this.button_Supprimer_Click);
            // 
            // button_Enregistrer
            // 
            this.button_Enregistrer.Location = new System.Drawing.Point(318, 94);
            this.button_Enregistrer.Name = "button_Enregistrer";
            this.button_Enregistrer.Size = new System.Drawing.Size(75, 23);
            this.button_Enregistrer.TabIndex = 1;
            this.button_Enregistrer.Text = "Enregistrer";
            this.button_Enregistrer.UseVisualStyleBackColor = true;
            this.button_Enregistrer.Click += new System.EventHandler(this.button_Enregistrer_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom complet:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 128);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_Enregistrer);
            this.Controls.Add(this.button_Supprimer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Supprimer;
        private System.Windows.Forms.Button button_Enregistrer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

