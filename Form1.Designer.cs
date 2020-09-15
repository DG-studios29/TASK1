namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
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
			this.lblDisplay = new System.Windows.Forms.Label();
			this.lblMap = new System.Windows.Forms.Label();
			this.btnRight = new System.Windows.Forms.Button();
			this.btnUp = new System.Windows.Forms.Button();
			this.btnDown = new System.Windows.Forms.Button();
			this.btnLeft = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblDisplay
			// 
			this.lblDisplay.AutoSize = true;
			this.lblDisplay.Location = new System.Drawing.Point(738, 48);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(46, 17);
			this.lblDisplay.TabIndex = 6;
			this.lblDisplay.Text = "label1";
			// 
			// lblMap
			// 
			this.lblMap.AutoSize = true;
			this.lblMap.Location = new System.Drawing.Point(48, 48);
			this.lblMap.Name = "lblMap";
			this.lblMap.Size = new System.Drawing.Size(46, 17);
			this.lblMap.TabIndex = 7;
			this.lblMap.Text = "label1";
			// 
			// btnRight
			// 
			this.btnRight.Location = new System.Drawing.Point(1000, 499);
			this.btnRight.Name = "btnRight";
			this.btnRight.Size = new System.Drawing.Size(112, 100);
			this.btnRight.TabIndex = 2;
			this.btnRight.Text = "Right >";
			this.btnRight.UseVisualStyleBackColor = true;
			this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
			// 
			// btnUp
			// 
			this.btnUp.Location = new System.Drawing.Point(870, 382);
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new System.Drawing.Size(112, 100);
			this.btnUp.TabIndex = 3;
			this.btnUp.Text = "Up /\\";
			this.btnUp.UseVisualStyleBackColor = true;
			this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
			// 
			// btnDown
			// 
			this.btnDown.Location = new System.Drawing.Point(870, 499);
			this.btnDown.Name = "btnDown";
			this.btnDown.Size = new System.Drawing.Size(112, 100);
			this.btnDown.TabIndex = 4;
			this.btnDown.Text = "Down \\/";
			this.btnDown.UseVisualStyleBackColor = true;
			this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
			// 
			// btnLeft
			// 
			this.btnLeft.Location = new System.Drawing.Point(741, 499);
			this.btnLeft.Name = "btnLeft";
			this.btnLeft.Size = new System.Drawing.Size(112, 100);
			this.btnLeft.TabIndex = 5;
			this.btnLeft.Text = "< Left";
			this.btnLeft.UseVisualStyleBackColor = true;
			this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1159, 647);
			this.Controls.Add(this.lblDisplay);
			this.Controls.Add(this.lblMap);
			this.Controls.Add(this.btnRight);
			this.Controls.Add(this.btnUp);
			this.Controls.Add(this.btnDown);
			this.Controls.Add(this.btnLeft);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblDisplay;
		private System.Windows.Forms.Label lblMap;
		private System.Windows.Forms.Button btnRight;
		private System.Windows.Forms.Button btnUp;
		private System.Windows.Forms.Button btnDown;
		private System.Windows.Forms.Button btnLeft;
	}
}

