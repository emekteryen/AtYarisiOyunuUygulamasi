namespace AtYarisi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pctMavi = new System.Windows.Forms.PictureBox();
            this.pctPembe = new System.Windows.Forms.PictureBox();
            this.lblFinish = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctMavi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPembe)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(681, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Veli Efendi Hipodromu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 43);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pctMavi
            // 
            this.pctMavi.Image = ((System.Drawing.Image)(resources.GetObject("pctMavi.Image")));
            this.pctMavi.Location = new System.Drawing.Point(12, 72);
            this.pctMavi.Name = "pctMavi";
            this.pctMavi.Size = new System.Drawing.Size(100, 50);
            this.pctMavi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMavi.TabIndex = 2;
            this.pctMavi.TabStop = false;
            // 
            // pctPembe
            // 
            this.pctPembe.Image = ((System.Drawing.Image)(resources.GetObject("pctPembe.Image")));
            this.pctPembe.Location = new System.Drawing.Point(12, 128);
            this.pctPembe.Name = "pctPembe";
            this.pctPembe.Size = new System.Drawing.Size(100, 50);
            this.pctPembe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPembe.TabIndex = 3;
            this.pctPembe.TabStop = false;
            // 
            // lblFinish
            // 
            this.lblFinish.BackColor = System.Drawing.Color.Red;
            this.lblFinish.Location = new System.Drawing.Point(591, 43);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(13, 209);
            this.lblFinish.TabIndex = 4;
            this.lblFinish.Text = "F I N I S H";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(681, 261);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.pctPembe);
            this.Controls.Add(this.pctMavi);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctMavi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPembe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pctMavi;
        private System.Windows.Forms.PictureBox pctPembe;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Timer timer1;
    }
}

