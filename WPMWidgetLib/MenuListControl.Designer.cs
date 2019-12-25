namespace WPMWidgetLib
{
    partial class MenuListControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("节点0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("节点2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("节点1", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeViewMenu = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeViewMenu
            // 
            this.treeViewMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(85)))), ((int)(((byte)(80)))));
            this.treeViewMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewMenu.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeViewMenu.ForeColor = System.Drawing.Color.White;
            this.treeViewMenu.FullRowSelect = true;
            this.treeViewMenu.HotTracking = true;
            this.treeViewMenu.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(85)))), ((int)(((byte)(80)))));
            this.treeViewMenu.Location = new System.Drawing.Point(0, 0);
            this.treeViewMenu.Margin = new System.Windows.Forms.Padding(4);
            this.treeViewMenu.Name = "treeViewMenu";
            treeNode1.Name = "节点0";
            treeNode1.Text = "节点0";
            treeNode2.Name = "节点2";
            treeNode2.Text = "节点2";
            treeNode3.Name = "节点1";
            treeNode3.Text = "节点1";
            this.treeViewMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode3});
            this.treeViewMenu.ShowLines = false;
            this.treeViewMenu.ShowPlusMinus = false;
            this.treeViewMenu.ShowRootLines = false;
            this.treeViewMenu.Size = new System.Drawing.Size(224, 734);
            this.treeViewMenu.TabIndex = 0;
            this.treeViewMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewMenu_AfterSelect);
            // 
            // MenuListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeViewMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuListControl";
            this.Size = new System.Drawing.Size(224, 734);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewMenu;
    }
}
