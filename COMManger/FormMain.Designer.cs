namespace COMManger
{
    partial class FormMain
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.COMList = new System.Windows.Forms.ListView();
            this.BT_Delete = new System.Windows.Forms.Button();
            this.CB_Language = new System.Windows.Forms.ComboBox();
            this.BT_Clear = new System.Windows.Forms.Button();
            this.BT_Save = new System.Windows.Forms.Button();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // COMList
            // 
            resources.ApplyResources(this.COMList, "COMList");
            this.COMList.LargeImageList = this.ImageList;
            this.COMList.Name = "COMList";
            this.COMList.SmallImageList = this.ImageList;
            this.COMList.TileSize = new System.Drawing.Size(120, 20);
            this.COMList.UseCompatibleStateImageBehavior = false;
            this.COMList.View = System.Windows.Forms.View.SmallIcon;
            // 
            // BT_Delete
            // 
            resources.ApplyResources(this.BT_Delete, "BT_Delete");
            this.BT_Delete.Name = "BT_Delete";
            this.BT_Delete.UseVisualStyleBackColor = true;
            this.BT_Delete.Click += new System.EventHandler(this.BT_Delete_Click);
            // 
            // CB_Language
            // 
            resources.ApplyResources(this.CB_Language, "CB_Language");
            this.CB_Language.FormattingEnabled = true;
            this.CB_Language.Items.AddRange(new object[] {
            resources.GetString("CB_Language.Items"),
            resources.GetString("CB_Language.Items1")});
            this.CB_Language.Name = "CB_Language";
            this.CB_Language.SelectedIndexChanged += new System.EventHandler(this.CB_Language_SelectedIndexChanged);
            // 
            // BT_Clear
            // 
            resources.ApplyResources(this.BT_Clear, "BT_Clear");
            this.BT_Clear.Name = "BT_Clear";
            this.BT_Clear.UseVisualStyleBackColor = true;
            this.BT_Clear.Click += new System.EventHandler(this.BT_Clear_Click);
            // 
            // BT_Save
            // 
            this.BT_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.BT_Save, "BT_Save");
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.UseVisualStyleBackColor = false;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "Port.png");
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.BT_Clear);
            this.Controls.Add(this.CB_Language);
            this.Controls.Add(this.BT_Delete);
            this.Controls.Add(this.COMList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView COMList;
        private System.Windows.Forms.Button BT_Delete;
        private System.Windows.Forms.ComboBox CB_Language;
        private System.Windows.Forms.Button BT_Clear;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.ImageList ImageList;
    }
}

