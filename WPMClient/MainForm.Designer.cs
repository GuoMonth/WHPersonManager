namespace WPMClient
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.l_user_status = new System.Windows.Forms.Label();
            this.l_user_group = new System.Windows.Forms.Label();
            this.l_user_name = new System.Windows.Forms.Label();
            this.menuListControl1 = new WPMWidgetLib.MenuListControl();
            this.panelMenu = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelMenu);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.menuListControl1);
            this.splitContainer1.Panel2MinSize = 5;
            this.splitContainer1.Size = new System.Drawing.Size(1314, 682);
            this.splitContainer1.SplitterDistance = 1149;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.l_user_status);
            this.panel1.Controls.Add(this.l_user_group);
            this.panel1.Controls.Add(this.l_user_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 70);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "状态：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "组别：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "姓名：";
            // 
            // l_user_status
            // 
            this.l_user_status.AutoSize = true;
            this.l_user_status.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_user_status.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.l_user_status.Location = new System.Drawing.Point(496, 14);
            this.l_user_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_user_status.Name = "l_user_status";
            this.l_user_status.Size = new System.Drawing.Size(62, 31);
            this.l_user_status.TabIndex = 2;
            this.l_user_status.Text = "在职";
            // 
            // l_user_group
            // 
            this.l_user_group.AutoSize = true;
            this.l_user_group.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_user_group.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_user_group.Location = new System.Drawing.Point(290, 14);
            this.l_user_group.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_user_group.Name = "l_user_group";
            this.l_user_group.Size = new System.Drawing.Size(86, 31);
            this.l_user_group.TabIndex = 1;
            this.l_user_group.Text = "上报组";
            // 
            // l_user_name
            // 
            this.l_user_name.AutoSize = true;
            this.l_user_name.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_user_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_user_name.Location = new System.Drawing.Point(75, 10);
            this.l_user_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_user_name.Name = "l_user_name";
            this.l_user_name.Size = new System.Drawing.Size(75, 38);
            this.l_user_name.TabIndex = 0;
            this.l_user_name.Text = "周成";
            // 
            // menuListControl1
            // 
            this.menuListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuListControl1.Location = new System.Drawing.Point(0, 0);
            this.menuListControl1.Margin = new System.Windows.Forms.Padding(6);
            this.menuListControl1.Name = "menuListControl1";
            this.menuListControl1.Size = new System.Drawing.Size(159, 682);
            this.menuListControl1.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 70);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1149, 612);
            this.panelMenu.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 682);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "武汉人事管理小程序";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_user_status;
        private System.Windows.Forms.Label l_user_group;
        private System.Windows.Forms.Label l_user_name;
        private WPMWidgetLib.MenuListControl menuListControl1;
        private System.Windows.Forms.Panel panelMenu;
    }
}