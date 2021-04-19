
namespace smvpatcher
{
    partial class fmGUI
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_svfile = new System.Windows.Forms.TextBox();
            this.tb_newfile = new System.Windows.Forms.TextBox();
            this.tb_oldfile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.num_minalign = new System.Windows.Forms.DomainUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.num_blocksize = new System.Windows.Forms.DomainUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.combo_ratio = new System.Windows.Forms.ComboBox();
            this.rdb_zliblzma = new System.Windows.Forms.RadioButton();
            this.rdb_lzma = new System.Windows.Forms.RadioButton();
            this.rdb_zstd = new System.Windows.Forms.RadioButton();
            this.rdb_lz4 = new System.Windows.Forms.RadioButton();
            this.rdb_zlib = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chk_sha256 = new System.Windows.Forms.CheckBox();
            this.chk_sha1 = new System.Windows.Forms.CheckBox();
            this.chk_nomd5 = new System.Windows.Forms.CheckBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old File:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "New File:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Svf File:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_svfile);
            this.groupBox1.Controls.Add(this.tb_newfile);
            this.groupBox1.Controls.Add(this.tb_oldfile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 160);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File";
            // 
            // tb_svfile
            // 
            this.tb_svfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_svfile.Location = new System.Drawing.Point(78, 105);
            this.tb_svfile.Name = "tb_svfile";
            this.tb_svfile.Size = new System.Drawing.Size(660, 26);
            this.tb_svfile.TabIndex = 5;
            this.tb_svfile.TabStop = false;
            this.tb_svfile.Click += new System.EventHandler(this.tb_svfile_Click);
            // 
            // tb_newfile
            // 
            this.tb_newfile.AllowDrop = true;
            this.tb_newfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_newfile.Location = new System.Drawing.Point(78, 67);
            this.tb_newfile.Name = "tb_newfile";
            this.tb_newfile.Size = new System.Drawing.Size(660, 26);
            this.tb_newfile.TabIndex = 4;
            this.tb_newfile.TabStop = false;
            this.tb_newfile.Click += new System.EventHandler(this.tb_file_Click);
            this.tb_newfile.DragDrop += new System.Windows.Forms.DragEventHandler(this.tb_file_DragDrop);
            this.tb_newfile.DragEnter += new System.Windows.Forms.DragEventHandler(this.tb_file_DragEnter);
            // 
            // tb_oldfile
            // 
            this.tb_oldfile.AllowDrop = true;
            this.tb_oldfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_oldfile.Location = new System.Drawing.Point(78, 29);
            this.tb_oldfile.Name = "tb_oldfile";
            this.tb_oldfile.Size = new System.Drawing.Size(660, 26);
            this.tb_oldfile.TabIndex = 3;
            this.tb_oldfile.TabStop = false;
            this.tb_oldfile.Click += new System.EventHandler(this.tb_file_Click);
            this.tb_oldfile.DragDrop += new System.Windows.Forms.DragEventHandler(this.tb_file_DragDrop);
            this.tb_oldfile.DragEnter += new System.Windows.Forms.DragEventHandler(this.tb_file_DragEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "blocksize:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.num_minalign);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.num_blocksize);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(13, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 120);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Block";
            // 
            // num_minalign
            // 
            this.num_minalign.Items.Add("2048");
            this.num_minalign.Items.Add("1024");
            this.num_minalign.Items.Add("512");
            this.num_minalign.Location = new System.Drawing.Point(81, 68);
            this.num_minalign.Name = "num_minalign";
            this.num_minalign.Size = new System.Drawing.Size(101, 26);
            this.num_minalign.TabIndex = 7;
            this.num_minalign.TabStop = false;
            this.num_minalign.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "minalign:";
            // 
            // num_blocksize
            // 
            this.num_blocksize.Items.Add("16384");
            this.num_blocksize.Items.Add("8192");
            this.num_blocksize.Items.Add("4096");
            this.num_blocksize.Items.Add("2048");
            this.num_blocksize.Location = new System.Drawing.Point(82, 30);
            this.num_blocksize.Name = "num_blocksize";
            this.num_blocksize.Size = new System.Drawing.Size(100, 26);
            this.num_blocksize.TabIndex = 5;
            this.num_blocksize.TabStop = false;
            this.num_blocksize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.combo_ratio);
            this.groupBox3.Controls.Add(this.rdb_zliblzma);
            this.groupBox3.Controls.Add(this.rdb_lzma);
            this.groupBox3.Controls.Add(this.rdb_zstd);
            this.groupBox3.Controls.Add(this.rdb_lz4);
            this.groupBox3.Controls.Add(this.rdb_zlib);
            this.groupBox3.Location = new System.Drawing.Point(239, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(218, 120);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Compress Ratio";
            // 
            // combo_ratio
            // 
            this.combo_ratio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_ratio.FormattingEnabled = true;
            this.combo_ratio.Items.AddRange(new object[] {
            "faster",
            "smaller"});
            this.combo_ratio.Location = new System.Drawing.Point(102, 81);
            this.combo_ratio.Name = "combo_ratio";
            this.combo_ratio.Size = new System.Drawing.Size(97, 26);
            this.combo_ratio.TabIndex = 5;
            this.combo_ratio.TabStop = false;
            // 
            // rdb_zliblzma
            // 
            this.rdb_zliblzma.AutoSize = true;
            this.rdb_zliblzma.Location = new System.Drawing.Point(118, 53);
            this.rdb_zliblzma.Name = "rdb_zliblzma";
            this.rdb_zliblzma.Size = new System.Drawing.Size(86, 22);
            this.rdb_zliblzma.TabIndex = 4;
            this.rdb_zliblzma.Text = "zlib+lzma";
            this.rdb_zliblzma.UseVisualStyleBackColor = true;
            // 
            // rdb_lzma
            // 
            this.rdb_lzma.AutoSize = true;
            this.rdb_lzma.Location = new System.Drawing.Point(118, 25);
            this.rdb_lzma.Name = "rdb_lzma";
            this.rdb_lzma.Size = new System.Drawing.Size(56, 22);
            this.rdb_lzma.TabIndex = 3;
            this.rdb_lzma.Text = "lzma";
            this.rdb_lzma.UseVisualStyleBackColor = true;
            // 
            // rdb_zstd
            // 
            this.rdb_zstd.AutoSize = true;
            this.rdb_zstd.Checked = true;
            this.rdb_zstd.Location = new System.Drawing.Point(22, 81);
            this.rdb_zstd.Name = "rdb_zstd";
            this.rdb_zstd.Size = new System.Drawing.Size(53, 22);
            this.rdb_zstd.TabIndex = 2;
            this.rdb_zstd.TabStop = true;
            this.rdb_zstd.Text = "zstd";
            this.rdb_zstd.UseVisualStyleBackColor = true;
            // 
            // rdb_lz4
            // 
            this.rdb_lz4.AutoSize = true;
            this.rdb_lz4.Location = new System.Drawing.Point(22, 53);
            this.rdb_lz4.Name = "rdb_lz4";
            this.rdb_lz4.Size = new System.Drawing.Size(82, 22);
            this.rdb_lz4.TabIndex = 1;
            this.rdb_lz4.Text = "lz4frame";
            this.rdb_lz4.UseVisualStyleBackColor = true;
            // 
            // rdb_zlib
            // 
            this.rdb_zlib.AutoSize = true;
            this.rdb_zlib.Location = new System.Drawing.Point(22, 25);
            this.rdb_zlib.Name = "rdb_zlib";
            this.rdb_zlib.Size = new System.Drawing.Size(45, 22);
            this.rdb_zlib.TabIndex = 0;
            this.rdb_zlib.Text = "zlib";
            this.rdb_zlib.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chk_sha256);
            this.groupBox4.Controls.Add(this.chk_sha1);
            this.groupBox4.Controls.Add(this.chk_nomd5);
            this.groupBox4.Location = new System.Drawing.Point(463, 179);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(113, 120);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hash";
            // 
            // chk_sha256
            // 
            this.chk_sha256.AutoSize = true;
            this.chk_sha256.Location = new System.Drawing.Point(16, 81);
            this.chk_sha256.Name = "chk_sha256";
            this.chk_sha256.Size = new System.Drawing.Size(83, 22);
            this.chk_sha256.TabIndex = 2;
            this.chk_sha256.Text = "SHA-256";
            this.chk_sha256.UseVisualStyleBackColor = true;
            // 
            // chk_sha1
            // 
            this.chk_sha1.AutoSize = true;
            this.chk_sha1.Location = new System.Drawing.Point(16, 53);
            this.chk_sha1.Name = "chk_sha1";
            this.chk_sha1.Size = new System.Drawing.Size(67, 22);
            this.chk_sha1.TabIndex = 1;
            this.chk_sha1.Text = "SHA-1";
            this.chk_sha1.UseVisualStyleBackColor = true;
            // 
            // chk_nomd5
            // 
            this.chk_nomd5.AutoSize = true;
            this.chk_nomd5.Checked = true;
            this.chk_nomd5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_nomd5.Location = new System.Drawing.Point(16, 25);
            this.chk_nomd5.Name = "chk_nomd5";
            this.chk_nomd5.Size = new System.Drawing.Size(57, 22);
            this.chk_nomd5.TabIndex = 0;
            this.chk_nomd5.Text = "MD5";
            this.chk_nomd5.UseVisualStyleBackColor = true;
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(592, 189);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(180, 110);
            this.btn_start.TabIndex = 8;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // fmGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 311);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartVersion Patcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmGUI_FormClosing);
            this.Load += new System.EventHandler(this.fmGUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_svfile;
        private System.Windows.Forms.TextBox tb_newfile;
        private System.Windows.Forms.TextBox tb_oldfile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DomainUpDown num_blocksize;
        private System.Windows.Forms.DomainUpDown num_minalign;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdb_zstd;
        private System.Windows.Forms.RadioButton rdb_lz4;
        private System.Windows.Forms.RadioButton rdb_zlib;
        private System.Windows.Forms.RadioButton rdb_lzma;
        private System.Windows.Forms.RadioButton rdb_zliblzma;
        private System.Windows.Forms.ComboBox combo_ratio;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chk_nomd5;
        private System.Windows.Forms.CheckBox chk_sha1;
        private System.Windows.Forms.CheckBox chk_sha256;
        private System.Windows.Forms.Button btn_start;
    }
}

