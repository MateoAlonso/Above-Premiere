using Above_Premiere.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Above_Premiere
{
    public partial class Form1 : Form
    {
        private int option;
        private string file;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.ShowDialog();
            string outputPath = saveFileDialog1.FileName;
            switch (option)
            {

                case 1:
                    Shell.convertVideo(this.file, 1, outputPath);
                    break;

                case 2:
                    Shell.convertVideo(this.file, 2, outputPath);
                    break;

                case 3:
                    Shell.convertVideo(this.file, 3, outputPath);
                    break;

                case 4:
                    Shell.convertVideo(this.file, 4, outputPath);
                    break;

                case 5:
                   Shell.extractAudio(this.file, outputPath);
                    break;

                case 6:
                    Shell.changeRes(this.file, Int32.Parse(this.textBoxX.Text), Int32.Parse(this.textBoxY.Text), outputPath);
                    break;

                case 7:
                    Shell.removeAudio(this.file, outputPath);
                    break;

                case 8:
                    Shell.extractImgXFrames(this.file, Int32.Parse(this.textBoxFrames.Text), outputPath);
                    break;

                default:
                    break;
            }
        }

        private void radioButtonCambiarFormato_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonCambiarFormato.Checked)
            {
                this.panelCambiarFormato.Visible = true;
            }
            else
            {
                this.panelCambiarFormato.Visible = false;
            }

            
        }

        private void radioButtonExtraerAudiomp3_CheckedChanged(object sender, EventArgs e)
        {
            this.option = 5;
        }

        private void radioButtonCambiarResolucion_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonCambiarResolucion.Checked)
            {
                this.panelRes.Visible = true;
            }
            else
            {
                this.panelRes.Visible = false;
            }
            this.option = 6;

        }

        private void radioButtonRemoverAudio_CheckedChanged(object sender, EventArgs e)
        {
            this.option = 7;
        }

        private void radioButtonExtraerimg_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonExtraerimg.Checked)
            {
                this.panelFrames.Visible = true;
            }
            else
            {
                this.panelFrames.Visible = false;
            }
            this.option = 8;
        }

        private void panelFrames_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxFrames_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelCambiarFormato_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void radioButtonmp4_CheckedChanged(object sender, EventArgs e)
        {
            this.option = 1;
        }

        private void radioButtonavi_CheckedChanged(object sender, EventArgs e)
        {
            this.option = 2;
        }

        private void radioButtonmpeg_CheckedChanged(object sender, EventArgs e)
        {
            this.option = 3;
        }

        private void radioButtonflv_CheckedChanged(object sender, EventArgs e)
        {
            this.option = 4;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.file = openFileDialog1.FileName;
            }
        }

        private void buttonOutputDirectory_Click(object sender, EventArgs e)
        {

        }
    }
}
