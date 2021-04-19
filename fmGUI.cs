using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smvpatcher
{
    public partial class fmGUI : Form
    {
        private string smv { get; set; }

        public fmGUI()
        {
            InitializeComponent();
        }

        private void fmGUI_Load(object sender, EventArgs e)
        {
            smv = Path.GetTempFileName();
            File.WriteAllBytes(smv, Properties.Resources.smv);

            num_blocksize.SelectedIndex = num_blocksize.Items.Count - 2;
            num_minalign.SelectedIndex = num_minalign.Items.Count - 1;
            combo_ratio.SelectedIndex = 0;
        }

        private async void btn_start_Click(object sender, EventArgs e)
        {
            var old_file = tb_oldfile.Text;
            var new_file = tb_newfile.Text;
            var svf_file = tb_svfile.Text;
            var block_arg = $"-blocksize {num_blocksize.Text} -minalign {num_minalign.Text}";
            var hash_arg = $"{(chk_nomd5.Checked ? "" : " -nomd5")}{(chk_sha1.Checked ? " -sha1" : "")}{(chk_sha256.Checked ? " -sha256" : "")}";
            var compressratio = "-compressratio ";
            if (rdb_zlib.Checked) compressratio += combo_ratio.SelectedIndex == 0 ? "1" : "9";
            if (rdb_lz4.Checked) compressratio += combo_ratio.SelectedIndex == 0 ? "368" : "392";
            if (rdb_zstd.Checked) compressratio += combo_ratio.SelectedIndex == 0 ? "171" : "192";
            if (rdb_lzma.Checked) compressratio += combo_ratio.SelectedIndex == 0 ? "41" : "49";
            if (rdb_zliblzma.Checked) compressratio += combo_ratio.SelectedIndex == 0 ? "51" : "59";
            var arg = $"BuildPatch \"{svf_file}\" \"{old_file}\" \"{new_file}\" {block_arg} {compressratio} {hash_arg}";

            if (!File.Exists(old_file)) return;
            if (!File.Exists(new_file)) return;
            if (string.IsNullOrEmpty(new_file)) return;
            if (File.Exists(svf_file))
            {

            }
            groupBox1.Enabled = groupBox2.Enabled = groupBox3.Enabled = groupBox4.Enabled = btn_start.Enabled = false;
            await Task.Run(() =>
            {
                 var p = new Process
                 {
                     StartInfo = new ProcessStartInfo
                     {
                         FileName = smv,
                         Arguments = arg,
                         UseShellExecute = false,
                         CreateNoWindow = true
                     }
                 };
                 p.Start();
                 p.WaitForExit();
            });
            groupBox1.Enabled = groupBox2.Enabled = groupBox3.Enabled = groupBox4.Enabled = btn_start.Enabled = true;
            SystemSounds.Asterisk.Play();
        }

        private void tb_file_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ((TextBox)sender).Text = ofd.FileName;
            }
        }

        private void tb_svfile_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog
            {
                Filter = "SmartVersion Files|*.svf"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ((TextBox)sender).Text = sfd.FileName;
            }
        }

        private void tb_file_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
        }

        private void tb_file_DragDrop(object sender, DragEventArgs e)
        {
            string[] file = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (file.Length > 0)
            {
                ((TextBox)sender).Text = file[0];
            }
        }

        private void fmGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.Delete(smv);
        }
    }
}
