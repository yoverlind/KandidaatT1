namespace KandidaatT1
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
            this.btn_Verbindk8055 = new System.Windows.Forms.Button();
            this.TimeLeesInputs = new System.Windows.Forms.Timer(this.components);
            this.lblCon = new System.Windows.Forms.Label();
            this.lblVragen = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtVraag = new System.Windows.Forms.TextBox();
            this.txtAntwoord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerzend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGedrukt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Verbindk8055
            // 
            this.btn_Verbindk8055.Location = new System.Drawing.Point(23, 22);
            this.btn_Verbindk8055.Name = "btn_Verbindk8055";
            this.btn_Verbindk8055.Size = new System.Drawing.Size(118, 31);
            this.btn_Verbindk8055.TabIndex = 0;
            this.btn_Verbindk8055.Text = "Verbind met k8055";
            this.btn_Verbindk8055.UseVisualStyleBackColor = true;
            this.btn_Verbindk8055.Click += new System.EventHandler(this.btn_Verbindk8055_Click);
            // 
            // TimeLeesInputs
            // 
            this.TimeLeesInputs.Interval = 20;
            this.TimeLeesInputs.Tick += new System.EventHandler(this.TimeLeesInputs_Tick);
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Location = new System.Drawing.Point(24, 57);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(0, 13);
            this.lblCon.TabIndex = 1;
            // 
            // lblVragen
            // 
            this.lblVragen.AutoSize = true;
            this.lblVragen.Location = new System.Drawing.Point(24, 85);
            this.lblVragen.Name = "lblVragen";
            this.lblVragen.Size = new System.Drawing.Size(118, 13);
            this.lblVragen.TabIndex = 2;
            this.lblVragen.Text = "Hier komt de kwisvraag";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "verbreek";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // txtVraag
            // 
            this.txtVraag.Location = new System.Drawing.Point(27, 112);
            this.txtVraag.Multiline = true;
            this.txtVraag.Name = "txtVraag";
            this.txtVraag.ReadOnly = true;
            this.txtVraag.Size = new System.Drawing.Size(282, 98);
            this.txtVraag.TabIndex = 7;
            // 
            // txtAntwoord
            // 
            this.txtAntwoord.Location = new System.Drawing.Point(27, 241);
            this.txtAntwoord.Name = "txtAntwoord";
            this.txtAntwoord.Size = new System.Drawing.Size(105, 20);
            this.txtAntwoord.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Voer een antwoord in";
            // 
            // btnVerzend
            // 
            this.btnVerzend.Location = new System.Drawing.Point(236, 310);
            this.btnVerzend.Name = "btnVerzend";
            this.btnVerzend.Size = new System.Drawing.Size(73, 59);
            this.btnVerzend.TabIndex = 10;
            this.btnVerzend.Text = "verzend";
            this.btnVerzend.UseVisualStyleBackColor = true;
            this.btnVerzend.Click += new System.EventHandler(this.btnVerzend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "u hebt gedrukt :";
            // 
            // lblGedrukt
            // 
            this.lblGedrukt.AutoSize = true;
            this.lblGedrukt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGedrukt.Location = new System.Drawing.Point(59, 318);
            this.lblGedrukt.Name = "lblGedrukt";
            this.lblGedrukt.Size = new System.Drawing.Size(0, 24);
            this.lblGedrukt.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 386);
            this.Controls.Add(this.lblGedrukt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVerzend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAntwoord);
            this.Controls.Add(this.txtVraag);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblVragen);
            this.Controls.Add(this.lblCon);
            this.Controls.Add(this.btn_Verbindk8055);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Verbindk8055;
        private System.Windows.Forms.Timer TimeLeesInputs;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.Label lblVragen;
        private System.Windows.Forms.Button button1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txtVraag;
        private System.Windows.Forms.TextBox txtAntwoord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerzend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGedrukt;
    }
}

