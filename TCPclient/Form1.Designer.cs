namespace TCP_chat
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonsend = new System.Windows.Forms.Button();
            this.buttonconnect = new System.Windows.Forms.Button();
            this.textip = new System.Windows.Forms.TextBox();
            this.textinf = new System.Windows.Forms.TextBox();
            this.textmessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(110, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // buttonsend
            // 
            this.buttonsend.Location = new System.Drawing.Point(521, 375);
            this.buttonsend.Name = "buttonsend";
            this.buttonsend.Size = new System.Drawing.Size(91, 63);
            this.buttonsend.TabIndex = 1;
            this.buttonsend.Text = "Send";
            this.buttonsend.UseVisualStyleBackColor = true;
            this.buttonsend.Click += new System.EventHandler(this.buttonsend_Click);
            // 
            // buttonconnect
            // 
            this.buttonconnect.Location = new System.Drawing.Point(652, 376);
            this.buttonconnect.Name = "buttonconnect";
            this.buttonconnect.Size = new System.Drawing.Size(91, 61);
            this.buttonconnect.TabIndex = 2;
            this.buttonconnect.Text = "Connect";
            this.buttonconnect.UseVisualStyleBackColor = true;
            this.buttonconnect.Click += new System.EventHandler(this.buttonconnect_Click);
            // 
            // textip
            // 
            this.textip.Location = new System.Drawing.Point(227, 69);
            this.textip.Multiline = true;
            this.textip.Name = "textip";
            this.textip.Size = new System.Drawing.Size(516, 43);
            this.textip.TabIndex = 3;
            this.textip.Text = "172.20.11.234";
            // 
            // textinf
            // 
            this.textinf.Location = new System.Drawing.Point(227, 128);
            this.textinf.Multiline = true;
            this.textinf.Name = "textinf";
            this.textinf.ReadOnly = true;
            this.textinf.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textinf.Size = new System.Drawing.Size(516, 129);
            this.textinf.TabIndex = 4;
            this.textinf.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textmessage
            // 
            this.textmessage.Location = new System.Drawing.Point(227, 283);
            this.textmessage.Multiline = true;
            this.textmessage.Name = "textmessage";
            this.textmessage.Size = new System.Drawing.Size(516, 43);
            this.textmessage.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(91, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textmessage);
            this.Controls.Add(this.textinf);
            this.Controls.Add(this.textip);
            this.Controls.Add(this.buttonconnect);
            this.Controls.Add(this.buttonsend);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonsend;
        private System.Windows.Forms.Button buttonconnect;
        private System.Windows.Forms.TextBox textip;
        private System.Windows.Forms.TextBox textinf;
        private System.Windows.Forms.TextBox textmessage;
        private System.Windows.Forms.Label label2;
    }
}

