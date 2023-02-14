namespace WinForm.DesktopToolsWidget.Widgets
{
    partial class MemoWidget
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this._TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._RichTextBox = new System.Windows.Forms.RichTextBox();
            this._ToolStrip = new System.Windows.Forms.ToolStrip();
            this._PanelTitle = new System.Windows.Forms.Panel();
            this._LabelNewMemo = new System.Windows.Forms.Label();
            this._LabelMenu = new System.Windows.Forms.Label();
            this._LabelClose = new System.Windows.Forms.Label();
            this._TableLayoutPanel.SuspendLayout();
            this._PanelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // _TableLayoutPanel
            // 
            this._TableLayoutPanel.ColumnCount = 1;
            this._TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._TableLayoutPanel.Controls.Add(this._RichTextBox, 0, 1);
            this._TableLayoutPanel.Controls.Add(this._ToolStrip, 0, 2);
            this._TableLayoutPanel.Controls.Add(this._PanelTitle, 0, 0);
            this._TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._TableLayoutPanel.Name = "_TableLayoutPanel";
            this._TableLayoutPanel.RowCount = 3;
            this._TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this._TableLayoutPanel.Size = new System.Drawing.Size(500, 300);
            this._TableLayoutPanel.TabIndex = 2;
            // 
            // _RichTextBox
            // 
            this._RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._RichTextBox.Location = new System.Drawing.Point(3, 43);
            this._RichTextBox.Name = "_RichTextBox";
            this._RichTextBox.Size = new System.Drawing.Size(494, 219);
            this._RichTextBox.TabIndex = 0;
            this._RichTextBox.Text = "";
            // 
            // _ToolStrip
            // 
            this._ToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ToolStrip.Location = new System.Drawing.Point(0, 265);
            this._ToolStrip.Name = "_ToolStrip";
            this._ToolStrip.Size = new System.Drawing.Size(500, 35);
            this._ToolStrip.TabIndex = 1;
            this._ToolStrip.Text = "toolStrip1";
            // 
            // _PanelTitle
            // 
            this._PanelTitle.Controls.Add(this._LabelNewMemo);
            this._PanelTitle.Controls.Add(this._LabelMenu);
            this._PanelTitle.Controls.Add(this._LabelClose);
            this._PanelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this._PanelTitle.Location = new System.Drawing.Point(0, 0);
            this._PanelTitle.Margin = new System.Windows.Forms.Padding(0);
            this._PanelTitle.Name = "_PanelTitle";
            this._PanelTitle.Size = new System.Drawing.Size(500, 40);
            this._PanelTitle.TabIndex = 2;
            this._PanelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitle_MouseDown);
            this._PanelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelTitle_MouseMove);
            this._PanelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelTitle_MouseUp);
            // 
            // _LabelNewMemo
            // 
            this._LabelNewMemo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this._LabelNewMemo.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this._LabelNewMemo.Location = new System.Drawing.Point(3, 4);
            this._LabelNewMemo.Name = "_LabelNewMemo";
            this._LabelNewMemo.Size = new System.Drawing.Size(49, 30);
            this._LabelNewMemo.TabIndex = 2;
            this._LabelNewMemo.Text = "추가";
            this._LabelNewMemo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._LabelNewMemo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelNewMemo_MouseDown);
            this._LabelNewMemo.MouseEnter += new System.EventHandler(this.LabelNewMemo_MouseEnter);
            this._LabelNewMemo.MouseLeave += new System.EventHandler(this.LabelNewMemo_MouseLeave);
            // 
            // _LabelMenu
            // 
            this._LabelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._LabelMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this._LabelMenu.Location = new System.Drawing.Point(393, 4);
            this._LabelMenu.Name = "_LabelMenu";
            this._LabelMenu.Size = new System.Drawing.Size(49, 30);
            this._LabelMenu.TabIndex = 1;
            this._LabelMenu.Text = "...";
            this._LabelMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _LabelClose
            // 
            this._LabelClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._LabelClose.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this._LabelClose.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this._LabelClose.Location = new System.Drawing.Point(448, 4);
            this._LabelClose.Name = "_LabelClose";
            this._LabelClose.Size = new System.Drawing.Size(49, 30);
            this._LabelClose.TabIndex = 0;
            this._LabelClose.Text = "종료";
            this._LabelClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._LabelClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelClose_MouseDown);
            this._LabelClose.MouseEnter += new System.EventHandler(this.LabelClose_MouseEnter);
            this._LabelClose.MouseLeave += new System.EventHandler(this.LabelClose_MouseLeave);
            // 
            // MemoWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._TableLayoutPanel);
            this.Name = "MemoWidget";
            this.Size = new System.Drawing.Size(500, 300);
            this._TableLayoutPanel.ResumeLayout(false);
            this._TableLayoutPanel.PerformLayout();
            this._PanelTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox _RichTextBox;
        private System.Windows.Forms.TableLayoutPanel _TableLayoutPanel;
        private System.Windows.Forms.ToolStrip _ToolStrip;
        private System.Windows.Forms.Panel _PanelTitle;
        private System.Windows.Forms.Label _LabelNewMemo;
        private System.Windows.Forms.Label _LabelMenu;
        private System.Windows.Forms.Label _LabelClose;
    }
}
