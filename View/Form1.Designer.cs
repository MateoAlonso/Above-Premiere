
namespace Above_Premiere
{
    partial class Form1
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
            this.buttonEjecutar = new System.Windows.Forms.Button();
            this.radioButtonCambiarFormato = new System.Windows.Forms.RadioButton();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.radioButtonExtraerimg = new System.Windows.Forms.RadioButton();
            this.radioButtonRemoverAudio = new System.Windows.Forms.RadioButton();
            this.radioButtonCambiarResolucion = new System.Windows.Forms.RadioButton();
            this.radioButtonExtraerAudiomp3 = new System.Windows.Forms.RadioButton();
            this.panelCambiarFormato = new System.Windows.Forms.Panel();
            this.radioButtonflv = new System.Windows.Forms.RadioButton();
            this.radioButtonmpeg = new System.Windows.Forms.RadioButton();
            this.radioButtonavi = new System.Windows.Forms.RadioButton();
            this.radioButtonmp4 = new System.Windows.Forms.RadioButton();
            this.panelFrames = new System.Windows.Forms.Panel();
            this.textBoxFrames = new System.Windows.Forms.TextBox();
            this.panelRes = new System.Windows.Forms.Panel();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonVideoDirectory = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelOpciones.SuspendLayout();
            this.panelCambiarFormato.SuspendLayout();
            this.panelFrames.SuspendLayout();
            this.panelRes.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEjecutar
            // 
            this.buttonEjecutar.Location = new System.Drawing.Point(146, 227);
            this.buttonEjecutar.Name = "buttonEjecutar";
            this.buttonEjecutar.Size = new System.Drawing.Size(75, 23);
            this.buttonEjecutar.TabIndex = 1;
            this.buttonEjecutar.Text = "Ejecutar";
            this.buttonEjecutar.UseVisualStyleBackColor = true;
            this.buttonEjecutar.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonCambiarFormato
            // 
            this.radioButtonCambiarFormato.AutoSize = true;
            this.radioButtonCambiarFormato.Location = new System.Drawing.Point(3, 3);
            this.radioButtonCambiarFormato.Name = "radioButtonCambiarFormato";
            this.radioButtonCambiarFormato.Size = new System.Drawing.Size(101, 17);
            this.radioButtonCambiarFormato.TabIndex = 7;
            this.radioButtonCambiarFormato.TabStop = true;
            this.radioButtonCambiarFormato.Text = "Cambiar formato";
            this.radioButtonCambiarFormato.UseVisualStyleBackColor = true;
            this.radioButtonCambiarFormato.CheckedChanged += new System.EventHandler(this.radioButtonCambiarFormato_CheckedChanged);
            // 
            // panelOpciones
            // 
            this.panelOpciones.Controls.Add(this.radioButtonExtraerimg);
            this.panelOpciones.Controls.Add(this.radioButtonRemoverAudio);
            this.panelOpciones.Controls.Add(this.radioButtonCambiarResolucion);
            this.panelOpciones.Controls.Add(this.radioButtonExtraerAudiomp3);
            this.panelOpciones.Controls.Add(this.radioButtonCambiarFormato);
            this.panelOpciones.Location = new System.Drawing.Point(146, 81);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(196, 117);
            this.panelOpciones.TabIndex = 8;
            // 
            // radioButtonExtraerimg
            // 
            this.radioButtonExtraerimg.AutoSize = true;
            this.radioButtonExtraerimg.Location = new System.Drawing.Point(3, 95);
            this.radioButtonExtraerimg.Name = "radioButtonExtraerimg";
            this.radioButtonExtraerimg.Size = new System.Drawing.Size(166, 17);
            this.radioButtonExtraerimg.TabIndex = 11;
            this.radioButtonExtraerimg.TabStop = true;
            this.radioButtonExtraerimg.Text = "Extraer imagen cada X frames";
            this.radioButtonExtraerimg.UseVisualStyleBackColor = true;
            this.radioButtonExtraerimg.CheckedChanged += new System.EventHandler(this.radioButtonExtraerimg_CheckedChanged);
            // 
            // radioButtonRemoverAudio
            // 
            this.radioButtonRemoverAudio.AutoSize = true;
            this.radioButtonRemoverAudio.Location = new System.Drawing.Point(3, 72);
            this.radioButtonRemoverAudio.Name = "radioButtonRemoverAudio";
            this.radioButtonRemoverAudio.Size = new System.Drawing.Size(97, 17);
            this.radioButtonRemoverAudio.TabIndex = 10;
            this.radioButtonRemoverAudio.TabStop = true;
            this.radioButtonRemoverAudio.Text = "Remover audio";
            this.radioButtonRemoverAudio.UseVisualStyleBackColor = true;
            this.radioButtonRemoverAudio.CheckedChanged += new System.EventHandler(this.radioButtonRemoverAudio_CheckedChanged);
            // 
            // radioButtonCambiarResolucion
            // 
            this.radioButtonCambiarResolucion.AutoSize = true;
            this.radioButtonCambiarResolucion.Location = new System.Drawing.Point(3, 49);
            this.radioButtonCambiarResolucion.Name = "radioButtonCambiarResolucion";
            this.radioButtonCambiarResolucion.Size = new System.Drawing.Size(114, 17);
            this.radioButtonCambiarResolucion.TabIndex = 9;
            this.radioButtonCambiarResolucion.TabStop = true;
            this.radioButtonCambiarResolucion.Text = "Cambiar resolucion";
            this.radioButtonCambiarResolucion.UseVisualStyleBackColor = true;
            this.radioButtonCambiarResolucion.CheckedChanged += new System.EventHandler(this.radioButtonCambiarResolucion_CheckedChanged);
            // 
            // radioButtonExtraerAudiomp3
            // 
            this.radioButtonExtraerAudiomp3.AutoSize = true;
            this.radioButtonExtraerAudiomp3.Location = new System.Drawing.Point(3, 26);
            this.radioButtonExtraerAudiomp3.Name = "radioButtonExtraerAudiomp3";
            this.radioButtonExtraerAudiomp3.Size = new System.Drawing.Size(110, 17);
            this.radioButtonExtraerAudiomp3.TabIndex = 8;
            this.radioButtonExtraerAudiomp3.TabStop = true;
            this.radioButtonExtraerAudiomp3.Text = "Extraer audio mp3";
            this.radioButtonExtraerAudiomp3.UseVisualStyleBackColor = true;
            this.radioButtonExtraerAudiomp3.CheckedChanged += new System.EventHandler(this.radioButtonExtraerAudiomp3_CheckedChanged);
            // 
            // panelCambiarFormato
            // 
            this.panelCambiarFormato.Controls.Add(this.radioButtonflv);
            this.panelCambiarFormato.Controls.Add(this.radioButtonmpeg);
            this.panelCambiarFormato.Controls.Add(this.radioButtonavi);
            this.panelCambiarFormato.Controls.Add(this.radioButtonmp4);
            this.panelCambiarFormato.Location = new System.Drawing.Point(358, 81);
            this.panelCambiarFormato.Name = "panelCambiarFormato";
            this.panelCambiarFormato.Size = new System.Drawing.Size(196, 89);
            this.panelCambiarFormato.TabIndex = 12;
            this.panelCambiarFormato.Visible = false;
            this.panelCambiarFormato.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCambiarFormato_Paint);
            // 
            // radioButtonflv
            // 
            this.radioButtonflv.AutoSize = true;
            this.radioButtonflv.Location = new System.Drawing.Point(3, 72);
            this.radioButtonflv.Name = "radioButtonflv";
            this.radioButtonflv.Size = new System.Drawing.Size(36, 17);
            this.radioButtonflv.TabIndex = 10;
            this.radioButtonflv.Text = "flv";
            this.radioButtonflv.UseVisualStyleBackColor = true;
            this.radioButtonflv.CheckedChanged += new System.EventHandler(this.radioButtonflv_CheckedChanged);
            // 
            // radioButtonmpeg
            // 
            this.radioButtonmpeg.AutoSize = true;
            this.radioButtonmpeg.Location = new System.Drawing.Point(3, 49);
            this.radioButtonmpeg.Name = "radioButtonmpeg";
            this.radioButtonmpeg.Size = new System.Drawing.Size(51, 17);
            this.radioButtonmpeg.TabIndex = 9;
            this.radioButtonmpeg.Text = "mpeg";
            this.radioButtonmpeg.UseVisualStyleBackColor = true;
            this.radioButtonmpeg.CheckedChanged += new System.EventHandler(this.radioButtonmpeg_CheckedChanged);
            // 
            // radioButtonavi
            // 
            this.radioButtonavi.AutoSize = true;
            this.radioButtonavi.Location = new System.Drawing.Point(3, 26);
            this.radioButtonavi.Name = "radioButtonavi";
            this.radioButtonavi.Size = new System.Drawing.Size(39, 17);
            this.radioButtonavi.TabIndex = 8;
            this.radioButtonavi.Text = "avi";
            this.radioButtonavi.UseVisualStyleBackColor = true;
            this.radioButtonavi.CheckedChanged += new System.EventHandler(this.radioButtonavi_CheckedChanged);
            // 
            // radioButtonmp4
            // 
            this.radioButtonmp4.AutoSize = true;
            this.radioButtonmp4.Location = new System.Drawing.Point(3, 3);
            this.radioButtonmp4.Name = "radioButtonmp4";
            this.radioButtonmp4.Size = new System.Drawing.Size(45, 17);
            this.radioButtonmp4.TabIndex = 7;
            this.radioButtonmp4.Text = "mp4";
            this.radioButtonmp4.UseVisualStyleBackColor = true;
            this.radioButtonmp4.CheckedChanged += new System.EventHandler(this.radioButtonmp4_CheckedChanged);
            // 
            // panelFrames
            // 
            this.panelFrames.Controls.Add(this.textBoxFrames);
            this.panelFrames.Location = new System.Drawing.Point(348, 164);
            this.panelFrames.Name = "panelFrames";
            this.panelFrames.Size = new System.Drawing.Size(111, 34);
            this.panelFrames.TabIndex = 13;
            this.panelFrames.Visible = false;
            this.panelFrames.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFrames_Paint);
            // 
            // textBoxFrames
            // 
            this.textBoxFrames.Location = new System.Drawing.Point(3, 12);
            this.textBoxFrames.Name = "textBoxFrames";
            this.textBoxFrames.Size = new System.Drawing.Size(100, 20);
            this.textBoxFrames.TabIndex = 5;
            this.textBoxFrames.TextChanged += new System.EventHandler(this.textBoxFrames_TextChanged);
            // 
            // panelRes
            // 
            this.panelRes.Controls.Add(this.labelY);
            this.panelRes.Controls.Add(this.labelX);
            this.panelRes.Controls.Add(this.textBoxY);
            this.panelRes.Controls.Add(this.textBoxX);
            this.panelRes.Location = new System.Drawing.Point(348, 117);
            this.panelRes.Name = "panelRes";
            this.panelRes.Size = new System.Drawing.Size(274, 41);
            this.panelRes.TabIndex = 14;
            this.panelRes.Visible = false;
            this.panelRes.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(130, 15);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(14, 13);
            this.labelY.TabIndex = 3;
            this.labelY.Text = "Y";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(4, 15);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(14, 13);
            this.labelX.TabIndex = 2;
            this.labelX.Text = "X";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(150, 12);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 20);
            this.textBoxY.TabIndex = 1;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(24, 12);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 20);
            this.textBoxX.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // buttonVideoDirectory
            // 
            this.buttonVideoDirectory.Location = new System.Drawing.Point(146, 39);
            this.buttonVideoDirectory.Name = "buttonVideoDirectory";
            this.buttonVideoDirectory.Size = new System.Drawing.Size(104, 23);
            this.buttonVideoDirectory.TabIndex = 15;
            this.buttonVideoDirectory.Text = "Video Directory";
            this.buttonVideoDirectory.UseVisualStyleBackColor = true;
            this.buttonVideoDirectory.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVideoDirectory);
            this.Controls.Add(this.panelCambiarFormato);
            this.Controls.Add(this.panelRes);
            this.Controls.Add(this.panelFrames);
            this.Controls.Add(this.panelOpciones);
            this.Controls.Add(this.buttonEjecutar);
            this.Name = "Form1";
            this.Text = "Above Premiere";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelOpciones.ResumeLayout(false);
            this.panelOpciones.PerformLayout();
            this.panelCambiarFormato.ResumeLayout(false);
            this.panelCambiarFormato.PerformLayout();
            this.panelFrames.ResumeLayout(false);
            this.panelFrames.PerformLayout();
            this.panelRes.ResumeLayout(false);
            this.panelRes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonEjecutar;
        private System.Windows.Forms.RadioButton radioButtonCambiarFormato;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.RadioButton radioButtonExtraerimg;
        private System.Windows.Forms.RadioButton radioButtonRemoverAudio;
        private System.Windows.Forms.RadioButton radioButtonCambiarResolucion;
        private System.Windows.Forms.RadioButton radioButtonExtraerAudiomp3;
        private System.Windows.Forms.Panel panelCambiarFormato;
        private System.Windows.Forms.RadioButton radioButtonflv;
        private System.Windows.Forms.RadioButton radioButtonmpeg;
        private System.Windows.Forms.RadioButton radioButtonavi;
        private System.Windows.Forms.RadioButton radioButtonmp4;
        private System.Windows.Forms.Panel panelFrames;
        private System.Windows.Forms.TextBox textBoxFrames;
        private System.Windows.Forms.Panel panelRes;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonVideoDirectory;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

