namespace Super_Trunfo_2._0
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
            lblTitulo = new Label();
            lblPlacar = new Label();
            lblCartaJogador1 = new Label();
            grpSuaCarta = new GroupBox();
            picVersoJogador1 = new PictureBox();
            picCartaJogador1 = new PictureBox();
            grpCartaComputador = new GroupBox();
            picVersoJogador2 = new PictureBox();
            picCartaJogador2 = new PictureBox();
            lblCartaJogador2 = new Label();
            btnHp = new Button();
            btnPoder = new Button();
            btnVelocidade = new Button();
            btnForca = new Button();
            btnResistencia = new Button();
            lblResultado = new Label();
            btnNovoJogo = new Button();
            btnProximaRodada = new Button();
            grpSuaCarta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picVersoJogador1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCartaJogador1).BeginInit();
            grpCartaComputador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picVersoJogador2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCartaJogador2).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.DarkSlateGray;
            lblTitulo.Location = new Point(335, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(414, 47);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "SUPER TRUNFO";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPlacar
            // 
            lblPlacar.AutoSize = true;
            lblPlacar.Location = new Point(448, 318);
            lblPlacar.Name = "lblPlacar";
            lblPlacar.Size = new Size(188, 19);
            lblPlacar.TabIndex = 1;
            lblPlacar.Text = "Jogador 1: 16 | Jogador 2: 16";
            // 
            // lblCartaJogador1
            // 
            lblCartaJogador1.AutoSize = true;
            lblCartaJogador1.Location = new Point(6, 282);
            lblCartaJogador1.Name = "lblCartaJogador1";
            lblCartaJogador1.Size = new Size(139, 18);
            lblCartaJogador1.TabIndex = 2;
            lblCartaJogador1.Text = "Nome e atributos";
            lblCartaJogador1.Click += lblSuaCarta_Click;
            // 
            // grpSuaCarta
            // 
            grpSuaCarta.BackColor = Color.FromArgb(64, 64, 64);
            grpSuaCarta.Controls.Add(picVersoJogador1);
            grpSuaCarta.Controls.Add(picCartaJogador1);
            grpSuaCarta.Controls.Add(lblCartaJogador1);
            grpSuaCarta.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpSuaCarta.ForeColor = Color.Gold;
            grpSuaCarta.Location = new Point(31, 129);
            grpSuaCarta.Name = "grpSuaCarta";
            grpSuaCarta.Size = new Size(346, 513);
            grpSuaCarta.TabIndex = 3;
            grpSuaCarta.TabStop = false;
            grpSuaCarta.Text = "Carta - Jogador 1";
            // 
            // picVersoJogador1
            // 
            picVersoJogador1.Location = new Point(6, 25);
            picVersoJogador1.Name = "picVersoJogador1";
            picVersoJogador1.Size = new Size(334, 482);
            picVersoJogador1.SizeMode = PictureBoxSizeMode.Zoom;
            picVersoJogador1.TabIndex = 14;
            picVersoJogador1.TabStop = false;
            // 
            // picCartaJogador1
            // 
            picCartaJogador1.Location = new Point(6, 25);
            picCartaJogador1.Name = "picCartaJogador1";
            picCartaJogador1.Size = new Size(334, 241);
            picCartaJogador1.SizeMode = PictureBoxSizeMode.Zoom;
            picCartaJogador1.TabIndex = 13;
            picCartaJogador1.TabStop = false;
            // 
            // grpCartaComputador
            // 
            grpCartaComputador.BackColor = Color.FromArgb(64, 64, 64);
            grpCartaComputador.Controls.Add(picVersoJogador2);
            grpCartaComputador.Controls.Add(picCartaJogador2);
            grpCartaComputador.Controls.Add(lblCartaJogador2);
            grpCartaComputador.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpCartaComputador.ForeColor = Color.Gold;
            grpCartaComputador.Location = new Point(695, 129);
            grpCartaComputador.Name = "grpCartaComputador";
            grpCartaComputador.Size = new Size(364, 524);
            grpCartaComputador.TabIndex = 4;
            grpCartaComputador.TabStop = false;
            grpCartaComputador.Text = "Carta - Jogador 2";
            // 
            // picVersoJogador2
            // 
            picVersoJogador2.Location = new Point(6, 25);
            picVersoJogador2.Name = "picVersoJogador2";
            picVersoJogador2.Size = new Size(352, 493);
            picVersoJogador2.SizeMode = PictureBoxSizeMode.Zoom;
            picVersoJogador2.TabIndex = 13;
            picVersoJogador2.TabStop = false;
            // 
            // picCartaJogador2
            // 
            picCartaJogador2.Location = new Point(6, 25);
            picCartaJogador2.Name = "picCartaJogador2";
            picCartaJogador2.Size = new Size(352, 241);
            picCartaJogador2.SizeMode = PictureBoxSizeMode.Zoom;
            picCartaJogador2.TabIndex = 13;
            picCartaJogador2.TabStop = false;
            // 
            // lblCartaJogador2
            // 
            lblCartaJogador2.AutoSize = true;
            lblCartaJogador2.Location = new Point(6, 319);
            lblCartaJogador2.Name = "lblCartaJogador2";
            lblCartaJogador2.Size = new Size(105, 18);
            lblCartaJogador2.TabIndex = 5;
            lblCartaJogador2.Text = "Carta Oculta";
            lblCartaJogador2.Click += lblCartaComputador_Click;
            // 
            // btnHp
            // 
            btnHp.BackColor = Color.SaddleBrown;
            btnHp.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHp.ForeColor = Color.Gold;
            btnHp.Location = new Point(37, 676);
            btnHp.Name = "btnHp";
            btnHp.Size = new Size(125, 48);
            btnHp.TabIndex = 6;
            btnHp.Text = "HP";
            btnHp.UseVisualStyleBackColor = false;
            // 
            // btnPoder
            // 
            btnPoder.BackColor = Color.SaddleBrown;
            btnPoder.Font = new Font("Georgia", 9.75F, FontStyle.Bold);
            btnPoder.ForeColor = Color.Gold;
            btnPoder.Location = new Point(246, 676);
            btnPoder.Name = "btnPoder";
            btnPoder.Size = new Size(125, 48);
            btnPoder.TabIndex = 7;
            btnPoder.Text = "Poder";
            btnPoder.UseVisualStyleBackColor = false;
            // 
            // btnVelocidade
            // 
            btnVelocidade.BackColor = Color.SaddleBrown;
            btnVelocidade.Font = new Font("Georgia", 9.75F, FontStyle.Bold);
            btnVelocidade.ForeColor = Color.Gold;
            btnVelocidade.Location = new Point(471, 676);
            btnVelocidade.Name = "btnVelocidade";
            btnVelocidade.Size = new Size(125, 48);
            btnVelocidade.TabIndex = 8;
            btnVelocidade.Text = "Velocidade";
            btnVelocidade.UseVisualStyleBackColor = false;
            // 
            // btnForca
            // 
            btnForca.BackColor = Color.SaddleBrown;
            btnForca.Font = new Font("Georgia", 9.75F, FontStyle.Bold);
            btnForca.ForeColor = Color.Gold;
            btnForca.Location = new Point(701, 676);
            btnForca.Name = "btnForca";
            btnForca.Size = new Size(125, 48);
            btnForca.TabIndex = 9;
            btnForca.Text = "Força";
            btnForca.UseVisualStyleBackColor = false;
            // 
            // btnResistencia
            // 
            btnResistencia.BackColor = Color.SaddleBrown;
            btnResistencia.Font = new Font("Georgia", 9.75F, FontStyle.Bold);
            btnResistencia.ForeColor = Color.Gold;
            btnResistencia.Location = new Point(928, 676);
            btnResistencia.Name = "btnResistencia";
            btnResistencia.Size = new Size(125, 48);
            btnResistencia.TabIndex = 10;
            btnResistencia.Text = "Resistência";
            btnResistencia.UseVisualStyleBackColor = false;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.ForeColor = Color.Yellow;
            lblResultado.Location = new Point(470, 492);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(135, 19);
            lblResultado.TabIndex = 11;
            lblResultado.Text = "Escolha um atributo!";
            // 
            // btnNovoJogo
            // 
            btnNovoJogo.BackColor = Color.DarkCyan;
            btnNovoJogo.ForeColor = Color.Red;
            btnNovoJogo.Location = new Point(470, 154);
            btnNovoJogo.Name = "btnNovoJogo";
            btnNovoJogo.Size = new Size(152, 51);
            btnNovoJogo.TabIndex = 12;
            btnNovoJogo.Text = "Novo Jogo";
            btnNovoJogo.UseVisualStyleBackColor = false;
            btnNovoJogo.Click += btnNovoJogo_Click;
            // 
            // btnProximaRodada
            // 
            btnProximaRodada.Enabled = false;
            btnProximaRodada.Location = new Point(470, 349);
            btnProximaRodada.Name = "btnProximaRodada";
            btnProximaRodada.Size = new Size(152, 46);
            btnProximaRodada.TabIndex = 13;
            btnProximaRodada.Text = "Próxima Rodada";
            btnProximaRodada.UseVisualStyleBackColor = true;
            btnProximaRodada.Click += btnProximaRodada_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1084, 806);
            Controls.Add(btnProximaRodada);
            Controls.Add(btnNovoJogo);
            Controls.Add(lblResultado);
            Controls.Add(btnResistencia);
            Controls.Add(btnForca);
            Controls.Add(btnVelocidade);
            Controls.Add(btnPoder);
            Controls.Add(btnHp);
            Controls.Add(grpCartaComputador);
            Controls.Add(grpSuaCarta);
            Controls.Add(lblPlacar);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Super Trunfo - Fantasia Medieval";
            Load += Form1_Load;
            grpSuaCarta.ResumeLayout(false);
            grpSuaCarta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picVersoJogador1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCartaJogador1).EndInit();
            grpCartaComputador.ResumeLayout(false);
            grpCartaComputador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picVersoJogador2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCartaJogador2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblPlacar;
        private Label lblCartaJogador1;
        private GroupBox grpSuaCarta;
        private GroupBox grpCartaComputador;
        private Label lblCartaJogador2;
        private Button btnHp;
        private Button btnPoder;
        private Button btnVelocidade;
        private Button btnForca;
        private Button btnResistencia;
        private Label lblResultado;
        private Button btnNovoJogo;
        private PictureBox picCartaJogador1;
        private PictureBox picCartaJogador2;
        private PictureBox picVersoJogador2;
        private Button btnProximaRodada;
        private PictureBox picVersoJogador1;
    }
}
