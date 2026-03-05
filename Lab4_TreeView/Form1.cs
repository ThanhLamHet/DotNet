namespace Lab4_TreeView
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			this.Load += new System.EventHandler(this.Form1_Load);
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{

		}
		private void Form1_Load(object sender, EventArgs e)
		{
			treeView1.ImageList = imageIcons;
			TreeNode goc = treeView1.Nodes.Add("Ký tự đặc biệt");
			goc.ImageIndex = 2;
			goc.SelectedImageIndex = 2;

			TreeNode nodeCong = goc.Nodes.Add("+");
			TreeNode nodeTru = goc.Nodes.Add("-");
			TreeNode nodeNhan = goc.Nodes.Add("*");
			TreeNode nodeChia = goc.Nodes.Add("/");

			nodeCong.ImageIndex = 4;
			nodeTru.ImageIndex = 4;
			nodeNhan.ImageIndex = 4;
			nodeChia.ImageIndex = 4;

			nodeCong.SelectedImageIndex = 5;
			nodeTru.SelectedImageIndex = 5;
			nodeNhan.SelectedImageIndex = 5;
			nodeChia.SelectedImageIndex = 5;

			TreeNode gockytu = treeView1.Nodes.Add("ký tự");
			gockytu.ImageIndex = 2;
			gockytu.SelectedImageIndex = 2;

			for (char i = 'A'; i <= 'Z'; i++)
			{
				TreeNode kt = gockytu.Nodes.Add(i + "");
				kt.ImageIndex = 4;
				kt.SelectedImageIndex = 4;

			}
			TreeNode gocSo = treeView1.Nodes.Add("Dãy số");
			gocSo.ImageIndex = 2;
			gocSo.SelectedImageIndex = 2;

			for (int i = 0; i <= 9; i++)
			{
				TreeNode n = gocSo.Nodes.Add(i.ToString());
				// Thay đổi ImageIndex cho giống hình mẫu (hình tam giác)
				n.ImageIndex = 4;
				n.SelectedImageIndex = 4;
			}
		}

		private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}
	}
}
