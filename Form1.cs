using Super_Trunfo_2._0.Classes;
using System.Drawing;
using System.IO;

namespace Super_Trunfo_2._0
{
    public partial class Form1 : Form
    {
        private List<Carta> jogador1 = new List<Carta>();
        private List<Carta> jogador2 = new List<Carta>();

        private readonly Random random = new Random();

        private Carta cartaJogador1;
        private Carta cartaJogador2;

        private int jogadorDaVez = 1;

        public Form1()
        {
            InitializeComponent();

            AplicarTema();

            picVersoJogador2.SizeMode = PictureBoxSizeMode.Zoom;
            picCartaJogador2.SizeMode = PictureBoxSizeMode.Zoom;

            picVersoJogador2.Visible = false;
            picCartaJogador2.Visible = false;

            btnNovoJogo.Click += btnNovoJogo_Click;
            btnProximaRodada.Click += btnProximaRodada_Click;

            btnHp.Click += (s, e) => JogarRodada("HP");
            btnPoder.Click += (s, e) => JogarRodada("Poder");
            btnVelocidade.Click += (s, e) => JogarRodada("Velocidade");
            btnForca.Click += (s, e) => JogarRodada("Força");
            btnResistencia.Click += (s, e) => JogarRodada("Resistência");

            HabilitarAtributos(false);
        }

        private void btnProximaRodada_Click(object sender, EventArgs e)
        {
            MostrarCartas();
            HabilitarAtributos(true);
            btnProximaRodada.Enabled = false;
            lblResultado.Text = "Escolha um atributo!";
        }

        private void Form1_Load(object sender, EventArgs e){}

        private void lblCartaComputador_Click(object sender, EventArgs e){}

        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            jogadorDaVez = 1;
            btnProximaRodada.Enabled = false;

            Baralho baralho = new Baralho();
            Carta[] cartas = baralho.getCards();

            for (int i = cartas.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);

                Carta temp = cartas[i];
                cartas[i] = cartas[j];
                cartas[j] = temp;
            }

            jogador1 = cartas.Take(16).ToList();
            jogador2 = cartas.Skip(16).Take(16).ToList();

            lblResultado.Text = "Jogador 1: escolha um atributo!";

