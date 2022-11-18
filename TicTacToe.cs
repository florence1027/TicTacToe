using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeObjets
{
    public class TicTacToe
    {
        char[] tableau;
        int tour;

        public TicTacToe()
        {
            tableau = new char[9]
            {
                ' ', ' ', ' ',
                ' ', ' ', ' ',
                ' ', ' ', ' ',
            };
            this.tour = 0;
        }

        public bool gagnerTicTacToe (out string gagnant)
        {
            bool gagne = false;
            string gagnant2 = "";
            

            //Pour rangée
            for (int i = 0; i < 9; i += 3)
            {
                if (tableau[i] == tableau[i + 1] && tableau[i] == tableau[i + 2])
                {
                    if (tableau[i] == 'X')
                    {
                        gagnant2 = "joueur";
                        gagne = true;
                    }
                    else if (tableau[i] == 'O')
                    {
                        gagnant2 = "ordi";
                        gagne = true;
                    }
                }
            }

            //Pour colonne
            for (int j = 0; j < 3; j++)
            {
                if (tableau[j] == tableau[j + 3] && tableau[j] == tableau[j + 6])
                {
                    if (tableau[j] == 'X')
                    {
                        gagnant2 = "joueur";
                        gagne = true;
                    }
                    else if (tableau[0] == 'O')
                    {
                        gagnant2 = "ordi";
                        gagne = true;
                    }
                }
            }

            //Pour diagonale
            if (tableau[0] == tableau[4] && tableau[0] == tableau[8])
            {
                if (tableau[0] == 'X')
                {
                    gagnant2 = "joueur";
                    gagne = true;
                }
                else if (tableau[0] == 'O')
                {
                    gagnant2 = "ordi";
                    gagne = true;
                }
            }
            if (tableau[2] == tableau[4] && tableau[2] == tableau[6])
            {
                if (tableau[2] == 'X')
                {
                    gagnant2 = "joueur";
                    gagne = true;
                }
                else if (tableau[2] == 'O')
                {
                    gagnant2 = "ordi";
                    gagne = true;
                }
            }

            gagnant = gagnant2;
            return gagne;
        }

        public bool placerSymbole(char symbole, int position)
        {
            bool placer = false;
            

            //Quel symbole je place?
            

            //Position vide?
            if (this.tableau[position] != ' ')
            {
                placer = false;
            }
            else
            {
                this.tableau[position] = symbole;
                placer = true;
            }
            //Quand je place un symbole, passer au tour suivant
            this.tour++;

            return placer;
        }

        public void afficherJeu()
        {
            string table = $"| {this.tableau[0]} | {this.tableau[1]} | {this.tableau[2]} | ( 0 1 2 ) \n| {this.tableau[3]} | {this.tableau[4]} | {this.tableau[5]} | ( 3 4 5 )\n| {this.tableau[6]} | {this.tableau[7]} | {this.tableau[8]} | ( 6 7 8 )";
            Console.WriteLine(table);
        }
    }
}
