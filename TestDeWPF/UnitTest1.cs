using DeWPF;

namespace TestDeWPF
{
    [TestClass]
    public class UnitTestDeWPF
    {
        // Test du constructeur de la classe Face()
        [TestMethod]
        public void TestFace()
        {
            Face nbFace = new (5, "Pentagonal");
            Face septFace = new (7, "Septagonal");

            Assert.AreEqual(nbFace.Nom, "Pentagonal");
            Assert.AreEqual(septFace.Valeur, 7);
            Assert.AreEqual(nbFace.Valeur, 5);
            Assert.AreEqual(septFace.Nom, "Septagonal");
            Assert.AreNotSame(septFace.Valeur, 5);
        }

        // test de la classe Piece()
        [TestMethod]
        public void TestPiece()
        {
            Piece piece = new Piece();
            Assert.AreEqual(piece.NbFaces, 2);
            Assert.AreEqual(piece.Nom, "Pièce");
            Assert.AreEqual(piece.Faces[0].Nom, "pile");
        }

        // Test d la lasse De6
        [TestMethod]
        public void TestD6()
        {
            De6 de = new De6();
            Assert.AreEqual(de.NbFaces, 6);
            Assert.AreEqual(de.Nom, "Dé 6");
        }

    }
}