using Super_Trunfo_2._0.Classes;
using System.Drawing;
using System.IO;

namespace Super_Trunfo_2._0
{
    public partial class Form1 : Form
    {
        private List<Carta> jogador = new List<Carta>();
        private List<Carta> computador = new List<Carta>();

        private readonly Random random = new Random();

        private Carta cartaJogador;
        private Carta cartaComputador;

        public Form1()
        {
            InitializeComponent();

            btnNovoJogo.Click += btnNovoJogo_Click;

            btnHp.Click += (s, e) => JogarRodada("HP");
            btnPoder.Click += (s, e) => JogarRodada("Poder");
            btnVelocidade.Click += (s, e) => JogarRodada("Velocidade");
            btnForca.Click += (s, e) => JogarRodada("Força");
            btnResistencia.Click += (s, e) => JogarRodada("Resistência");

            HabilitarAtributos(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblCartaComputador_Click(object sender, EventArgs e)
        {

        }

        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            Baralho baralho = new Baralho();
            Carta[] cartas = baralho.getCards();

            // Embaralhar as cartas
            for (int i = cartas.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);

                Carta temp = cartas[i];
                cartas[i] = cartas[j];
                cartas[j] = temp;
            }

            jogador = cartas.Take(16).ToList();
            computador = cartas.Skip(16).Take(16).ToList();

            lblResultado.Text = "Escolha um atributo!";
            HabilitarAtributos(true);

            MostrarCartas();
        }

        private void MostrarCartas()
        {
            if (jogador.Count == 0 || computador.Count == 0)
                return;

            cartaJogador = jogador[0];
            cartaComputador = computador[0];

            // Exibe a imagem da carta do jogador.
            picSuaCarta.Image = CarregarImagem(
                cartaJogador.Code + ".png"
            );

            // Exibe o verso da carta do computador.
            picCartaComputador.Image = CarregarImagem(
                "verso.png"
            );

            lblSuaCarta.Text =
                $"{cartaJogador.Name}\n\n" +
                $"HP: {cartaJogador.Hp}\n" +
                $"Poder: {cartaJogador.Power}\n" +
                $"Velocidade: {cartaJogador.Speed}\n" +
                $"Força: {cartaJogador.Strength}\n" +
                $"Resistência: {cartaJogador.Resistance}";

            // Os atributos do computador ficam ocultos.
            lblCartaComputador.Text =
                "CARTA DO COMPUTADOR\n\n" +
                "Escolha um atributo para revelar!";

            AtualizarPlacar();
        }

        private void JogarRodada(string atributo)
        {
            if (cartaJogador == null ||
                cartaComputador == null)
                return;

            int valorJogador = ObterAtributo(
                cartaJogador, atributo);

            int valorComputador = ObterAtributo(
                cartaComputador, atributo);

            picCartaComputador.Image = CarregarImagem(cartaComputador.Code + ".png");

            bool jogadorVenceu;
            bool computadorVenceu;

            // Regra especial do Super Trunfo.
            if (cartaJogador.Supertrunfo &&
                !cartaComputador.Supertrunfo)
            {
                jogadorVenceu = true;
                computadorVenceu = false;
            }
            else if (cartaComputador.Supertrunfo &&
                     !cartaJogador.Supertrunfo)
            {
                jogadorVenceu = false;
                computadorVenceu = true;
            }
            else
            {
                jogadorVenceu =
                    valorJogador > valorComputador;

                computadorVenceu =
                    valorComputador > valorJogador;
            }

            // Revela a carta do computador.
            lblCartaComputador.Text =
                $"[{cartaComputador.Code}] {cartaComputador.Name}\n\n" +
                $"HP: {cartaComputador.Hp}\n" +
                $"Poder: {cartaComputador.Power}\n" +
                $"Velocidade: {cartaComputador.Speed}\n" +
                $"Força: {cartaComputador.Strength}\n" +
                $"Resistência: {cartaComputador.Resistance}";

            // Retira as cartas que estão em disputa.
            jogador.RemoveAt(0);
            computador.RemoveAt(0);

            // O vencedor recebe as duas cartas.
            if (jogadorVenceu)
            {
                jogador.Add(cartaJogador);
                jogador.Add(cartaComputador);

                lblResultado.Text =
                    $"Você venceu! {atributo}: " +
                    $"{valorJogador} x {valorComputador}";
            }
            else if (computadorVenceu)
            {
                computador.Add(cartaComputador);
                computador.Add(cartaJogador);

                lblResultado.Text =
                    $"O computador venceu! {atributo}: " +
                    $"{valorJogador} x {valorComputador}";
            }
            else
            {
                // No empate, cada um mantém sua carta.
                jogador.Add(cartaJogador);
                computador.Add(cartaComputador);

                lblResultado.Text =
                    $"Empate! {atributo}: " +
                    $"{valorJogador} x {valorComputador}";
            }

            AtualizarPlacar();

            if (jogador.Count == 0 ||
                computador.Count == 0)
            {
                HabilitarAtributos(false);

                lblResultado.Text =
                    jogador.Count > 0
                    ? "Parabéns! Você venceu o jogo!"
                    : "O computador venceu o jogo!";

                return;
            }

            MostrarCartas();
        }

        private int ObterAtributo(
            Carta carta, string atributo)
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
            lblPlacar.Text =
                $"Você: {jogador.Count} | " +
                $"Computador: {computador.Count}";
        }

        private void HabilitarAtributos(bool habilitar)
        {
            btnHp.Enabled = habilitar;
            btnPoder.Enabled = habilitar;
            btnVelocidade.Enabled = habilitar;
            btnForca.Enabled = habilitar;
            btnResistencia.Enabled = habilitar;
        }

        private void lblSuaCarta_Click(object sender, EventArgs e)
        {

        }

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

            lblSuaCarta.BackColor = painel;
            lblCartaComputador.BackColor = painel;

            lblSuaCarta.ForeColor = texto;
            lblCartaComputador.ForeColor = texto;

            Button[] botoes =
            {
            btnHp, btnPoder, btnVelocidade,
            btnForca, btnResistencia, btnNovoJogo
            };

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
            string caminho = Path.Combine(
                AppContext.BaseDirectory,
                "Imagens",
                nomeArquivo
            );

            if (!File.Exists(caminho))
            {
                MessageBox.Show(
                    $"Imagem não encontrada:\n{caminho}",
                    "Erro ao carregar imagem"
                );

                return null;
            }

            using (FileStream arquivo = File.OpenRead(caminho))
            using (Image imagemOriginal = Image.FromStream(arquivo))
            {
                return new Bitmap(imagemOriginal);
            }
        }

    }
}
