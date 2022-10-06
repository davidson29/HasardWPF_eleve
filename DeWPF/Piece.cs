using System.Diagnostics;

namespace DeWPF
{
    // Une pièce de monnaie à deux faces
    public class Piece : ObjetHasard
    {
        public Piece() : base("Pièce", 2) { }

        protected sealed override void CreerFaces()
        {
            Faces[0] = new Face(0, "pile");
            Faces[1] = new Face(0, "face");

            /* S'assure que la variable 'valeur' va bien jusqu'à NbFaces,
 sinon arrête le programme et affiche le message avec la pile d'appels du programme */
            Debug.Assert(Faces[0].Nom == "pile", "Le tableau Faces ne recoit pas les valeurs passées directement au constructeur de Face()");
            Debug.Assert(Faces[1].Valeur == 0, "Le tableau Faces ne recoit pas les valeurs passées directement au constructeur de Face()");
        }
    }
}