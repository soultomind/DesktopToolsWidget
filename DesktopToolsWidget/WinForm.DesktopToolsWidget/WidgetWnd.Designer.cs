namespace WinForm.DesktopToolsWidget
{
    partial class WidgetWnd
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
            this._ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._ToolStripMenuItemExitWnd = new System.Windows.Forms.ToolStripMenuItem();
            this._ContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _ContextMenuStrip
            // 
            this._ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._ToolStripMenuItemExitWnd});
            this._ContextMenuStrip.Name = "_ContextMenuStrip";
            this._ContextMenuStrip.Size = new System.Drawing.Size(94, 26);
            // 
            // _ToolStripMenuItemExitWnd
            // 
            this._ToolStripMenuItemExitWnd.Name = "_ToolStripMenuItemExitWnd";
            this._ToolStripMenuItemExitWnd.Size = new System.Drawing.Size(93, 22);
            this._ToolStripMenuItemExitWnd.Text = "Exit";
            this._ToolStripMenuItemExitWnd.Click += new System.EventHandler(this.ToolStripMenuItemExitWnd_Click);
            // 
            // WidgetWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WidgetWnd";
            this.Text = "WidgetWnd";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.WidgetWnd_MouseClick);
            this._ContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip _ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem _ToolStripMenuItemExitWnd;
    }
}