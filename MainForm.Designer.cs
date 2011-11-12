/*
 * Created by SharpDevelop.
 * User: David Ledford"
 Date: 11/5/2011
 * Time: 3:29 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Writer
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Button1 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TextBox1
			// 
			this.TextBox1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.TextBox1.Location = new System.Drawing.Point(12, 45);
			this.TextBox1.Multiline = true;
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TextBox1.Size = new System.Drawing.Size(584, 399);
			this.TextBox1.TabIndex = 0;
			// 
			// Button1
			// 
			this.Button1.BackColor = System.Drawing.SystemColors.Control;
			this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Button1.ForeColor = System.Drawing.SystemColors.InfoText;
			this.Button1.Location = new System.Drawing.Point(12, 0);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(136, 39);
			this.Button1.TabIndex = 1;
			this.Button1.Text = "Write to Journal";
			this.Button1.UseVisualStyleBackColor = false;
			this.Button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// checkBox1
			// 
			this.checkBox1.BackColor = System.Drawing.SystemColors.HighlightText;
			this.checkBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBox1.BackgroundImage")));
			this.checkBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.checkBox1.Location = new System.Drawing.Point(500, 450);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(96, 16);
			this.checkBox1.TabIndex = 3;
			this.checkBox1.Text = "Read Journal";
			this.checkBox1.UseVisualStyleBackColor = false;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.Control;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.ForeColor = System.Drawing.SystemColors.InfoText;
			this.button2.Location = new System.Drawing.Point(458, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(136, 39);
			this.button2.TabIndex = 4;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.CancelButton = this.button2;
			this.ClientSize = new System.Drawing.Size(606, 473);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.TextBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Writer";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button Button1;
		private System.Windows.Forms.TextBox TextBox1;
		

	}
}
