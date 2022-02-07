
namespace PhoneBook
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbFirstName;
		private System.Windows.Forms.TextBox tbLastName;
		private System.Windows.Forms.TextBox tbPhoneNumber;
		private System.Windows.Forms.TextBox tbEmail;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnAddContact;
		private System.Windows.Forms.Button btnDelContact;
		private System.Windows.Forms.Button btnSaveXml;
		private System.Windows.Forms.TextBox tbDepartment;
		private System.Windows.Forms.ListBox listBox;
		private System.Windows.Forms.Button buttonExit;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tbFirstName = new System.Windows.Forms.TextBox();
			this.tbLastName = new System.Windows.Forms.TextBox();
			this.tbPhoneNumber = new System.Windows.Forms.TextBox();
			this.tbEmail = new System.Windows.Forms.TextBox();
			this.tbDepartment = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnSaveXml = new System.Windows.Forms.Button();
			this.btnAddContact = new System.Windows.Forms.Button();
			this.btnDelContact = new System.Windows.Forms.Button();
			this.listBox = new System.Windows.Forms.ListBox();
			this.buttonExit = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(55, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Jméno:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(55, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 26);
			this.label2.TabIndex = 1;
			this.label2.Text = "Příjmení:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(55, 155);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 26);
			this.label3.TabIndex = 2;
			this.label3.Text = "Telefon:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.Location = new System.Drawing.Point(55, 209);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 26);
			this.label4.TabIndex = 3;
			this.label4.Text = "E-mail:";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.Location = new System.Drawing.Point(55, 263);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 26);
			this.label5.TabIndex = 4;
			this.label5.Text = "Funkce:";
			// 
			// tbFirstName
			// 
			this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tbFirstName.Location = new System.Drawing.Point(139, 53);
			this.tbFirstName.Name = "tbFirstName";
			this.tbFirstName.Size = new System.Drawing.Size(171, 26);
			this.tbFirstName.TabIndex = 5;
			// 
			// tbLastName
			// 
			this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tbLastName.Location = new System.Drawing.Point(139, 101);
			this.tbLastName.Name = "tbLastName";
			this.tbLastName.Size = new System.Drawing.Size(171, 26);
			this.tbLastName.TabIndex = 6;
			// 
			// tbPhoneNumber
			// 
			this.tbPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tbPhoneNumber.Location = new System.Drawing.Point(139, 152);
			this.tbPhoneNumber.Name = "tbPhoneNumber";
			this.tbPhoneNumber.Size = new System.Drawing.Size(171, 26);
			this.tbPhoneNumber.TabIndex = 7;
			// 
			// tbEmail
			// 
			this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tbEmail.Location = new System.Drawing.Point(139, 209);
			this.tbEmail.Name = "tbEmail";
			this.tbEmail.Size = new System.Drawing.Size(171, 26);
			this.tbEmail.TabIndex = 8;
			// 
			// tbDepartment
			// 
			this.tbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tbDepartment.Location = new System.Drawing.Point(139, 263);
			this.tbDepartment.Name = "tbDepartment";
			this.tbDepartment.Size = new System.Drawing.Size(171, 26);
			this.tbDepartment.TabIndex = 9;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.tbLastName);
			this.groupBox1.Controls.Add(this.tbDepartment);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.tbEmail);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.tbPhoneNumber);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.tbFirstName);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(391, 506);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Nový záznam";
			// 
			// label6
			// 
			this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
			this.label6.Location = new System.Drawing.Point(55, 311);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(302, 160);
			this.label6.TabIndex = 10;
			// 
			// btnSaveXml
			// 
			this.btnSaveXml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(229)))), ((int)(((byte)(108)))));
			this.btnSaveXml.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(152)))), ((int)(((byte)(23)))));
			this.btnSaveXml.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(152)))), ((int)(((byte)(23)))));
			this.btnSaveXml.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(197)))), ((int)(((byte)(31)))));
			this.btnSaveXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnSaveXml.Location = new System.Drawing.Point(730, 431);
			this.btnSaveXml.Name = "btnSaveXml";
			this.btnSaveXml.Size = new System.Drawing.Size(126, 31);
			this.btnSaveXml.TabIndex = 14;
			this.btnSaveXml.Text = "Ulož XML";
			this.btnSaveXml.UseVisualStyleBackColor = false;
			this.btnSaveXml.Click += new System.EventHandler(this.BtnSaveXmlClick);
			// 
			// btnAddContact
			// 
			this.btnAddContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(149)))), ((int)(((byte)(131)))));
			this.btnAddContact.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(70)))), ((int)(((byte)(45)))));
			this.btnAddContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(70)))), ((int)(((byte)(45)))));
			this.btnAddContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(88)))), ((int)(((byte)(58)))));
			this.btnAddContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnAddContact.ForeColor = System.Drawing.Color.Black;
			this.btnAddContact.Location = new System.Drawing.Point(418, 431);
			this.btnAddContact.Name = "btnAddContact";
			this.btnAddContact.Size = new System.Drawing.Size(140, 31);
			this.btnAddContact.TabIndex = 12;
			this.btnAddContact.Text = "Přidat kontakt";
			this.btnAddContact.UseVisualStyleBackColor = false;
			this.btnAddContact.Click += new System.EventHandler(this.BtnAddContactClick);
			// 
			// btnDelContact
			// 
			this.btnDelContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(225)))), ((int)(((byte)(172)))));
			this.btnDelContact.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(168)))), ((int)(((byte)(93)))));
			this.btnDelContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(168)))), ((int)(((byte)(93)))));
			this.btnDelContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(219)))), ((int)(((byte)(120)))));
			this.btnDelContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnDelContact.Location = new System.Drawing.Point(577, 431);
			this.btnDelContact.Name = "btnDelContact";
			this.btnDelContact.Size = new System.Drawing.Size(135, 31);
			this.btnDelContact.TabIndex = 13;
			this.btnDelContact.Text = "Smazat vybraný";
			this.btnDelContact.UseVisualStyleBackColor = false;
			this.btnDelContact.Click += new System.EventHandler(this.BtnDelContactClick);
			// 
			// listBox
			// 
			this.listBox.FormattingEnabled = true;
			this.listBox.Location = new System.Drawing.Point(418, 18);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(438, 394);
			this.listBox.TabIndex = 16;
			// 
			// buttonExit
			// 
			this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(180)))), ((int)(((byte)(198)))));
			this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(119)))), ((int)(((byte)(160)))));
			this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(119)))), ((int)(((byte)(160)))));
			this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(160)))), ((int)(((byte)(198)))));
			this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonExit.Location = new System.Drawing.Point(418, 483);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(438, 34);
			this.buttonExit.TabIndex = 17;
			this.buttonExit.Text = "Uložit a ukončit";
			this.buttonExit.UseVisualStyleBackColor = false;
			this.buttonExit.Click += new System.EventHandler(this.ButtonExitClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(868, 530);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.btnDelContact);
			this.Controls.Add(this.btnAddContact);
			this.Controls.Add(this.btnSaveXml);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.listBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(884, 569);
			this.MinimumSize = new System.Drawing.Size(884, 569);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PhoneBook";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
