namespace Lab4_TreeView
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			toolStrip1 = new ToolStrip();
			toolStripButton1 = new ToolStripButton();
			toolStripLabel1 = new ToolStripLabel();
			toolStripButton2 = new ToolStripButton();
			toolStripLabel2 = new ToolStripLabel();
			toolStripButton3 = new ToolStripButton();
			treeView1 = new TreeView();
			imageIcons = new ImageList(components);
			toolStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// toolStrip1
			// 
			toolStrip1.ImageScalingSize = new Size(20, 20);
			toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripLabel1, toolStripButton2, toolStripLabel2, toolStripButton3 });
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(523, 27);
			toolStrip1.TabIndex = 0;
			toolStrip1.Text = "toolStrip1";
			toolStrip1.ItemClicked += toolStrip1_ItemClicked;
			// 
			// toolStripButton1
			// 
			toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
			toolStripButton1.ImageTransparentColor = Color.Magenta;
			toolStripButton1.Name = "toolStripButton1";
			toolStripButton1.Size = new Size(29, 24);
			toolStripButton1.Text = "toolStripButton1";
			toolStripButton1.Click += toolStripButton1_Click;
			// 
			// toolStripLabel1
			// 
			toolStripLabel1.Name = "toolStripLabel1";
			toolStripLabel1.Size = new Size(70, 24);
			toolStripLabel1.Text = "Mở Rộng";
			// 
			// toolStripButton2
			// 
			toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
			toolStripButton2.ImageTransparentColor = Color.Magenta;
			toolStripButton2.Name = "toolStripButton2";
			toolStripButton2.Size = new Size(29, 24);
			toolStripButton2.Text = "toolStripButton2";
			// 
			// toolStripLabel2
			// 
			toolStripLabel2.Name = "toolStripLabel2";
			toolStripLabel2.Size = new Size(65, 24);
			toolStripLabel2.Text = "Thu Nhỏ";
			// 
			// toolStripButton3
			// 
			toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
			toolStripButton3.ImageTransparentColor = Color.Magenta;
			toolStripButton3.Name = "toolStripButton3";
			toolStripButton3.Size = new Size(29, 24);
			toolStripButton3.Text = "toolStripButton3";
			// 
			// treeView1
			// 
			treeView1.Location = new Point(12, 30);
			treeView1.Name = "treeView1";
			treeView1.Size = new Size(269, 493);
			treeView1.TabIndex = 1;
			// 
			// imageIcons
			// 
			imageIcons.ColorDepth = ColorDepth.Depth32Bit;
			imageIcons.ImageStream = (ImageListStreamer)resources.GetObject("imageIcons.ImageStream");
			imageIcons.TransparentColor = Color.Transparent;
			imageIcons.Images.SetKeyName(0, "Double-J-Design-Ravenna-3d-Database-Inactive.256.png");
			imageIcons.Images.SetKeyName(1, "Gakuseisean-Ivista-2-Alarm-Minus.256.png");
			imageIcons.Images.SetKeyName(2, "Hopstarter-Sleek-Xp-Basic-Document-Blank.256.png");
			imageIcons.Images.SetKeyName(3, "Hopstarter-Button-Button-Add.256.png");
			imageIcons.Images.SetKeyName(4, "down.png");
			imageIcons.Images.SetKeyName(5, "up.png");
			imageIcons.Images.SetKeyName(6, "Iconka-Beer-My-computer.48.png");
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(523, 535);
			Controls.Add(treeView1);
			Controls.Add(toolStrip1);
			Name = "Form1";
			Text = "Form1";
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ToolStrip toolStrip1;
		private ToolStripButton toolStripButton1;
		private TreeView treeView1;
		private ToolStripLabel toolStripLabel1;
		private ToolStripButton toolStripButton2;
		private ToolStripLabel toolStripLabel2;
		private ToolStripButton toolStripButton3;
		private ImageList imageIcons;
	}
}
