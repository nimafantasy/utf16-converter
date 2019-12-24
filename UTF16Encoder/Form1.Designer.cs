namespace UTF16Encoder
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlain = new System.Windows.Forms.TextBox();
            this.txtEncoded = new System.Windows.Forms.TextBox();
            this.btnConvertToEncoded = new System.Windows.Forms.Button();
            this.btnConvertToPlain = new System.Windows.Forms.Button();
            this.btnPasteClipboardPlainText = new System.Windows.Forms.Button();
            this.btnPasteClipboardEncoded = new System.Windows.Forms.Button();
            this.btnClearPlain = new System.Windows.Forms.Button();
            this.btnClearEncoded = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plain Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Encoded Text";
            // 
            // txtPlain
            // 
            this.txtPlain.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPlain.Location = new System.Drawing.Point(46, 69);
            this.txtPlain.Name = "txtPlain";
            this.txtPlain.Size = new System.Drawing.Size(950, 36);
            this.txtPlain.TabIndex = 2;
            // 
            // txtEncoded
            // 
            this.txtEncoded.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtEncoded.Location = new System.Drawing.Point(46, 252);
            this.txtEncoded.Name = "txtEncoded";
            this.txtEncoded.Size = new System.Drawing.Size(950, 36);
            this.txtEncoded.TabIndex = 3;
            // 
            // btnConvertToEncoded
            // 
            this.btnConvertToEncoded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnConvertToEncoded.Location = new System.Drawing.Point(46, 134);
            this.btnConvertToEncoded.Name = "btnConvertToEncoded";
            this.btnConvertToEncoded.Size = new System.Drawing.Size(104, 77);
            this.btnConvertToEncoded.TabIndex = 4;
            this.btnConvertToEncoded.Text = "\\/\\/\\/\\/";
            this.btnConvertToEncoded.UseVisualStyleBackColor = true;
            this.btnConvertToEncoded.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnConvertToPlain
            // 
            this.btnConvertToPlain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnConvertToPlain.Location = new System.Drawing.Point(892, 134);
            this.btnConvertToPlain.Name = "btnConvertToPlain";
            this.btnConvertToPlain.Size = new System.Drawing.Size(104, 77);
            this.btnConvertToPlain.TabIndex = 5;
            this.btnConvertToPlain.Text = "/\\/\\/\\/\\";
            this.btnConvertToPlain.UseVisualStyleBackColor = true;
            this.btnConvertToPlain.Click += new System.EventHandler(this.btnConvertToPlain_Click);
            // 
            // btnPasteClipboardPlainText
            // 
            this.btnPasteClipboardPlainText.Location = new System.Drawing.Point(563, 39);
            this.btnPasteClipboardPlainText.Name = "btnPasteClipboardPlainText";
            this.btnPasteClipboardPlainText.Size = new System.Drawing.Size(75, 23);
            this.btnPasteClipboardPlainText.TabIndex = 6;
            this.btnPasteClipboardPlainText.Text = "Paste!";
            this.btnPasteClipboardPlainText.UseVisualStyleBackColor = true;
            this.btnPasteClipboardPlainText.Click += new System.EventHandler(this.btnPasteClipboardPlainText_Click);
            // 
            // btnPasteClipboardEncoded
            // 
            this.btnPasteClipboardEncoded.Location = new System.Drawing.Point(563, 223);
            this.btnPasteClipboardEncoded.Name = "btnPasteClipboardEncoded";
            this.btnPasteClipboardEncoded.Size = new System.Drawing.Size(75, 23);
            this.btnPasteClipboardEncoded.TabIndex = 7;
            this.btnPasteClipboardEncoded.Text = "Paste!";
            this.btnPasteClipboardEncoded.UseVisualStyleBackColor = true;
            this.btnPasteClipboardEncoded.Click += new System.EventHandler(this.btnPasteClipboardEncoded_Click);
            // 
            // btnClearPlain
            // 
            this.btnClearPlain.Location = new System.Drawing.Point(422, 39);
            this.btnClearPlain.Name = "btnClearPlain";
            this.btnClearPlain.Size = new System.Drawing.Size(75, 23);
            this.btnClearPlain.TabIndex = 8;
            this.btnClearPlain.Text = "Clear!";
            this.btnClearPlain.UseVisualStyleBackColor = true;
            this.btnClearPlain.Click += new System.EventHandler(this.btnClearPlain_Click);
            // 
            // btnClearEncoded
            // 
            this.btnClearEncoded.Location = new System.Drawing.Point(402, 223);
            this.btnClearEncoded.Name = "btnClearEncoded";
            this.btnClearEncoded.Size = new System.Drawing.Size(75, 23);
            this.btnClearEncoded.TabIndex = 9;
            this.btnClearEncoded.Text = "Clear!";
            this.btnClearEncoded.UseVisualStyleBackColor = true;
            this.btnClearEncoded.Click += new System.EventHandler(this.btnClearEncoded_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 369);
            this.Controls.Add(this.btnClearEncoded);
            this.Controls.Add(this.btnClearPlain);
            this.Controls.Add(this.btnPasteClipboardEncoded);
            this.Controls.Add(this.btnPasteClipboardPlainText);
            this.Controls.Add(this.btnConvertToPlain);
            this.Controls.Add(this.btnConvertToEncoded);
            this.Controls.Add(this.txtEncoded);
            this.Controls.Add(this.txtPlain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlain;
        private System.Windows.Forms.TextBox txtEncoded;
        private System.Windows.Forms.Button btnConvertToEncoded;
        private System.Windows.Forms.Button btnConvertToPlain;
        private System.Windows.Forms.Button btnPasteClipboardPlainText;
        private System.Windows.Forms.Button btnPasteClipboardEncoded;
        private System.Windows.Forms.Button btnClearPlain;
        private System.Windows.Forms.Button btnClearEncoded;
    }
}

