﻿namespace WinForm.DesktopToolsWidget.Widgets
{
    partial class AsCodeConverterWidget
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
            this._TextBoxHexadecimal = new System.Windows.Forms.TextBox();
            this._TextBoxBinary = new System.Windows.Forms.TextBox();
            this._TextboxOctal = new System.Windows.Forms.TextBox();
            this._TextBoxDecimal = new System.Windows.Forms.TextBox();
            this._LabelHexadecimal = new System.Windows.Forms.Label();
            this._LabelDecimal = new System.Windows.Forms.Label();
            this._LabelOctal = new System.Windows.Forms.Label();
            this._LabelBinary = new System.Windows.Forms.Label();
            this._TextBoxInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _TextBoxHexadecimal
            // 
            this._TextBoxHexadecimal.Location = new System.Drawing.Point(124, 54);
            this._TextBoxHexadecimal.Name = "_TextBoxHexadecimal";
            this._TextBoxHexadecimal.Size = new System.Drawing.Size(129, 23);
            this._TextBoxHexadecimal.TabIndex = 3;
            // 
            // _TextBoxBinary
            // 
            this._TextBoxBinary.Location = new System.Drawing.Point(124, 150);
            this._TextBoxBinary.Name = "_TextBoxBinary";
            this._TextBoxBinary.Size = new System.Drawing.Size(129, 23);
            this._TextBoxBinary.TabIndex = 9;
            // 
            // _TextboxOctal
            // 
            this._TextboxOctal.Location = new System.Drawing.Point(124, 117);
            this._TextboxOctal.Name = "_TextboxOctal";
            this._TextboxOctal.Size = new System.Drawing.Size(129, 23);
            this._TextboxOctal.TabIndex = 7;
            // 
            // _TextBoxDecimal
            // 
            this._TextBoxDecimal.Location = new System.Drawing.Point(124, 85);
            this._TextBoxDecimal.Name = "_TextBoxDecimal";
            this._TextBoxDecimal.Size = new System.Drawing.Size(129, 23);
            this._TextBoxDecimal.TabIndex = 5;
            // 
            // _LabelHexadecimal
            // 
            this._LabelHexadecimal.AutoSize = true;
            this._LabelHexadecimal.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this._LabelHexadecimal.Location = new System.Drawing.Point(20, 54);
            this._LabelHexadecimal.Name = "_LabelHexadecimal";
            this._LabelHexadecimal.Size = new System.Drawing.Size(81, 15);
            this._LabelHexadecimal.TabIndex = 2;
            this._LabelHexadecimal.Text = "Hexadecimal";
            // 
            // _LabelDecimal
            // 
            this._LabelDecimal.AutoSize = true;
            this._LabelDecimal.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this._LabelDecimal.Location = new System.Drawing.Point(20, 88);
            this._LabelDecimal.Name = "_LabelDecimal";
            this._LabelDecimal.Size = new System.Drawing.Size(53, 15);
            this._LabelDecimal.TabIndex = 4;
            this._LabelDecimal.Text = "Decimal";
            // 
            // _LabelOctal
            // 
            this._LabelOctal.AutoSize = true;
            this._LabelOctal.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this._LabelOctal.Location = new System.Drawing.Point(20, 120);
            this._LabelOctal.Name = "_LabelOctal";
            this._LabelOctal.Size = new System.Drawing.Size(37, 15);
            this._LabelOctal.TabIndex = 6;
            this._LabelOctal.Text = "Octal";
            // 
            // _LabelBinary
            // 
            this._LabelBinary.AutoSize = true;
            this._LabelBinary.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this._LabelBinary.Location = new System.Drawing.Point(20, 150);
            this._LabelBinary.Name = "_LabelBinary";
            this._LabelBinary.Size = new System.Drawing.Size(43, 15);
            this._LabelBinary.TabIndex = 8;
            this._LabelBinary.Text = "Binary";
            // 
            // _TextBoxInput
            // 
            this._TextBoxInput.Location = new System.Drawing.Point(18, 14);
            this._TextBoxInput.Name = "_TextBoxInput";
            this._TextBoxInput.Size = new System.Drawing.Size(194, 23);
            this._TextBoxInput.TabIndex = 1;
            this._TextBoxInput.TextChanged += new System.EventHandler(this.TextBoxInput_TextChanged);
            // 
            // AsCodeConverterWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._TextBoxInput);
            this.Controls.Add(this._TextBoxBinary);
            this.Controls.Add(this._TextboxOctal);
            this.Controls.Add(this._TextBoxDecimal);
            this.Controls.Add(this._LabelHexadecimal);
            this.Controls.Add(this._LabelDecimal);
            this.Controls.Add(this._LabelOctal);
            this.Controls.Add(this._LabelBinary);
            this.Controls.Add(this._TextBoxHexadecimal);
            this.Name = "AsCodeConverterWidget";
            this.Size = new System.Drawing.Size(278, 195);
            this.Load += new System.EventHandler(this.AsCodeConverterWidget_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _TextBoxHexadecimal;
        private System.Windows.Forms.TextBox _TextBoxBinary;
        private System.Windows.Forms.TextBox _TextboxOctal;
        private System.Windows.Forms.TextBox _TextBoxDecimal;
        private System.Windows.Forms.Label _LabelHexadecimal;
        private System.Windows.Forms.Label _LabelDecimal;
        private System.Windows.Forms.Label _LabelOctal;
        private System.Windows.Forms.Label _LabelBinary;
        private System.Windows.Forms.TextBox _TextBoxInput;
    }
}
