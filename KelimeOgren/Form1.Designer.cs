namespace KelimeOgren
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            txtİngilizce = new TextBox();
            txtTurkce = new TextBox();
            label3 = new Label();
            lblSure = new Label();
            label5 = new Label();
            lblKelime = new Label();
            lblCevap = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 29);
            label1.Name = "label1";
            label1.Size = new Size(79, 18);
            label1.TabIndex = 0;
            label1.Text = "İngilizce : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 79);
            label2.Name = "label2";
            label2.Size = new Size(72, 18);
            label2.TabIndex = 1;
            label2.Text = "Türkçe : ";
            // 
            // txtİngilizce
            // 
            txtİngilizce.Location = new Point(116, 26);
            txtİngilizce.Name = "txtİngilizce";
            txtİngilizce.Size = new Size(184, 26);
            txtİngilizce.TabIndex = 10;
            // 
            // txtTurkce
            // 
            txtTurkce.Location = new Point(116, 76);
            txtTurkce.Name = "txtTurkce";
            txtTurkce.Size = new Size(184, 26);
            txtTurkce.TabIndex = 1;
            txtTurkce.TextChanged += txtTurkce_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(441, 29);
            label3.Name = "label3";
            label3.Size = new Size(54, 18);
            label3.TabIndex = 4;
            label3.Text = "Süre : ";
            // 
            // lblSure
            // 
            lblSure.AutoSize = true;
            lblSure.Location = new Point(513, 29);
            lblSure.Name = "lblSure";
            lblSure.Size = new Size(27, 18);
            lblSure.TabIndex = 5;
            lblSure.Text = "90";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(437, 87);
            label5.Name = "label5";
            label5.Size = new Size(70, 18);
            label5.TabIndex = 6;
            label5.Text = "Kelime : ";
            // 
            // lblKelime
            // 
            lblKelime.AutoSize = true;
            lblKelime.Location = new Point(513, 83);
            lblKelime.Name = "lblKelime";
            lblKelime.Size = new Size(18, 18);
            lblKelime.TabIndex = 7;
            lblKelime.Text = "0";
            // 
            // lblCevap
            // 
            lblCevap.AutoSize = true;
            lblCevap.Location = new Point(333, 106);
            lblCevap.Name = "lblCevap";
            lblCevap.Size = new Size(50, 18);
            lblCevap.TabIndex = 8;
            lblCevap.Text = "label4";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 151);
            Controls.Add(lblCevap);
            Controls.Add(lblKelime);
            Controls.Add(label5);
            Controls.Add(lblSure);
            Controls.Add(label3);
            Controls.Add(txtTurkce);
            Controls.Add(txtİngilizce);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtİngilizce;
        private TextBox txtTurkce;
        private Label label3;
        private Label lblSure;
        private Label label5;
        private Label lblKelime;
        private Label lblCevap;
        private System.Windows.Forms.Timer timer1;
    }
}
