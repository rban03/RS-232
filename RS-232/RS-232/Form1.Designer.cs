namespace RS_232
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ASCIITxT = new System.Windows.Forms.TextBox();
            this.binaryTxT = new System.Windows.Forms.TextBox();
            this.cnv = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ASCIITxT
            // 
            this.ASCIITxT.Location = new System.Drawing.Point(15, 65);
            this.ASCIITxT.Multiline = true;
            this.ASCIITxT.Name = "ASCIITxT";
            this.ASCIITxT.Size = new System.Drawing.Size(300, 100);
            this.ASCIITxT.TabIndex = 0;
            this.ASCIITxT.UseWaitCursor = true;
            this.ASCIITxT.TextChanged += new System.EventHandler(this.ASCIITxT_TextChanged);
            // 
            // binaryTxT
            // 
            this.binaryTxT.Location = new System.Drawing.Point(12, 296);
            this.binaryTxT.Multiline = true;
            this.binaryTxT.Name = "binaryTxT";
            this.binaryTxT.ReadOnly = true;
            this.binaryTxT.Size = new System.Drawing.Size(300, 100);
            this.binaryTxT.TabIndex = 1;
            this.binaryTxT.TextChanged += new System.EventHandler(this.binaryTxT_TextChanged);
            // 
            // cnv
            // 
            this.cnv.Location = new System.Drawing.Point(115, 171);
            this.cnv.Name = "cnv";
            this.cnv.Size = new System.Drawing.Size(83, 25);
            this.cnv.TabIndex = 2;
            this.cnv.Text = "Konwertuj";
            this.cnv.UseCompatibleTextRendering = true;
            this.cnv.UseVisualStyleBackColor = true;
            this.cnv.Click += new System.EventHandler(this.cnv_Click);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(115, 413);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(83, 25);
            this.send.TabIndex = 3;
            this.send.Text = "Wyślij";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Podaj słowo ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Słowo binarne";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.send);
            this.Controls.Add(this.cnv);
            this.Controls.Add(this.binaryTxT);
            this.Controls.Add(this.ASCIITxT);
            this.Name = "Form1";
            this.Text = "Nadajnik";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox ASCIITxT;
        private TextBox binaryTxT;
        private Button cnv;
        private Button send;
        private Label label1;
        private Label label2;
    }
}