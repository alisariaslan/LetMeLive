namespace LetMeLive
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
			this.btn_set = new System.Windows.Forms.Button();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.rb_left = new System.Windows.Forms.RadioButton();
			this.rb_right = new System.Windows.Forms.RadioButton();
			this.lbl_speed = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_set
			// 
			this.btn_set.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_set.Location = new System.Drawing.Point(12, 86);
			this.btn_set.Name = "btn_set";
			this.btn_set.Size = new System.Drawing.Size(210, 192);
			this.btn_set.TabIndex = 0;
			this.btn_set.Text = "Press this button for setting your pause key";
			this.btn_set.UseVisualStyleBackColor = true;
			this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Text = "LetMeLive says hi.";
			this.notifyIcon1.Visible = true;
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(12, 35);
			this.trackBar1.Maximum = 15;
			this.trackBar1.Minimum = 1;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(210, 45);
			this.trackBar1.TabIndex = 1;
			this.trackBar1.Value = 7;
			this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
			// 
			// rb_left
			// 
			this.rb_left.AutoSize = true;
			this.rb_left.Location = new System.Drawing.Point(123, 12);
			this.rb_left.Name = "rb_left";
			this.rb_left.Size = new System.Drawing.Size(43, 17);
			this.rb_left.TabIndex = 2;
			this.rb_left.Text = "Left";
			this.rb_left.UseVisualStyleBackColor = true;
			// 
			// rb_right
			// 
			this.rb_right.AutoSize = true;
			this.rb_right.Checked = true;
			this.rb_right.Location = new System.Drawing.Point(172, 12);
			this.rb_right.Name = "rb_right";
			this.rb_right.Size = new System.Drawing.Size(50, 17);
			this.rb_right.TabIndex = 3;
			this.rb_right.TabStop = true;
			this.rb_right.Text = "Right";
			this.rb_right.UseVisualStyleBackColor = true;
			// 
			// lbl_speed
			// 
			this.lbl_speed.AutoSize = true;
			this.lbl_speed.Location = new System.Drawing.Point(12, 14);
			this.lbl_speed.Name = "lbl_speed";
			this.lbl_speed.Size = new System.Drawing.Size(50, 13);
			this.lbl_speed.TabIndex = 4;
			this.lbl_speed.Text = "Speed: 7";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(234, 290);
			this.Controls.Add(this.lbl_speed);
			this.Controls.Add(this.rb_right);
			this.Controls.Add(this.rb_left);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.btn_set);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LetMeLive";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Resize += new System.EventHandler(this.Form1_Resize);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_set;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.RadioButton rb_left;
		private System.Windows.Forms.RadioButton rb_right;
		private System.Windows.Forms.Label lbl_speed;
	}
}

