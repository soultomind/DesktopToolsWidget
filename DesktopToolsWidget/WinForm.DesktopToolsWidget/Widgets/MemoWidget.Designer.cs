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
            this._RichTextBox = new System.Windows.Forms.RichTextBox();
            this._TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._ToolStrip = new System.Windows.Forms.ToolStrip();
            this._TableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
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
            // _TableLayoutPanel
            // 
            this._TableLayoutPanel.ColumnCount = 1;
            this._TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._TableLayoutPanel.Controls.Add(this._RichTextBox, 0, 1);
            this._TableLayoutPanel.Controls.Add(this._ToolStrip, 0, 2);
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
            // _ToolStrip
            // 
            this._ToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ToolStrip.Location = new System.Drawing.Point(0, 265);
            this._ToolStrip.Name = "_ToolStrip";
            this._ToolStrip.Size = new System.Drawing.Size(500, 35);
            this._ToolStrip.TabIndex = 1;
            this._ToolStrip.Text = "toolStrip1";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox _RichTextBox;
        private System.Windows.Forms.TableLayoutPanel _TableLayoutPanel;
        private System.Windows.Forms.ToolStrip _ToolStrip;
    }
}
