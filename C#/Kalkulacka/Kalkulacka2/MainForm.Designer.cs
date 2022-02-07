
namespace Kalkulacka
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.Label Symbol;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button buttonEquals;
		private System.Windows.Forms.Button buttonComma;
		private System.Windows.Forms.Button button0;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button buttonDif;
		private System.Windows.Forms.Button buttonCE;
		private System.Windows.Forms.Button buttonSlash;
		private System.Windows.Forms.Button buttonStar;
		private System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.Button buttonSum;
		private System.Windows.Forms.Button buttonSqRoot;
		private System.Windows.Forms.Button buttonPower;
		//private System.Windows.Forms.Button buttonSqRoot;
		
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
			this.textBox = new System.Windows.Forms.TextBox();
			this.Symbol = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.buttonEquals = new System.Windows.Forms.Button();
			this.buttonComma = new System.Windows.Forms.Button();
			this.button0 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.buttonSum = new System.Windows.Forms.Button();
			this.buttonSlash = new System.Windows.Forms.Button();
			this.buttonStar = new System.Windows.Forms.Button();
			this.buttonSqRoot = new System.Windows.Forms.Button();
			this.buttonBack = new System.Windows.Forms.Button();
			this.buttonDif = new System.Windows.Forms.Button();
			this.buttonCE = new System.Windows.Forms.Button();
			this.buttonPower = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox
			// 
			this.textBox.Font = new System.Drawing.Font("Trebuchet MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBox.Location = new System.Drawing.Point(97, 12);
			this.textBox.Multiline = true;
			this.textBox.Name = "textBox";
			this.textBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.textBox.Size = new System.Drawing.Size(382, 58);
			this.textBox.TabIndex = 21;
			this.textBox.Text = "0";
			this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// Symbol
			// 
			this.Symbol.BackColor = System.Drawing.SystemColors.Control;
			this.Symbol.Font = new System.Drawing.Font("Trebuchet MS", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Symbol.Location = new System.Drawing.Point(21, 12);
			this.Symbol.Name = "Symbol";
			this.Symbol.Size = new System.Drawing.Size(70, 58);
			this.Symbol.TabIndex = 1;
			this.Symbol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel1.Controls.Add(this.buttonEquals, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.buttonComma, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.button0, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.button3, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.button2, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.button1, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.button6, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.button5, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.button4, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.button9, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.button8, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.button7, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 91);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(290, 269);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// buttonEquals
			// 
			this.buttonEquals.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonEquals.Font = new System.Drawing.Font("Trebuchet MS", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonEquals.Location = new System.Drawing.Point(192, 201);
			this.buttonEquals.Margin = new System.Windows.Forms.Padding(0);
			this.buttonEquals.Name = "buttonEquals";
			this.buttonEquals.Padding = new System.Windows.Forms.Padding(5);
			this.buttonEquals.Size = new System.Drawing.Size(98, 68);
			this.buttonEquals.TabIndex = 12;
			this.buttonEquals.Text = "=";
			this.buttonEquals.UseVisualStyleBackColor = true;
			this.buttonEquals.Click += new System.EventHandler(this.ButtonEqualClick);
			// 
			// buttonComma
			// 
			this.buttonComma.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonComma.Font = new System.Drawing.Font("Trebuchet MS", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonComma.Location = new System.Drawing.Point(96, 201);
			this.buttonComma.Margin = new System.Windows.Forms.Padding(0);
			this.buttonComma.Name = "buttonComma";
			this.buttonComma.Padding = new System.Windows.Forms.Padding(5);
			this.buttonComma.Size = new System.Drawing.Size(96, 68);
			this.buttonComma.TabIndex = 11;
			this.buttonComma.Text = ",";
			this.buttonComma.UseVisualStyleBackColor = true;
			this.buttonComma.Click += new System.EventHandler(this.ButtonComma_click);
			// 
			// button0
			// 
			this.button0.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button0.Font = new System.Drawing.Font("Trebuchet MS", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button0.Location = new System.Drawing.Point(0, 201);
			this.button0.Margin = new System.Windows.Forms.Padding(0);
			this.button0.Name = "button0";
			this.button0.Padding = new System.Windows.Forms.Padding(5);
			this.button0.Size = new System.Drawing.Size(96, 68);
			this.button0.TabIndex = 10;
			this.button0.Text = "0";
			this.button0.UseVisualStyleBackColor = true;
			this.button0.Click += new System.EventHandler(this.Button_click);
			// 
			// button3
			// 
			this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button3.Font = new System.Drawing.Font("Trebuchet MS", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button3.Location = new System.Drawing.Point(192, 134);
			this.button3.Margin = new System.Windows.Forms.Padding(0);
			this.button3.Name = "button3";
			this.button3.Padding = new System.Windows.Forms.Padding(5);
			this.button3.Size = new System.Drawing.Size(98, 67);
			this.button3.TabIndex = 3;
			this.button3.Text = "3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button_click);
			// 
			// button2
			// 
			this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button2.Font = new System.Drawing.Font("Trebuchet MS", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button2.Location = new System.Drawing.Point(96, 134);
			this.button2.Margin = new System.Windows.Forms.Padding(0);
			this.button2.Name = "button2";
			this.button2.Padding = new System.Windows.Forms.Padding(5);
			this.button2.Size = new System.Drawing.Size(96, 67);
			this.button2.TabIndex = 2;
			this.button2.Text = "2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button_click);
			// 
			// button1
			// 
			this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button1.Font = new System.Drawing.Font("Trebuchet MS", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button1.Location = new System.Drawing.Point(0, 134);
			this.button1.Margin = new System.Windows.Forms.Padding(0);
			this.button1.Name = "button1";
			this.button1.Padding = new System.Windows.Forms.Padding(5);
			this.button1.Size = new System.Drawing.Size(96, 67);
			this.button1.TabIndex = 1;
			this.button1.Text = "1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button_click);
			// 
			// button6
			// 
			this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button6.Font = new System.Drawing.Font("Trebuchet MS", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button6.Location = new System.Drawing.Point(192, 67);
			this.button6.Margin = new System.Windows.Forms.Padding(0);
			this.button6.Name = "button6";
			this.button6.Padding = new System.Windows.Forms.Padding(5);
			this.button6.Size = new System.Drawing.Size(98, 67);
			this.button6.TabIndex = 6;
			this.button6.Text = "6";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button_click);
			// 
			// button5
			// 
			this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button5.Font = new System.Drawing.Font("Trebuchet MS", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button5.Location = new System.Drawing.Point(96, 67);
			this.button5.Margin = new System.Windows.Forms.Padding(0);
			this.button5.Name = "button5";
			this.button5.Padding = new System.Windows.Forms.Padding(5);
			this.button5.Size = new System.Drawing.Size(96, 67);
			this.button5.TabIndex = 5;
			this.button5.Text = "5";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button_click);
			// 
			// button4
			// 
			this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button4.Font = new System.Drawing.Font("Trebuchet MS", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button4.Location = new System.Drawing.Point(0, 67);
			this.button4.Margin = new System.Windows.Forms.Padding(0);
			this.button4.Name = "button4";
			this.button4.Padding = new System.Windows.Forms.Padding(5);
			this.button4.Size = new System.Drawing.Size(96, 67);
			this.button4.TabIndex = 4;
			this.button4.Text = "4";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button_click);
			// 
			// button9
			// 
			this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button9.Font = new System.Drawing.Font("Trebuchet MS", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button9.Location = new System.Drawing.Point(192, 0);
			this.button9.Margin = new System.Windows.Forms.Padding(0);
			this.button9.Name = "button9";
			this.button9.Padding = new System.Windows.Forms.Padding(5);
			this.button9.Size = new System.Drawing.Size(98, 67);
			this.button9.TabIndex = 9;
			this.button9.Text = "9";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.Button_click);
			// 
			// button8
			// 
			this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button8.Font = new System.Drawing.Font("Trebuchet MS", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button8.Location = new System.Drawing.Point(96, 0);
			this.button8.Margin = new System.Windows.Forms.Padding(0);
			this.button8.Name = "button8";
			this.button8.Padding = new System.Windows.Forms.Padding(5);
			this.button8.Size = new System.Drawing.Size(96, 67);
			this.button8.TabIndex = 8;
			this.button8.Text = "8";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button_click);
			// 
			// button7
			// 
			this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button7.Font = new System.Drawing.Font("Trebuchet MS", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button7.Location = new System.Drawing.Point(0, 0);
			this.button7.Margin = new System.Windows.Forms.Padding(0);
			this.button7.Name = "button7";
			this.button7.Padding = new System.Windows.Forms.Padding(5);
			this.button7.Size = new System.Drawing.Size(96, 67);
			this.button7.TabIndex = 7;
			this.button7.Text = "7";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button_click);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.buttonSum, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.buttonSlash, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.buttonStar, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.buttonSqRoot, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.buttonBack, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.buttonDif, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.buttonCE, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.buttonPower, 0, 1);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(323, 91);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 4;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(180, 269);
			this.tableLayoutPanel2.TabIndex = 3;
			// 
			// buttonSum
			// 
			this.buttonSum.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonSum.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonSum.Location = new System.Drawing.Point(0, 201);
			this.buttonSum.Margin = new System.Windows.Forms.Padding(0);
			this.buttonSum.Name = "buttonSum";
			this.buttonSum.Padding = new System.Windows.Forms.Padding(5);
			this.buttonSum.Size = new System.Drawing.Size(90, 68);
			this.buttonSum.TabIndex = 13;
			this.buttonSum.Text = "+";
			this.buttonSum.UseVisualStyleBackColor = true;
			this.buttonSum.Click += new System.EventHandler(this.ButtonOperation_click);
			// 
			// buttonSlash
			// 
			this.buttonSlash.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonSlash.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonSlash.Location = new System.Drawing.Point(90, 134);
			this.buttonSlash.Margin = new System.Windows.Forms.Padding(0);
			this.buttonSlash.Name = "buttonSlash";
			this.buttonSlash.Padding = new System.Windows.Forms.Padding(5);
			this.buttonSlash.Size = new System.Drawing.Size(90, 67);
			this.buttonSlash.TabIndex = 16;
			this.buttonSlash.Text = "÷";
			this.buttonSlash.UseVisualStyleBackColor = true;
			this.buttonSlash.Click += new System.EventHandler(this.ButtonOperation_click);
			// 
			// buttonStar
			// 
			this.buttonStar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonStar.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonStar.Location = new System.Drawing.Point(0, 134);
			this.buttonStar.Margin = new System.Windows.Forms.Padding(0);
			this.buttonStar.Name = "buttonStar";
			this.buttonStar.Padding = new System.Windows.Forms.Padding(5);
			this.buttonStar.Size = new System.Drawing.Size(90, 67);
			this.buttonStar.TabIndex = 15;
			this.buttonStar.Text = "*";
			this.buttonStar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.buttonStar.UseVisualStyleBackColor = true;
			this.buttonStar.Click += new System.EventHandler(this.ButtonOperation_click);
			// 
			// buttonSqRoot
			// 
			this.buttonSqRoot.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonSqRoot.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonSqRoot.Location = new System.Drawing.Point(90, 67);
			this.buttonSqRoot.Margin = new System.Windows.Forms.Padding(0);
			this.buttonSqRoot.Name = "buttonSqRoot";
			this.buttonSqRoot.Padding = new System.Windows.Forms.Padding(5);
			this.buttonSqRoot.Size = new System.Drawing.Size(90, 67);
			this.buttonSqRoot.TabIndex = 18;
			this.buttonSqRoot.Text = "√x";
			this.buttonSqRoot.UseVisualStyleBackColor = true;
			this.buttonSqRoot.Click += new System.EventHandler(this.ButtonOperation_click);
			// 
			// buttonBack
			// 
			this.buttonBack.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonBack.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonBack.Location = new System.Drawing.Point(90, 0);
			this.buttonBack.Margin = new System.Windows.Forms.Padding(0);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Padding = new System.Windows.Forms.Padding(5);
			this.buttonBack.Size = new System.Drawing.Size(90, 67);
			this.buttonBack.TabIndex = 20;
			this.buttonBack.Text = "Back";
			this.buttonBack.UseVisualStyleBackColor = true;
			this.buttonBack.Click += new System.EventHandler(this.ButtonBackClick);
			// 
			// buttonDif
			// 
			this.buttonDif.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonDif.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonDif.Location = new System.Drawing.Point(90, 201);
			this.buttonDif.Margin = new System.Windows.Forms.Padding(0);
			this.buttonDif.Name = "buttonDif";
			this.buttonDif.Padding = new System.Windows.Forms.Padding(5);
			this.buttonDif.Size = new System.Drawing.Size(90, 68);
			this.buttonDif.TabIndex = 14;
			this.buttonDif.Text = "-";
			this.buttonDif.UseVisualStyleBackColor = true;
			this.buttonDif.Click += new System.EventHandler(this.ButtonOperation_click);
			// 
			// buttonCE
			// 
			this.buttonCE.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonCE.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonCE.Location = new System.Drawing.Point(0, 0);
			this.buttonCE.Margin = new System.Windows.Forms.Padding(0);
			this.buttonCE.Name = "buttonCE";
			this.buttonCE.Padding = new System.Windows.Forms.Padding(5);
			this.buttonCE.Size = new System.Drawing.Size(90, 67);
			this.buttonCE.TabIndex = 19;
			this.buttonCE.Text = "Clear";
			this.buttonCE.UseVisualStyleBackColor = true;
			this.buttonCE.Click += new System.EventHandler(this.ButtonCEClick);
			// 
			// buttonPower
			// 
			this.buttonPower.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.buttonPower.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonPower.Location = new System.Drawing.Point(0, 67);
			this.buttonPower.Margin = new System.Windows.Forms.Padding(0);
			this.buttonPower.Name = "buttonPower";
			this.buttonPower.Size = new System.Drawing.Size(90, 67);
			this.buttonPower.TabIndex = 17;
			this.buttonPower.Text = "x²";
			this.buttonPower.UseVisualStyleBackColor = true;
			this.buttonPower.Click += new System.EventHandler(this.ButtonOperation_click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(515, 369);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.Symbol);
			this.Controls.Add(this.textBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kalkulacka";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
