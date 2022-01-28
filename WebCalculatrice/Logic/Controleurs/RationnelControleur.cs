using WebCalculatrice.Logic.Modeles;

/// <summary>
/// Namespace pour les conntroleurs (logique).
/// </summary>
namespace WebCalculatrice.Logic.Controleurs
{
    /// <summary>
    /// Classe représentant le controleur (logique) pour les calculs de rationnels.
    /// </summary>
    public class RationnelControleur
    {
        /// <summary>
        /// Attribut représentant l'instance unique de la classe RationnelControleur.
        /// </summary>
        private static RationnelControleur instance;

        /// <summary>
        /// Propriété permettant d'accèder à l'instance unique de la classe.
        /// </summary>
        public static RationnelControleur Instance
        {
            get
            {
                //Si l'instance est null...
                if (instance == null)
                {
                    //... on crée l'instance unique...
                    instance = new RationnelControleur();
                }
                //...on retourne l'instance unique.
                return instance;
            }
        }

        /// <summary>
        /// Constructeur par défaut de la classe.
        /// </summary>
        private RationnelControleur() { }

        /// <summary>
        /// Méthode permettant d'additionner deux rationnels.
        /// </summary>
        /// <param name="rationnel1"></param>
        /// <param name="rationnel2"></param>
        /// <returns></returns>
        public string AdditionRationnel(int numerateur1, int denominateur1, int numerateur2, int denominateur2)
        {
            RationnelModel rationnel1 = new RationnelModel(numerateur1, denominateur1);
            RationnelModel rationnel2 = new RationnelModel(numerateur2, denominateur2);
            return rationnel1.Ajouter(rationnel2).ToString();
        }

        /// <summary>
        /// Méthode permettant de soustraire deux rationnels.
        /// </summary>
        /// <param name="rationnel1"></param>
        /// <param name="rationnel2"></param>
        /// <returns></returns>
        public string SoustractionRationnel(int numerateur1, int denominateur1, int numerateur2, int denominateur2)
        {
            RationnelModel rationnel1 = new RationnelModel(numerateur1, denominateur1);
            RationnelModel rationnel2 = new RationnelModel(numerateur2, denominateur2);
            return rationnel1.Soustraire(rationnel2).ToString();
        }

        /// <summary>
        /// Méthode permettant de multiplier deux rationnels.
        /// </summary>
        /// <param name="rationnel1"></param>
        /// <param name="rationnel2"></param>
        /// <returns></returns>
        public string MultiplicationRationnel(int numerateur1, int denominateur1, int numerateur2, int denominateur2)
        {
            RationnelModel rationnel1 = new RationnelModel(numerateur1, denominateur1);
            RationnelModel rationnel2 = new RationnelModel(numerateur2, denominateur2);
            return rationnel1.Multiplier(rationnel2).ToString();
        }

        /// <summary>
        /// Méthode permettant de diviser deux rationnels.
        /// </summary>
        /// <param name="rationnel1"></param>
        /// <param name="rationnel2"></param>
        /// <returns></returns>
        public string DivisionRationnel(int numerateur1, int denominateur1, int numerateur2, int denominateur2)
        {
            RationnelModel rationnel1 = new RationnelModel(numerateur1, denominateur1);
            RationnelModel rationnel2 = new RationnelModel(numerateur2, denominateur2);
            return rationnel1.Diviser(rationnel2).ToString();
        }
    }
}
