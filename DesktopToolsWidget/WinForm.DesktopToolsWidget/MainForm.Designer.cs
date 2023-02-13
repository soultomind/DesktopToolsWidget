namespace WinForm.DesktopToolsWidget
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this._ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._ToolStripMenuItemAsCodeConverter = new System.Windows.Forms.ToolStripMenuItem();
            this._ToolStripMenuItemFileSizeUnitConverter = new System.Windows.Forms.ToolStripMenuItem();
            this._ToolStripMenuItemMemo = new System.Windows.Forms.ToolStripMenuItem();
            this._ToolStripMenuItemApplicationExit = new System.Windows.Forms.ToolStripMenuItem();
            this._ContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _NotifyIcon
            // 
            this._NotifyIcon.ContextMenuStrip = this._ContextMenuStrip;
            this._NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("_NotifyIcon.Icon")));
            this._NotifyIcon.Text = "WinForm.DesktopWidget";
            this._NotifyIcon.Visible = true;
            this._NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // _ContextMenuStrip
            // 
            this._ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._ToolStripMenuItemAsCodeConverter,
            this._ToolStripMenuItemFileSizeUnitConverter,
            this._ToolStripMenuItemMemo,
            this._ToolStripMenuItemApplicationExit});
            this._ContextMenuStrip.Name = "_ContextMenuStrip";
            this._ContextMenuStrip.ShowCheckMargin = true;
            this._ContextMenuStrip.Size = new System.Drawing.Size(215, 92);
            // 
            // _ToolStripMenuItemAsCodeConverter
            // 
            this._ToolStripMenuItemAsCodeConverter.Name = "_ToolStripMenuItemAsCodeConverter";
            this._ToolStripMenuItemAsCodeConverter.Size = new System.Drawing.Size(214, 22);
            this._ToolStripMenuItemAsCodeConverter.Text = "AsCode Converter";
            this._ToolStripMenuItemAsCodeConverter.Click += new System.EventHandler(this.ToolStripMenuItemAsCodeConverter_Click);
            // 
            // _ToolStripMenuItemFileSizeUnitConverter
            // 
            this._ToolStripMenuItemFileSizeUnitConverter.Name = "_ToolStripMenuItemFileSizeUnitConverter";
            this._ToolStripMenuItemFileSizeUnitConverter.Size = new System.Drawing.Size(214, 22);
            this._ToolStripMenuItemFileSizeUnitConverter.Text = "FileSizeUnit Converter";
            this._ToolStripMenuItemFileSizeUnitConverter.Click += new System.EventHandler(this.ToolStripMenuItemFileSizeUnitConverter_Click);
            // 
            // _ToolStripMenuItemMemo
            // 
            this._ToolStripMenuItemMemo.Name = "_ToolStripMenuItemMemo";
            this._ToolStripMenuItemMemo.Size = new System.Drawing.Size(214, 22);
            this._ToolStripMenuItemMemo.Text = "Memo";
            this._ToolStripMenuItemMemo.Click += new System.EventHandler(this.ToolStripMenuItemMemo_Click);
            // 
            // _ToolStripMenuItemApplicationExit
            // 
            this._ToolStripMenuItemApplicationExit.Name = "_ToolStripMenuItemApplicationExit";
            this._ToolStripMenuItemApplicationExit.Size = new System.Drawing.Size(214, 22);
            this._ToolStripMenuItemApplicationExit.Text = "Exit";
            this._ToolStripMenuItemApplicationExit.Click += new System.EventHandler(this.ToolStripMenuItemApplicationExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this._ContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon _NotifyIcon;
        private System.Windows.Forms.ContextMenuStrip _ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem _ToolStripMenuItemApplicationExit;
        private System.Windows.Forms.ToolStripMenuItem _ToolStripMenuItemAsCodeConverter;
        private System.Windows.Forms.ToolStripMenuItem _ToolStripMenuItemFileSizeUnitConverter;
        private System.Windows.Forms.ToolStripMenuItem _ToolStripMenuItemMemo;
    }
}

