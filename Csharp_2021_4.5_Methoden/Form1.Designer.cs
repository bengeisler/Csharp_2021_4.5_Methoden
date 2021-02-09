
namespace Csharp_2021_4._5_Methoden
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnAnzeige1 = new System.Windows.Forms.Button();
			this.btnAnzeige2 = new System.Windows.Forms.Button();
			this.lblAusgabe = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnAnzeige1
			// 
			this.btnAnzeige1.Location = new System.Drawing.Point(12, 12);
			this.btnAnzeige1.Name = "btnAnzeige1";
			this.btnAnzeige1.Size = new System.Drawing.Size(75, 23);
			this.btnAnzeige1.TabIndex = 0;
			this.btnAnzeige1.Text = "Anzeige 1";
			this.btnAnzeige1.UseVisualStyleBackColor = true;
			this.btnAnzeige1.Click += new System.EventHandler(this.btnAnzeige1_Click);
			// 
			// btnAnzeige2
			// 
			this.btnAnzeige2.Location = new System.Drawing.Point(12, 50);
			this.btnAnzeige2.Name = "btnAnzeige2";
			this.btnAnzeige2.Size = new System.Drawing.Size(75, 23);
			this.btnAnzeige2.TabIndex = 1;
			this.btnAnzeige2.Text = "Anzeige 2";
			this.btnAnzeige2.UseVisualStyleBackColor = true;
			this.btnAnzeige2.Click += new System.EventHandler(this.btnAnzeige2_Click);
			// 
			// lblAusgabe
			// 
			this.lblAusgabe.AutoSize = true;
			this.lblAusgabe.Location = new System.Drawing.Point(121, 17);
			this.lblAusgabe.Name = "lblAusgabe";
			this.lblAusgabe.Size = new System.Drawing.Size(35, 13);
			this.lblAusgabe.TabIndex = 2;
			this.lblAusgabe.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(371, 87);
			this.Controls.Add(this.lblAusgabe);
			this.Controls.Add(this.btnAnzeige2);
			this.Controls.Add(this.btnAnzeige1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAnzeige1;
		private System.Windows.Forms.Button btnAnzeige2;
		private System.Windows.Forms.Label lblAusgabe;
	}
}

