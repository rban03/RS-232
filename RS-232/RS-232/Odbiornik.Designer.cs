namespace RS_232
{
    partial class Odbiornik
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
            this.binaryTxT = new System.Windows.Forms.TextBox();
            this.finalTxt = new System.Windows.Forms.TextBox();
            this.cnv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // binaryTxT
            // 
            this.binaryTxT.Location = new System.Drawing.Point(15, 65);
            this.binaryTxT.Multiline = true;
            this.binaryTxT.Name = "binaryTxT";
            this.binaryTxT.ReadOnly = true;
            this.binaryTxT.Size = new System.Drawing.Size(300, 100);
            this.binaryTxT.TabIndex = 0;
            this.binaryTxT.TextChanged += new System.EventHandler(this.binaryTxT_TextChanged);
            // 
            // finalTxt
            // 
            this.finalTxt.Location = new System.Drawing.Point(15, 304);
            this.finalTxt.Multiline = true;
            this.finalTxt.Name = "finalTxt";
            this.finalTxt.ReadOnly = true;
            this.finalTxt.Size = new System.Drawing.Size(300, 100);
            this.finalTxt.TabIndex = 1;
            // 
            // cnv
            // 
            this.cnv.Location = new System.Drawing.Point(109, 183);
            this.cnv.Name = "cnv";
            this.cnv.Size = new System.Drawing.Size(83, 25);
            this.cnv.TabIndex = 2;
            this.cnv.Text = "Konwertuj";
            this.cnv.UseVisualStyleBackColor = true;
            this.cnv.Click += new System.EventHandler(this.cnv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Przesłane słowo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Orginalne słowo";
            // 
            // Odbiornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cnv);
            this.Controls.Add(this.finalTxt);
            this.Controls.Add(this.binaryTxT);
            this.Name = "Odbiornik";
            this.Text = "Odbiornik";
            this.Load += new System.EventHandler(this.Odbiornik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public TextBox binaryTxT;
        private Button cnv;
        private TextBox finalTxt;
        private Label label1;
        private Label label2;
    }
}