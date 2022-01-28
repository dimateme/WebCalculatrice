using System;
using WebCalculatrice.Logic.Modeles;
namespace WebCalculatrice.Logic.Modeles
{
    public class RationnelModel
    {
        /// <summary>
        /// Propriété représentant le numérateur
        /// </summary>
        public int Numerateur { get; set; }


        /// <summary>
        /// Propriété représentant le dénominateur
        /// </summary>
        public int Denominateur { get; set; }

        /// <summary>
        /// Constructeur avec paramètres de la classe.
        /// </summary>
        /// <param name="unNumerateur">Paramètre contenant la valeur d'affectation à la propriété Numerateur</param>
        /// <param name="unDenominateur">Paramètre contenant la valeur d'affectation à la propriété Denominateur</param>
        public RationnelModel(int unNumerateur = 0, int unDenominateur = 0)
        {
            Numerateur = unNumerateur;
            Denominateur = unDenominateur;
        }

        /// <summary>
        /// Méthode de service permettant d'additionner des objets de type Rationnel.
        /// </summary>
        /// <param name="rationnel">Paramètre contenant l'objet Rationnel à ajouter</param>
        /// <returns>Retourne le résultat de l'addition entre l'objet courant (this) et l'objet Rationnel passé en paramètre.</returns>
        public RationnelModel Ajouter(RationnelModel rationnel)
        {
            RationnelModel unRationnel = new RationnelModel();
            unRationnel.Numerateur = (Numerateur * rationnel.Denominateur) + (Denominateur * rationnel.Numerateur);
            unRationnel.Denominateur = (Denominateur * rationnel.Denominateur);
            return unRationnel.Simplifier();
        }

        /// <summary>
        /// Méthode de service permettant soustraire des objets de type Rationnel.
        /// </summary>
        /// <param name="rationnel">Paramètre contenant l'objet Rationnel à soustraire</param>
        /// <returns>Retourne le résultat de la soustraction entre l'objet courant (this) et l'objet Rationnel passé en paramètre.</returns>
        public RationnelModel Soustraire(RationnelModel rationnel)
        {
            RationnelModel unRationnel = new RationnelModel();
            unRationnel.Numerateur = (Numerateur * rationnel.Denominateur) - (Denominateur * rationnel.Numerateur);
            unRationnel.Denominateur = (Denominateur * rationnel.Denominateur);
            return unRationnel.Simplifier();
        }

        /// <summary>
        /// Méthode de service permettant multiplier des objets de type Rationnel.
        /// </summary>
        /// <param name="rationnel">Paramètre contenant l'objet Rationnel à multiplier</param>
        /// <returns>Retourne le résultat de la multiplication entre l'objet courant (this) et l'objet Rationnel passé en paramètre.</returns>
        public RationnelModel Multiplier(RationnelModel rationnel)
        {
            RationnelModel unRationnel = new RationnelModel();
            unRationnel.Numerateur = (Numerateur * rationnel.Numerateur);
            unRationnel.Denominateur = (Denominateur * rationnel.Denominateur);
            return unRationnel.Simplifier();
        }

        /// <summary>
        /// Méthode de service permettant diviser des objets de type Rationnel.
        /// </summary>
        /// <param name="rationnel">Paramètre contenant l'objet Rationnel à diviser</param>
        /// <returns>Retourne le résultat de la division entre l'objet courant (this) et l'objet Rationnel passé en paramètre.</returns>
        public RationnelModel Diviser(RationnelModel rationnel)
        {
            RationnelModel unRationnel = new RationnelModel();
            unRationnel.Numerateur = (Numerateur * rationnel.Denominateur);
            unRationnel.Denominateur = (Denominateur * rationnel.Numerateur);
            return unRationnel.Simplifier();
        }

        /// <summary>
        /// Méthode de service permettant de simplifier un objet de type Rationnel.
        /// </summary>
        /// <returns>Retourne l'objet de type Rationnel simplifié.</returns>
        private RationnelModel Simplifier()
        {
            int X;
            int diviseur = 0;
            X = (Numerateur > Denominateur ? Numerateur : Denominateur);
            for (int i = 1; i <= X; i++)
                if (Numerateur % i == 0)
                    if (Denominateur % i == 0)
                        diviseur = i;
            Numerateur = Numerateur / diviseur;
            Denominateur = Denominateur / diviseur;
            return this;
        }

        /// <summary>
        /// Méthode d'affichage surchargée de la classe parent Objet.
        /// </summary>
        /// <returns>Retourne une chaîne de caractère permettant d'afficher l'objet en format texte.</returns>
        public override string ToString()
        {
            if (Numerateur == Denominateur)
                return "1";
            else if (Denominateur == 1)
                return Numerateur.ToString();
            else if (Numerateur == 0)
                return "0";
            return Numerateur + "/" + Denominateur;
        }

        /// <summary>
        /// Méthode de comparaison d'égalité surchargée de la classe parent Objet.
        /// </summary>
        /// <param name="obj">L'objet avec lequel on veut faire la comparaison.</param>
        /// <returns>Retourne TRUE si les deux objets sont identiques; Retourne FALSE si les deux objets sont différents</returns>
        public override bool Equals(object obj)
        {
            RationnelModel unRationnel = obj as RationnelModel;
            if (
                 (Numerateur == unRationnel.Numerateur)
                &&
                 (Denominateur == unRationnel.Denominateur)
               )
                return true;
            return false;
        }

        /// <summary>
        /// Méthode d'obtention du HashCode surchargée de la classe parent Objet.
        /// </summary>
        /// <returns>Retour le HaseCode de l'objet de type Rationnel</returns>
        public override int GetHashCode()
        {
            return (Numerateur) + (2 * Denominateur);
        }
    }
}
