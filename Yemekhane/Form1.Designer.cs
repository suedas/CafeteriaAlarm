
namespace Yemekhane
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.saveBtn = new System.Windows.Forms.Button();
            this.startRing = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.stopRing = new System.Windows.Forms.Button();
            this.infoTxt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.YemekhaneBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DigerBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YemekhaneBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DigerBar)).BeginInit();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(39, 190);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(200, 100);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "KAYDET";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // startRing
            // 
            this.startRing.Location = new System.Drawing.Point(283, 190);
            this.startRing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startRing.Name = "startRing";
            this.startRing.Size = new System.Drawing.Size(200, 100);
            this.startRing.TabIndex = 9;
            this.startRing.Text = "BAŞLANGIÇ SESİ";
            this.startRing.UseVisualStyleBackColor = true;
            this.startRing.Click += new System.EventHandler(this.startRing_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(39, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(211, 108);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yemek Saati";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "hh:mm:tt";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(32, 47);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 22);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.Value = new System.DateTime(2021, 6, 28, 12, 0, 0, 0);
            // 
            // stopRing
            // 
            this.stopRing.Location = new System.Drawing.Point(283, 318);
            this.stopRing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopRing.Name = "stopRing";
            this.stopRing.Size = new System.Drawing.Size(200, 100);
            this.stopRing.TabIndex = 15;
            this.stopRing.Text = "BİTİŞ SESİ";
            this.stopRing.UseVisualStyleBackColor = true;
            this.stopRing.Click += new System.EventHandler(this.stopRing_Click);
            // 
            // infoTxt
            // 
            this.infoTxt.AutoSize = true;
            this.infoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.infoTxt.ForeColor = System.Drawing.Color.Crimson;
            this.infoTxt.Location = new System.Drawing.Point(268, 37);
            this.infoTxt.Name = "infoTxt";
            this.infoTxt.Size = new System.Drawing.Size(224, 25);
            this.infoTxt.TabIndex = 16;
            this.infoTxt.Text = "ALARM KURULMADI!";
            this.infoTxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(39, 318);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 100);
            this.button1.TabIndex = 17;
            this.button1.Text = "SIFIRLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // YemekhaneBar
            // 
            this.YemekhaneBar.Location = new System.Drawing.Point(39, 463);
            this.YemekhaneBar.Maximum = 20;
            this.YemekhaneBar.Name = "YemekhaneBar";
            this.YemekhaneBar.Size = new System.Drawing.Size(444, 56);
            this.YemekhaneBar.TabIndex = 18;
            this.YemekhaneBar.Value = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Uygulama Maksimum Ses Seviyesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 537);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Diğer Uygulamaların Maksimum Ses Seviyesi";
            // 
            // DigerBar
            // 
            this.DigerBar.Location = new System.Drawing.Point(39, 560);
            this.DigerBar.Maximum = 20;
            this.DigerBar.Name = "DigerBar";
            this.DigerBar.Size = new System.Drawing.Size(444, 56);
            this.DigerBar.TabIndex = 20;
            this.DigerBar.Value = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 501);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 501);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "50";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 599);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "50";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(451, 599);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "100";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 599);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 655);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DigerBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YemekhaneBar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.infoTxt);
            this.Controls.Add(this.stopRing);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.startRing);
            this.Controls.Add(this.saveBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Yemekhane Alarm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.YemekhaneBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DigerBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button startRing;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button stopRing;
        private System.Windows.Forms.Label infoTxt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar YemekhaneBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar DigerBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

