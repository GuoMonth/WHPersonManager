namespace WPMClient.SysModule
{
    partial class MenuConfigControl
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dllName = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_nameSpace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_className = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_showName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sortNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_fatherID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "dll文件路径：";
            // 
            // txt_dllName
            // 
            this.txt_dllName.Location = new System.Drawing.Point(210, 37);
            this.txt_dllName.Name = "txt_dllName";
            this.txt_dllName.Size = new System.Drawing.Size(654, 28);
            this.txt_dllName.TabIndex = 1;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(619, 579);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 33);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_nameSpace
            // 
            this.txt_nameSpace.Location = new System.Drawing.Point(210, 90);
            this.txt_nameSpace.Name = "txt_nameSpace";
            this.txt_nameSpace.Size = new System.Drawing.Size(654, 28);
            this.txt_nameSpace.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "命名空间：";
            // 
            // txt_className
            // 
            this.txt_className.Location = new System.Drawing.Point(210, 152);
            this.txt_className.Name = "txt_className";
            this.txt_className.Size = new System.Drawing.Size(654, 28);
            this.txt_className.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "类名：";
            // 
            // txt_showName
            // 
            this.txt_showName.Location = new System.Drawing.Point(210, 201);
            this.txt_showName.Name = "txt_showName";
            this.txt_showName.Size = new System.Drawing.Size(654, 28);
            this.txt_showName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "菜单显示名：";
            // 
            // txt_sortNum
            // 
            this.txt_sortNum.Location = new System.Drawing.Point(210, 269);
            this.txt_sortNum.Name = "txt_sortNum";
            this.txt_sortNum.Size = new System.Drawing.Size(654, 28);
            this.txt_sortNum.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "菜单显示顺序：";
            // 
            // txt_fatherID
            // 
            this.txt_fatherID.Location = new System.Drawing.Point(210, 330);
            this.txt_fatherID.Name = "txt_fatherID";
            this.txt_fatherID.Size = new System.Drawing.Size(654, 28);
            this.txt_fatherID.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "所属父菜单：";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 579);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 13;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MenuConfigControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_fatherID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_sortNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_showName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_className);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nameSpace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_dllName);
            this.Controls.Add(this.label1);
            this.Name = "MenuConfigControl";
            this.Size = new System.Drawing.Size(896, 638);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dllName;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_nameSpace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_className;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_showName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_sortNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_fatherID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}
