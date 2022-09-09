
namespace GenerateQRCode
{
    partial class Form1
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
            this.picture_qr = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_Level = new System.Windows.Forms.ComboBox();
            this.combo_Pixel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_code = new System.Windows.Forms.TextBox();
            this.btn_generate = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_qr)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_qr
            // 
            this.picture_qr.Location = new System.Drawing.Point(12, 12);
            this.picture_qr.Name = "picture_qr";
            this.picture_qr.Size = new System.Drawing.Size(300, 300);
            this.picture_qr.TabIndex = 0;
            this.picture_qr.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "ECCLevel:";
            // 
            // combo_Level
            // 
            this.combo_Level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Level.FormattingEnabled = true;
            this.combo_Level.Location = new System.Drawing.Point(79, 327);
            this.combo_Level.Name = "combo_Level";
            this.combo_Level.Size = new System.Drawing.Size(63, 20);
            this.combo_Level.TabIndex = 2;
            // 
            // combo_Pixel
            // 
            this.combo_Pixel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Pixel.FormattingEnabled = true;
            this.combo_Pixel.Location = new System.Drawing.Point(249, 327);
            this.combo_Pixel.Name = "combo_Pixel";
            this.combo_Pixel.Size = new System.Drawing.Size(63, 20);
            this.combo_Pixel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "pixel:";
            // 
            // text_code
            // 
            this.text_code.Location = new System.Drawing.Point(12, 360);
            this.text_code.Multiline = true;
            this.text_code.Name = "text_code";
            this.text_code.Size = new System.Drawing.Size(300, 89);
            this.text_code.TabIndex = 12;
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(12, 455);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(143, 33);
            this.btn_generate.TabIndex = 13;
            this.btn_generate.Text = "生成";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(169, 455);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(143, 33);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 504);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.text_code);
            this.Controls.Add(this.combo_Pixel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combo_Level);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picture_qr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picture_qr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_qr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_Level;
        private System.Windows.Forms.ComboBox combo_Pixel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_code;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Button btn_save;
    }
}

