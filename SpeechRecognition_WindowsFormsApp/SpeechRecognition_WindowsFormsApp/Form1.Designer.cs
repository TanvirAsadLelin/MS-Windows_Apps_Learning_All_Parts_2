namespace SpeechRecognition_WindowsFormsApp
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
            this.textBoxTtoS = new System.Windows.Forms.TextBox();
            this.btnTtoS = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStoT = new System.Windows.Forms.TextBox();
            this.btnStoT = new System.Windows.Forms.Button();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Speech Recognition Application";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Text to Speech";
            // 
            // textBoxTtoS
            // 
            this.textBoxTtoS.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTtoS.Location = new System.Drawing.Point(57, 166);
            this.textBoxTtoS.Multiline = true;
            this.textBoxTtoS.Name = "textBoxTtoS";
            this.textBoxTtoS.Size = new System.Drawing.Size(479, 279);
            this.textBoxTtoS.TabIndex = 2;
            // 
            // btnTtoS
            // 
            this.btnTtoS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTtoS.Location = new System.Drawing.Point(59, 466);
            this.btnTtoS.Name = "btnTtoS";
            this.btnTtoS.Size = new System.Drawing.Size(179, 34);
            this.btnTtoS.TabIndex = 3;
            this.btnTtoS.Text = "Click for Listen";
            this.btnTtoS.UseVisualStyleBackColor = true;
            this.btnTtoS.Click += new System.EventHandler(this.btnTtoS_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(640, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Speech to Text";
            // 
            // textBoxStoT
            // 
            this.textBoxStoT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStoT.Location = new System.Drawing.Point(644, 166);
            this.textBoxStoT.Multiline = true;
            this.textBoxStoT.Name = "textBoxStoT";
            this.textBoxStoT.Size = new System.Drawing.Size(479, 279);
            this.textBoxStoT.TabIndex = 2;
            // 
            // btnStoT
            // 
            this.btnStoT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStoT.Location = new System.Drawing.Point(646, 466);
            this.btnStoT.Name = "btnStoT";
            this.btnStoT.Size = new System.Drawing.Size(179, 34);
            this.btnStoT.TabIndex = 3;
            this.btnStoT.Text = "Click for Read";
            this.btnStoT.UseVisualStyleBackColor = true;
            this.btnStoT.Click += new System.EventHandler(this.btnStoT_Click);
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(571, 543);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(199, 56);
            this.trackBar.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(466, 543);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Volume";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 611);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.btnStoT);
            this.Controls.Add(this.btnTtoS);
            this.Controls.Add(this.textBoxStoT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTtoS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Speech Recognition";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTtoS;
        private System.Windows.Forms.Button btnTtoS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStoT;
        private System.Windows.Forms.Button btnStoT;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label label4;
    }
}

