namespace GeoScopeBD.Controls
{
    partial class NavigationControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavigationControl));
			button2 = new Button();
			btnPan = new Button();
			button3 = new Button();
			button4 = new Button();
			button5 = new Button();
			SuspendLayout();
			// 
			// button2
			// 
			button2.BackColor = Color.White;
			button2.Image = (Image)resources.GetObject("button2.Image");
			button2.Location = new Point(-1, 46);
			button2.Margin = new Padding(4, 5, 4, 5);
			button2.Name = "button2";
			button2.Size = new Size(43, 49);
			button2.TabIndex = 2;
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			button2.MouseHover += button2_MouseHover;
			// 
			// btnPan
			// 
			btnPan.BackColor = Color.White;
			btnPan.Image = (Image)resources.GetObject("btnPan.Image");
			btnPan.Location = new Point(-1, -2);
			btnPan.Margin = new Padding(4, 5, 4, 5);
			btnPan.Name = "btnPan";
			btnPan.Size = new Size(43, 49);
			btnPan.TabIndex = 1;
			btnPan.TextAlign = ContentAlignment.MiddleRight;
			btnPan.UseVisualStyleBackColor = false;
			btnPan.Click += button1_Click;
			btnPan.MouseHover += button1_MouseHover;
			// 
			// button3
			// 
			button3.BackColor = Color.White;
			button3.Image = (Image)resources.GetObject("button3.Image");
			button3.Location = new Point(-1, 94);
			button3.Margin = new Padding(4, 5, 4, 5);
			button3.Name = "button3";
			button3.Size = new Size(43, 49);
			button3.TabIndex = 3;
			button3.TextAlign = ContentAlignment.MiddleRight;
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click;
			button3.MouseHover += button3_MouseHover;
			// 
			// button4
			// 
			button4.BackColor = Color.White;
			button4.Image = (Image)resources.GetObject("button4.Image");
			button4.Location = new Point(-1, 142);
			button4.Margin = new Padding(4, 5, 4, 5);
			button4.Name = "button4";
			button4.Size = new Size(43, 49);
			button4.TabIndex = 4;
			button4.TextAlign = ContentAlignment.MiddleRight;
			button4.UseVisualStyleBackColor = false;
			button4.Click += button4_Click;
			button4.MouseHover += button4_MouseHover;
			// 
			// button5
			// 
			button5.BackColor = Color.White;
			button5.Image = (Image)resources.GetObject("button5.Image");
			button5.ImageAlign = ContentAlignment.BottomCenter;
			button5.Location = new Point(-1, 189);
			button5.Margin = new Padding(4, 5, 4, 5);
			button5.Name = "button5";
			button5.Size = new Size(43, 49);
			button5.TabIndex = 5;
			button5.UseVisualStyleBackColor = false;
			button5.Click += button5_Click;
			button5.MouseHover += button5_MouseHover;
			// 
			// NavigationControl
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(button5);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(btnPan);
			Location = new Point(17, 17);
			Margin = new Padding(4, 5, 4, 5);
			Name = "NavigationControl";
			Size = new Size(40, 237);
			MouseHover += NavigationControl_MouseHover;
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.Button btnPan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}