            HabilitarAtributos(true);
            MostrarCartas();
        }

        private void MostrarCartas()
        {
            if (jogador1.Count == 0 || jogador2.Count == 0)
                return;

            cartaJogador1 = jogador1[0];
            cartaJogador2 = jogador2[0];

            picCartaJogador1.Image = CarregarImagem(cartaJogador1.Code + ".png");
            picCartaJogador2.Image = CarregarImagem(cartaJogador2.Code + ".png");
            picVersoJogador1.Image = CarregarImagem("verso.png");
            picVersoJogador2.Image = CarregarImagem("verso.png");

            if (jogadorDaVez == 1)
            {
                picCartaJogador1.Visible = true;
                picVersoJogador1.Visible = false;
                picCartaJogador2.Visible = false;
                picVersoJogador2.Visible = true;

                lblCartaJogador1.Text =
                    $"{cartaJogador1.Name}\n\n" +
                    $"HP: {cartaJogador1.Hp}\n" +
                    $"Poder: {cartaJogador1.Power}\n" +
                    $"Velocidade: {cartaJogador1.Speed}\n" +
                    $"Força: {cartaJogador1.Strength}\n" +
                    $"Resistência: {cartaJogador1.Resistance}";

                lblCartaJogador2.Text = "Carta oculta";
            }
            else
            {
                picCartaJogador1.Visible = false;
                picVersoJogador1.Visible = true;
                picCartaJogador2.Visible = true;
                picVersoJogador2.Visible = false;

                lblCartaJogador1.Text = "Carta oculta";

                lblCartaJogador2.Text =
                    $"{cartaJogador2.Name}\n\n" +
                    $"HP: {cartaJogador2.Hp}\n" +
                    $"Poder: {cartaJogador2.Power}\n" +
                    $"Velocidade: {cartaJogador2.Speed}\n" +
                    $"Força: {cartaJogador2.Strength}\n" +
                    $"Resistência: {cartaJogador2.Resistance}";
            }

            lblResultado.Text = $"Jogador {jogadorDaVez}: escolha um atributo!";

            AtualizarPlacar();
            HabilitarAtributos(true);

            btnProximaRodada.Enabled = false;
        }

        private void JogarRodada(string atributo)
        {
            if (cartaJogador1 == null || cartaJogador2 == null)
                return;

            int valorJogador1 = ObterAtributo(cartaJogador1, atributo);
            int valorJogador2 = ObterAtributo(cartaJogador2, atributo);

            picCartaJogador1.Visible = true;
            picVersoJogador1.Visible = false;
            picCartaJogador2.Visible = true;
            picVersoJogador2.Visible = false;

            lblCartaJogador1.Text =
                $"{cartaJogador1.Name}\n\n" +
                $"HP: {cartaJogador1.Hp}\n" +
                $"Poder: {cartaJogador1.Power}\n" +
                $"Velocidade: {cartaJogador1.Speed}\n" +
                $"Força: {cartaJogador1.Strength}\n" +
                $"Resistência: {cartaJogador1.Resistance}";

            lblCartaJogador2.Text =
                $"{cartaJogador2.Name}\n\n" +
                $"HP: {cartaJogador2.Hp}\n" +
                $"Poder: {cartaJogador2.Power}\n" +
                $"Velocidade: {cartaJogador2.Speed}\n" +
                $"Força: {cartaJogador2.Strength}\n" +
                $"Resistência: {cartaJogador2.Resistance}";

            bool jogador1Venceu;
            bool jogador2Venceu;

            if (cartaJogador1.Supertrunfo && !cartaJogador2.Supertrunfo)
            {
                jogador1Venceu = true;
                jogador2Venceu = false;
            }
            else if (cartaJogador2.Supertrunfo && !cartaJogador1.Supertrunfo)
            {
                jogador1Venceu = false;
                jogador2Venceu = true;
            }
            else
            {
                jogador1Venceu = valorJogador1 > valorJogador2;
                jogador2Venceu = valorJogador2 > valorJogador1;
            }

            jogador1.RemoveAt(0);
            jogador2.RemoveAt(0);

            if (jogador1Venceu)
            {
                jogador1.Add(cartaJogador1);
                jogador2.Add(cartaJogador2);

                lblResultado.Text = $"Jogador 1 venceu!\n" + $"{atributo}: {valorJogador1} x {valorJogador2}";
            }
            else if (jogador2Venceu)
            {
                jogador2.Add(cartaJogador2);
                jogador2.Add(cartaJogador1);

                lblResultado.Text = $"Jogador 2 venceu!\n" + $"{atributo}: {valorJogador1} x {valorJogador2}";
            }
            else
            {
                jogador1.Add(cartaJogador1);
                jogador2.Add(cartaJogador2);

                lblResultado.Text = $"Empate!\n" + $"{atributo}: {valorJogador1} x {valorJogador2}";
            }

            AtualizarPlacar();
            HabilitarAtributos(false);

            if (jogador1.Count == 0 || jogador2.Count == 0)
            {
                btnProximaRodada.Enabled = false;
                lblResultado.Text = jogador1.Count > 0 ? "Jogador 1 venceu o jogo!" : "Jogador 2 venceu o jogo!";

                return;
            }

            jogadorDaVez = jogadorDaVez == 1 ? 2 : 1;

            btnProximaRodada.Enabled = true;
        }

        private int ObterAtributo(Carta carta, string atributo)
        {
            switch (atributo)
            {
                case "HP":
                    return carta.Hp;
                case "Poder":
                    return carta.Power;
                case "Velocidade":
                    return carta.Speed;
                case "Força":
                    return carta.Strength;
                case "Resistência":
                    return carta.Resistance;
                default:
                    throw new ArgumentException("Atributo inválido.");
            }
        }

        private void AtualizarPlacar()
        {
            lblPlacar.Text = $"Jogador 1: {jogador1.Count} | " + $"Jogador 2: {jogador2.Count}";
        }

        private void HabilitarAtributos(bool habilitar)
        {
            btnHp.Enabled = habilitar;
            btnPoder.Enabled = habilitar;
            btnVelocidade.Enabled = habilitar;
            btnForca.Enabled = habilitar;
            btnResistencia.Enabled = habilitar;
        }

        private void lblSuaCarta_Click(object sender, EventArgs e){}

        private void AplicarTema()
        {
            Color fundo = Color.FromArgb(30, 25, 35);
            Color painel = Color.FromArgb(48, 36, 40);
            Color dourado = Color.FromArgb(230, 190, 100);
            Color texto = Color.FromArgb(245, 230, 200);

            this.BackColor = fundo;
            this.ForeColor = texto;

            lblTitulo.ForeColor = dourado;
            lblPlacar.ForeColor = dourado;
            lblResultado.ForeColor = texto;

            grpSuaCarta.BackColor = painel;
            grpCartaComputador.BackColor = painel;

            grpSuaCarta.ForeColor = dourado;
            grpCartaComputador.ForeColor = dourado;

            lblCartaJogador1.BackColor = painel;
            lblCartaJogador2.BackColor = painel;

            lblCartaJogador1.ForeColor = texto;
            lblCartaJogador2.ForeColor = texto;

            Button[] botoes = {btnHp, btnPoder, btnVelocidade, btnForca, btnResistencia, btnNovoJogo, btnProximaRodada};

            foreach (Button botao in botoes)
            {
                botao.BackColor = painel;
                botao.ForeColor = dourado;
                botao.FlatStyle = FlatStyle.Flat;
                botao.FlatAppearance.BorderColor = dourado;
                botao.FlatAppearance.BorderSize = 1;
                botao.Cursor = Cursors.Hand;
            }
        }

        private Image CarregarImagem(string nomeArquivo)
        {
            string caminho = Path.Combine(AppContext.BaseDirectory,"Imagens",nomeArquivo);

            if (!File.Exists(caminho))
            {
                MessageBox.Show($"Imagem não encontrada:\n{caminho}", "Erro ao carregar imagem");
                return null;
            }

            using (FileStream arquivo = File.OpenRead(caminho))
            using (Image imagemOriginal = Image.FromStream(arquivo))
            {
                return new Bitmap(imagemOriginal);
            }
        }

        private void btnProximaRodada_Click_1(object sender, EventArgs e)
        {
            MostrarCartas();
        }
    }
}