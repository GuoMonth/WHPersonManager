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
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.menuListControl1);
            this.splitContainer1.Panel2MinSize = 5;
            this.splitContainer1.Size = new System.Drawing.Size(876, 455);
            this.splitContainer1.SplitterDistance = 766;
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
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 47);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "状态：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "组别：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "姓名：";
            // 
            // l_user_status
            // 
            this.l_user_status.AutoSize = true;
            this.l_user_status.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_user_status.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.l_user_status.Location = new System.Drawing.Point(331, 9);
            this.l_user_status.Name = "l_user_status";
            this.l_user_status.Size = new System.Drawing.Size(42, 21);
            this.l_user_status.TabIndex = 2;
            this.l_user_status.Text = "在职";
            // 
            // l_user_group
            // 
            this.l_user_group.AutoSize = true;
            this.l_user_group.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_user_group.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_user_group.Location = new System.Drawing.Point(193, 9);
            this.l_user_group.Name = "l_user_group";
            this.l_user_group.Size = new System.Drawing.Size(58, 21);
            this.l_user_group.TabIndex = 1;
            this.l_user_group.Text = "上报组";
            // 
            // l_user_name
            // 
            this.l_user_name.AutoSize = true;
            this.l_user_name.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_user_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_user_name.Location = new System.Drawing.Point(50, 7);
            this.l_user_name.Name = "l_user_name";
            this.l_user_name.Size = new System.Drawing.Size(50, 25);
            this.l_user_name.TabIndex = 0;
            this.l_user_name.Text = "周成";
            // 
            // menuListControl1
            // 
            this.menuListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuListControl1.Location = new System.Drawing.Point(0, 0);
            this.menuListControl1.Name = "menuListControl1";
            this.menuListControl1.Size = new System.Drawing.Size(106, 455);
            this.menuListControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 455);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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



    }
}