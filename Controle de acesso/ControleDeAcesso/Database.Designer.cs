namespace ControleDeAcesso
{
	partial class frmDatabase
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatabase));
			this.txtIp = new System.Windows.Forms.TextBox();
			this.txtPorta = new System.Windows.Forms.TextBox();
			this.lblIP = new System.Windows.Forms.Label();
			this.lblPort = new System.Windows.Forms.Label();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.pctLogo = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// txtIp
			// 
			this.txtIp.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtIp.Location = new System.Drawing.Point(85, 118);
			this.txtIp.Name = "txtIp";
			this.txtIp.Size = new System.Drawing.Size(100, 20);
			this.txtIp.TabIndex = 0;
			// 
			// txtPorta
			// 
			this.txtPorta.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPorta.Location = new System.Drawing.Point(85, 166);
			this.txtPorta.Name = "txtPorta";
			this.txtPorta.Size = new System.Drawing.Size(100, 20);
			this.txtPorta.TabIndex = 1;
			// 
			// lblIP
			// 
			this.lblIP.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblIP.AutoSize = true;
			this.lblIP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIP.ForeColor = System.Drawing.Color.Navy;
			this.lblIP.Location = new System.Drawing.Point(35, 121);
			this.lblIP.Name = "lblIP";
			this.lblIP.Size = new System.Drawing.Size(20, 15);
			this.lblIP.TabIndex = 2;
			this.lblIP.Text = "IP";
			// 
			// lblPort
			// 
			this.lblPort.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblPort.AutoSize = true;
			this.lblPort.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPort.ForeColor = System.Drawing.Color.Navy;
			this.lblPort.Location = new System.Drawing.Point(35, 169);
			this.lblPort.Name = "lblPort";
			this.lblPort.Size = new System.Drawing.Size(43, 15);
			this.lblPort.TabIndex = 3;
			this.lblPort.Text = "Porta";
			// 
			// btnSalvar
			// 
			this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnSalvar.BackColor = System.Drawing.Color.Navy;
			this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSalvar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvar.ForeColor = System.Drawing.Color.White;
			this.btnSalvar.Location = new System.Drawing.Point(38, 213);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(147, 23);
			this.btnSalvar.TabIndex = 4;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = false;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// pctLogo
			// 
			this.pctLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
			this.pctLogo.Location = new System.Drawing.Point(50, 22);
			this.pctLogo.Name = "pctLogo";
			this.pctLogo.Size = new System.Drawing.Size(135, 71);
			this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctLogo.TabIndex = 5;
			this.pctLogo.TabStop = false;
			// 
			// frmDatabase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(232, 264);
			this.Controls.Add(this.pctLogo);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.lblPort);
			this.Controls.Add(this.lblIP);
			this.Controls.Add(this.txtPorta);
			this.Controls.Add(this.txtIp);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmDatabase";
			this.Text = "Database";
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtIp;
		private System.Windows.Forms.TextBox txtPorta;
		private System.Windows.Forms.Label lblIP;
		private System.Windows.Forms.Label lblPort;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.PictureBox pctLogo;
	}
}