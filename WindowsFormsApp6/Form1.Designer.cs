namespace WindowsFormsApp6
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
            this.k_box = new System.Windows.Forms.TextBox();
            this.m_box = new System.Windows.Forms.TextBox();
            this.wynik_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // k_box
            // 
            this.k_box.Location = new System.Drawing.Point(36, 157);
            this.k_box.Name = "k_box";
            this.k_box.Size = new System.Drawing.Size(100, 26);
            this.k_box.TabIndex = 0;
            // 
            // m_box
            // 
            this.m_box.Location = new System.Drawing.Point(36, 234);
            this.m_box.Name = "m_box";
            this.m_box.Size = new System.Drawing.Size(100, 26);
            this.m_box.TabIndex = 1;
            // 
            // wynik_box
            // 
            this.wynik_box.Location = new System.Drawing.Point(340, 103);
            this.wynik_box.Multiline = true;
            this.wynik_box.Name = "wynik_box";
            this.wynik_box.Size = new System.Drawing.Size(404, 157);
            this.wynik_box.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(404, 99);
            this.button1.TabIndex = 3;
            this.button1.Text = "OBLICZ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Patryk krawczak zadanie 6 c#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "wartosc k";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "wartosc m";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wynik_box);
            this.Controls.Add(this.m_box);
            this.Controls.Add(this.k_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox k_box;
        private System.Windows.Forms.TextBox m_box;
        private System.Windows.Forms.TextBox wynik_box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

