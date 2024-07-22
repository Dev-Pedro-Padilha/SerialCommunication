namespace EnviaSerialForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bttnConect = new Button();
            comboBox1 = new ComboBox();
            bttnEnviar = new Button();
            textBoxComando = new TextBox();
            textBoxResposta = new TextBox();
            timerCOM = new System.Windows.Forms.Timer(components);
            pictureBoxLED = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxHeader = new TextBox();
            label4 = new Label();
            textBoxTrailer = new TextBox();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLED).BeginInit();
            SuspendLayout();
            // 
            // bttnConect
            // 
            bttnConect.Location = new Point(192, 12);
            bttnConect.Name = "bttnConect";
            bttnConect.Size = new Size(83, 23);
            bttnConect.TabIndex = 0;
            bttnConect.Text = "Conectar";
            bttnConect.UseVisualStyleBackColor = true;
            bttnConect.Click += bttnConect_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(33, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            // 
            // bttnEnviar
            // 
            bttnEnviar.Location = new Point(419, 104);
            bttnEnviar.Name = "bttnEnviar";
            bttnEnviar.Size = new Size(75, 23);
            bttnEnviar.TabIndex = 5;
            bttnEnviar.Text = "Enviar";
            bttnEnviar.Click += bttnEnviar_Click;
            // 
            // textBoxComando
            // 
            textBoxComando.Location = new Point(132, 104);
            textBoxComando.Name = "textBoxComando";
            textBoxComando.Size = new Size(181, 23);
            textBoxComando.TabIndex = 3;
            // 
            // textBoxResposta
            // 
            textBoxResposta.Location = new Point(32, 168);
            textBoxResposta.Multiline = true;
            textBoxResposta.Name = "textBoxResposta";
            textBoxResposta.ScrollBars = ScrollBars.Vertical;
            textBoxResposta.Size = new Size(385, 85);
            textBoxResposta.TabIndex = 4;
            // 
            // timerCOM
            // 
            timerCOM.Interval = 1000;
            timerCOM.Tick += timerCOM_Tick;
            // 
            // pictureBoxLED
            // 
            pictureBoxLED.Location = new Point(160, 29);
            pictureBoxLED.Name = "pictureBoxLED";
            pictureBoxLED.Size = new Size(26, 20);
            pictureBoxLED.TabIndex = 6;
            pictureBoxLED.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(192, 41);
            button1.Name = "button1";
            button1.Size = new Size(83, 23);
            button1.TabIndex = 7;
            button1.Text = "Desconectar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 86);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 8;
            label2.Text = "Comando";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 86);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 10;
            label3.Text = "Header";
            // 
            // textBoxHeader
            // 
            textBoxHeader.Location = new Point(32, 104);
            textBoxHeader.Name = "textBoxHeader";
            textBoxHeader.Size = new Size(94, 23);
            textBoxHeader.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(319, 86);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 12;
            label4.Text = "Trailer";
            // 
            // textBoxTrailer
            // 
            textBoxTrailer.Location = new Point(319, 104);
            textBoxTrailer.Name = "textBoxTrailer";
            textBoxTrailer.Size = new Size(94, 23);
            textBoxTrailer.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 150);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 13;
            label5.Text = "Resposta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 8);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 14;
            label6.Text = "Porta Serial";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 337);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxTrailer);
            Controls.Add(label3);
            Controls.Add(textBoxHeader);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBoxLED);
            Controls.Add(textBoxResposta);
            Controls.Add(textBoxComando);
            Controls.Add(bttnEnviar);
            Controls.Add(comboBox1);
            Controls.Add(bttnConect);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLED).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bttnConect;
        private ComboBox comboBox1;
        private Button bttnEnviar;
        private TextBox textBoxComando;
        private TextBox textBoxResposta;
        private System.Windows.Forms.Timer timerCOM;
        private PictureBox pictureBoxLED;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxHeader;
        private Label label4;
        private TextBox textBoxTrailer;
        private Label label5;
        private Label label6;
    }
}