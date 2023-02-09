namespace WinForm.DesktopToolsWidget.Widgets
{
    partial class FileSizeUnitConverterWidget
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
            this._TextBoxSize = new System.Windows.Forms.TextBox();
            this._TextBoxConvertSize = new System.Windows.Forms.TextBox();
            this._LabelFileSizeUnit = new System.Windows.Forms.Label();
            this._LabelConvertSize = new System.Windows.Forms.Label();
            this._LabelFileSizeUnitLength = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _TextBoxSize
            // 
            this._TextBoxSize.Location = new System.Drawing.Point(19, 44);
            this._TextBoxSize.MaxLength = 20;
            this._TextBoxSize.Name = "_TextBoxSize";
            this._TextBoxSize.Size = new System.Drawing.Size(100, 23);
            this._TextBoxSize.TabIndex = 0;
            this._TextBoxSize.TextChanged += new System.EventHandler(this.TextBoxSize_TextChanged);
            this._TextBoxSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxSize_KeyDown);
            // 
            // _TextBoxConvertSize
            // 
            this._TextBoxConvertSize.Location = new System.Drawing.Point(155, 153);
            this._TextBoxConvertSize.Name = "_TextBoxConvertSize";
            this._TextBoxConvertSize.ReadOnly = true;
            this._TextBoxConvertSize.Size = new System.Drawing.Size(100, 23);
            this._TextBoxConvertSize.TabIndex = 1;
            // 
            // _LabelFileSizeUnit
            // 
            this._LabelFileSizeUnit.AutoSize = true;
            this._LabelFileSizeUnit.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this._LabelFileSizeUnit.Location = new System.Drawing.Point(16, 26);
            this._LabelFileSizeUnit.Name = "_LabelFileSizeUnit";
            this._LabelFileSizeUnit.Size = new System.Drawing.Size(81, 17);
            this._LabelFileSizeUnit.TabIndex = 2;
            this._LabelFileSizeUnit.Text = "FileSizeUnit";
            // 
            // _LabelConvertSize
            // 
            this._LabelConvertSize.AutoSize = true;
            this._LabelConvertSize.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this._LabelConvertSize.Location = new System.Drawing.Point(152, 135);
            this._LabelConvertSize.Name = "_LabelConvertSize";
            this._LabelConvertSize.Size = new System.Drawing.Size(80, 17);
            this._LabelConvertSize.TabIndex = 3;
            this._LabelConvertSize.Text = "ConvertSize";
            // 
            // _LabelFileSizeUnitLength
            // 
            this._LabelFileSizeUnitLength.AutoSize = true;
            this._LabelFileSizeUnitLength.Location = new System.Drawing.Point(16, 82);
            this._LabelFileSizeUnitLength.Name = "_LabelFileSizeUnitLength";
            this._LabelFileSizeUnitLength.Size = new System.Drawing.Size(84, 15);
            this._LabelFileSizeUnitLength.TabIndex = 4;
            this._LabelFileSizeUnitLength.Text = "TextLength : 0";
            // 
            // FileSizeUnitConverterWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._LabelFileSizeUnitLength);
            this.Controls.Add(this._LabelConvertSize);
            this.Controls.Add(this._LabelFileSizeUnit);
            this.Controls.Add(this._TextBoxConvertSize);
            this.Controls.Add(this._TextBoxSize);
            this.Name = "FileSizeUnitConverterWidget";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _TextBoxSize;
        private System.Windows.Forms.TextBox _TextBoxConvertSize;
        private System.Windows.Forms.Label _LabelFileSizeUnit;
        private System.Windows.Forms.Label _LabelConvertSize;
        private System.Windows.Forms.Label _LabelFileSizeUnitLength;
    }
}
