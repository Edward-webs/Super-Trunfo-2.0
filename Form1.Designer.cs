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
            grpCartaComputador = new GroupBox();
            lblCartaComputador = new Label();
            btnHp = new Button();
            btnPoder = new Button();
            btnVelocidade = new Button();
            btnForca = new Button();
            btnResistencia = new Button();
            lblResultado = new Label();
            btnNovoJogo = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(29, 47);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(90, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "SUPER TRUNFO";
            // 
            // lblPlacar
            // 
            lblPlacar.AutoSize = true;
            lblPlacar.Location = new Point(149, 47);
            lblPlacar.Name = "lblPlacar";
            lblPlacar.Size = new Size(145, 15);
            lblPlacar.TabIndex = 1;
            lblPlacar.Text = "Você: 16 | Computador: 16";
            // 
            // lblSuaCarta
            // 
            lblSuaCarta.AutoSize = true;
            lblSuaCarta.Location = new Point(330, 47);
            lblSuaCarta.Name = "lblSuaCarta";
            lblSuaCarta.Size = new Size(99, 15);
            lblSuaCarta.TabIndex = 2;
            lblSuaCarta.Text = "Nome e atributos";
            // 
            // grpSuaCarta
            // 
            grpSuaCarta.Location = new Point(467, 47);
            grpSuaCarta.Name = "grpSuaCarta";
            grpSuaCarta.Size = new Size(200, 100);
            grpSuaCarta.TabIndex = 3;
            grpSuaCarta.TabStop = false;
            grpSuaCarta.Text = "Sua carta";
            // 
            // grpCartaComputador
            // 
            grpCartaComputador.Location = new Point(720, 47);
            grpCartaComputador.Name = "grpCartaComputador";
            grpCartaComputador.Size = new Size(200, 100);
            grpCartaComputador.TabIndex = 4;
            grpCartaComputador.TabStop = false;
            grpCartaComputador.Text = "Carta do computador";
            // 
            // lblCartaComputador
            // 
            lblCartaComputador.AutoSize = true;
            lblCartaComputador.Location = new Point(139, 421);
            lblCartaComputador.Name = "lblCartaComputador";
            lblCartaComputador.Size = new Size(73, 15);
            lblCartaComputador.TabIndex = 5;
            lblCartaComputador.Text = "Carta Oculta";
            lblCartaComputador.Click += lblCartaComputador_Click;
            // 
            // btnHp
            // 
            btnHp.Location = new Point(48, 231);
            btnHp.Name = "btnHp";
            btnHp.Size = new Size(75, 23);
            btnHp.TabIndex = 6;
            btnHp.Text = "HP";
            btnHp.UseVisualStyleBackColor = true;
            // 
            // btnPoder
            // 
            btnPoder.Location = new Point(163, 231);
            btnPoder.Name = "btnPoder";
            btnPoder.Size = new Size(75, 23);
            btnPoder.TabIndex = 7;
            btnPoder.Text = "Poder";
            btnPoder.UseVisualStyleBackColor = true;
            // 
            // btnVelocidade
            // 
            btnVelocidade.Location = new Point(284, 231);
            btnVelocidade.Name = "btnVelocidade";
            btnVelocidade.Size = new Size(75, 23);
            btnVelocidade.TabIndex = 8;
            btnVelocidade.Text = "Velocidade";
            btnVelocidade.UseVisualStyleBackColor = true;
            // 
            // btnForca
            // 
            btnForca.Location = new Point(402, 231);
            btnForca.Name = "btnForca";
            btnForca.Size = new Size(75, 23);
            btnForca.TabIndex = 9;
            btnForca.Text = "Força";
            btnForca.UseVisualStyleBackColor = true;
            // 
            // btnResistencia
            // 
            btnResistencia.Location = new Point(514, 231);
            btnResistencia.Name = "btnResistencia";
            btnResistencia.Size = new Size(75, 23);
            btnResistencia.TabIndex = 10;
            btnResistencia.Text = "Resistência";
            btnResistencia.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(643, 231);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(113, 15);
            lblResultado.TabIndex = 11;
            lblResultado.Text = "Escolha um atributo";
            // 
            // btnNovoJogo
            // 
            btnNovoJogo.Location = new Point(819, 229);
            btnNovoJogo.Name = "btnNovoJogo";
            btnNovoJogo.Size = new Size(75, 23);
            btnNovoJogo.TabIndex = 12;
            btnNovoJogo.Text = "Novo Jogo";
            btnNovoJogo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(984, 661);
            Controls.Add(btnNovoJogo);
            Controls.Add(lblResultado);
            Controls.Add(btnResistencia);
            Controls.Add(btnForca);
            Controls.Add(btnVelocidade);
            Controls.Add(btnPoder);
            Controls.Add(btnHp);
            Controls.Add(lblCartaComputador);
            Controls.Add(grpCartaComputador);
            Controls.Add(grpSuaCarta);
            Controls.Add(lblSuaCarta);
            Controls.Add(lblPlacar);
            Controls.Add(lblTitulo);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Super Trunfo - Fantasia Medieval";
            Load += Form1_Load;
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
    }
}
