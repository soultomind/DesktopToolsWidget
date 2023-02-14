namespace WinForm.DesktopToolsWidget
{
    partial class TitleWidgetWnd
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
            this._TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._LabelTitle = new System.Windows.Forms.Label();
            this._ContextMenuStrip.SuspendLayout();
            this._TableLayoutPanel.SuspendLayout();
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
            // _TableLayoutPanel
            // 
            this._TableLayoutPanel.ColumnCount = 1;
            this._TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._TableLayoutPanel.Controls.Add(this._LabelTitle, 0, 0);
            this._TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._TableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this._TableLayoutPanel.Name = "_TableLayoutPanel";
            this._TableLayoutPanel.RowCount = 2;
            this._TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.55939F));
            this._TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.44061F));
            this._TableLayoutPanel.Size = new System.Drawing.Size(284, 261);
            this._TableLayoutPanel.TabIndex = 1;
            // 
            // _LabelTitle
            // 
            this._LabelTitle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this._LabelTitle.ContextMenuStrip = this._ContextMenuStrip;
            this._LabelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this._LabelTitle.Font = new System.Drawing.Font("맑은 고딕", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this._LabelTitle.Location = new System.Drawing.Point(0, 0);
            this._LabelTitle.Margin = new System.Windows.Forms.Padding(0);
            this._LabelTitle.Name = "_LabelTitle";
            this._LabelTitle.Size = new System.Drawing.Size(284, 38);
            this._LabelTitle.TabIndex = 0;
            this._LabelTitle.Text = "Title";
            this._LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._LabelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelTitle_MouseDown);
            this._LabelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelTitle_MouseMove);
            this._LabelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabelTitle_MouseUp);
            // 
            // WidgetWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this._TableLayoutPanel);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WidgetWnd";
            this.Text = "WidgetWnd";
            this._ContextMenuStrip.ResumeLayout(false);
            this._TableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip _ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem _ToolStripMenuItemExitWnd;
        private System.Windows.Forms.TableLayoutPanel _TableLayoutPanel;
        private System.Windows.Forms.Label _LabelTitle;
    }
}