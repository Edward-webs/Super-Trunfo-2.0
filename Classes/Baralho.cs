using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Trunfo_2._0.Classes
{
    public class Baralho
    {
        private Carta[] _cards = new Carta[32];

        public Baralho()
        {
            _cards[0] = new Carta("A1", "Guerreiro", 100, 85, 40, 80, 90);
            _cards[1] = new Carta("A2", "Mago", 80, 90, 60, 70, 60);
            _cards[2] = new Carta("A3", "Arqueiro", 90, 75, 80, 65, 70);
            _cards[3] = new Carta("A4", "Ladino", 70, 80, 90, 60, 50);
            _cards[4] = new Carta("A5", "Paladino", 110, 80, 50, 85, 95);
            _cards[5] = new Carta("A6", "Bárbaro", 120, 90, 30, 95, 80);
            _cards[6] = new Carta("A7", "Druida", 85, 75, 70, 65, 80);
            _cards[7] = new Carta("A8", "Assassino", 75, 85, 95, 55, 60);
            _cards[8] = new Carta("B1", "Necromante", 80, 90, 50, 70, 65);
            _cards[9] = new Carta("B2", "Monge", 90, 80, 85, 60, 75);
            _cards[10] = new Carta("B3", "Feiticeiro", 85, 90, 60, 70, 65);
            _cards[11] = new Carta("B4", "Anão", 100, 85, 40, 80, 90);
            _cards[12] = new Carta("B5", "Goblin", 60, 70, 50, 40, 30);
            _cards[13] = new Carta("B6", "Orc", 110, 80, 30, 90, 70);
            _cards[14] = new Carta("B7", "Troll", 120, 75, 20, 85, 80);
            _cards[15] = new Carta("B8", "Dragão", 150, 100, 40, 95, 90);
            _cards[16] = new Carta("C1", "Vampiro", 90, 85, 70, 80, 60);
            _cards[17] = new Carta("C2", "Zumbi", 80, 60, 30, 50, 40);
            _cards[18] = new Carta("C3", "Esqueleto", 70, 65, 40, 45, 35);
            _cards[19] = new Carta("C4", "Golem", 130, 75, 20, 85, 95);
            _cards[20] = new Carta("C5", "Anjo", 100, 90, 60, 80, 70);
            _cards[21] = new Carta("C6", "Demônio", 110, 85, 50, 90, 80);
            _cards[22] = new Carta("C7", "Fada", 80, 70, 90, 60, 50);
            _cards[23] = new Carta("C8", "Sereia", 85, 75, 80, 65, 70);
            _cards[24] = new Carta("D1", "Centauro", 95, 80, 70, 75, 65);
            _cards[25] = new Carta("D2", "Minotauro", 120, 85, 30, 90, 80);
            _cards[26] = new Carta("D3", "Fênix", 110, 90, 60, 85, 75);
            _cards[27] = new Carta("D4", "Grifo", 100, 80, 70, 75, 65);
            _cards[28] = new Carta("D5", "SUPER TRUNFO", 130, 85, 40, 90, 80, true);
            _cards[29] = new Carta("D6", "Quimera", 120, 80, 50, 85, 75);
            _cards[30] = new Carta("D7", "Gigante", 90, 75, 80, 65, 60);
            _cards[31] = new Carta("D8", "Fantasma", 95, 80, 70, 75, 65);
        }

        public Carta[] getCards()
        {
            return _cards;
        }
    }
}
