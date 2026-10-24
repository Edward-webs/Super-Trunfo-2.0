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
            lblSuaCarta = new Label();
            grpSuaCarta = new GroupBox();
            picSuaCarta = new PictureBox();
            grpCartaComputador = new GroupBox();
            picCartaComputador = new PictureBox();
            lblCartaComputador = new Label();
            btnHp = new Button();
            btnPoder = new Button();
            btnVelocidade = new Button();
            btnForca = new Button();
            btnResistencia = new Button();
            lblResultado = new Label();
            btnNovoJogo = new Button();
            grpSuaCarta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSuaCarta).BeginInit();
            grpCartaComputador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCartaComputador).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            lblPlacar.Location = new Point(462, 193);
            lblPlacar.Name = "lblPlacar";
            lblPlacar.Size = new Size(173, 19);
            lblPlacar.TabIndex = 1;
            lblPlacar.Text = "Você: 16 | Computador: 16";
            // 
            // lblSuaCarta
            // 
            lblSuaCarta.AutoSize = true;
            lblSuaCarta.Location = new Point(6, 319);
            lblSuaCarta.Name = "lblSuaCarta";
            lblSuaCarta.Size = new Size(139, 18);
            lblSuaCarta.TabIndex = 2;
            lblSuaCarta.Text = "Nome e atributos";
            lblSuaCarta.Click += lblSuaCarta_Click;
            // 
            // grpSuaCarta
            // 
            grpSuaCarta.BackColor = Color.BurlyWood;
            grpSuaCarta.Controls.Add(picSuaCarta);
            grpSuaCarta.Controls.Add(lblSuaCarta);
            grpSuaCarta.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpSuaCarta.ForeColor = Color.Gold;
            grpSuaCarta.Location = new Point(31, 129);
            grpSuaCarta.Name = "grpSuaCarta";
            grpSuaCarta.Size = new Size(346, 513);
            grpSuaCarta.TabIndex = 3;
            grpSuaCarta.TabStop = false;
            grpSuaCarta.Text = "Sua carta";
            // 
            // picSuaCarta
            // 
            picSuaCarta.Location = new Point(6, 25);
            picSuaCarta.Name = "picSuaCarta";
            picSuaCarta.Size = new Size(334, 241);
            picSuaCarta.SizeMode = PictureBoxSizeMode.StretchImage;
            picSuaCarta.TabIndex = 13;
            picSuaCarta.TabStop = false;
            // 
            // grpCartaComputador
            // 
            grpCartaComputador.BackColor = Color.BurlyWood;
            grpCartaComputador.Controls.Add(picCartaComputador);
            grpCartaComputador.Controls.Add(lblCartaComputador);
            grpCartaComputador.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpCartaComputador.ForeColor = Color.Gold;
            grpCartaComputador.Location = new Point(695, 129);
            grpCartaComputador.Name = "grpCartaComputador";
            grpCartaComputador.Size = new Size(364, 524);
            grpCartaComputador.TabIndex = 4;
            grpCartaComputador.TabStop = false;
            grpCartaComputador.Text = "Carta do computador";
            // 
            // picCartaComputador
            // 
            picCartaComputador.Location = new Point(6, 25);
            picCartaComputador.Name = "picCartaComputador";
            picCartaComputador.Size = new Size(352, 241);
            picCartaComputador.TabIndex = 13;
            picCartaComputador.TabStop = false;
            // 
            // lblCartaComputador
            // 
            lblCartaComputador.AutoSize = true;
            lblCartaComputador.Location = new Point(6, 319);
            lblCartaComputador.Name = "lblCartaComputador";
            lblCartaComputador.Size = new Size(105, 18);
            lblCartaComputador.TabIndex = 5;
            lblCartaComputador.Text = "Carta Oculta";
            lblCartaComputador.Click += lblCartaComputador_Click;
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
            lblResultado.Location = new Point(449, 758);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(131, 19);
            lblResultado.TabIndex = 11;
            lblResultado.Text = "Escolha um atributo";
            // 
            // btnNovoJogo
            // 
            btnNovoJogo.Location = new Point(505, 96);
            btnNovoJogo.Name = "btnNovoJogo";
            btnNovoJogo.Size = new Size(75, 26);
            btnNovoJogo.TabIndex = 12;
            btnNovoJogo.Text = "Novo Jogo";
            btnNovoJogo.UseVisualStyleBackColor = true;
            btnNovoJogo.Click += btnNovoJogo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1084, 806);
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
            ((System.ComponentModel.ISupportInitialize)picSuaCarta).EndInit();
            grpCartaComputador.ResumeLayout(false);
            grpCartaComputador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCartaComputador).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblPlacar;
        private Label lblSuaCarta;
        private GroupBox grpSuaCarta;
        private GroupBox grpCartaComputador;
        private Label lblCartaComputador;
        private Button btnHp;
        private Button btnPoder;
        private Button btnVelocidade;
        private Button btnForca;
        private Button btnResistencia;
        private Label lblResultado;
        private Button btnNovoJogo;
        private PictureBox picSuaCarta;
        private PictureBox picCartaComputador;
    }
}
