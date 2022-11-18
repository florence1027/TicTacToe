namespace TicTacToeObjets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            TicTacToe jeu = new TicTacToe();
            bool fini = false;
            bool gagne = false;
            bool positionValide = false;
            char joueur = 'X';
            char ordinateur = 'O';
            int position = 0;
            string gagnant = "";

            jeu.afficherJeu();
            while (!fini)
            {
                Console.WriteLine("À votre tour! Sélectionnez la case à remplir");
                while(positionValide == false)
                {
                    int.TryParse(Console.ReadLine(), out position);
                    positionValide = jeu.placerSymbole(joueur, position);
                }
                jeu.afficherJeu();
                positionValide = false;
                fini = jeu.gagnerTicTacToe(out gagnant);
                
                

                Console.WriteLine("Au tour de l'ordinateur!");
                while(!positionValide)
                {
                    position = random.Next(0, 9);
                    positionValide = jeu.placerSymbole(ordinateur, position);
                }
                jeu.afficherJeu();
                positionValide = false;
                fini = jeu.gagnerTicTacToe(out gagnant);
                
            }
            Console.WriteLine(gagnant + " a gagné!");
            
        }
    }
}