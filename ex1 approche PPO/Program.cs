using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1_approche_PPO
{
    class Program
    {
        struct Compte
        {
            public int numeroCompte;
            public string nomCompte;
            public string prenomCompte;
            public int soldeCompte;           
        }

        static void InitCompte( ref Compte unCompte, int NumCompte, string NomCompte, string PrenomCompte)
        {
            unCompte.nomCompte = NomCompte;
            unCompte.numeroCompte = NumCompte;
            unCompte.prenomCompte = PrenomCompte;
            unCompte.soldeCompte = 0 ;

        }
        
        static void CrediterCompte( ref Compte unCompte, int montant_Ajoute) 
        {
            unCompte.soldeCompte = unCompte.soldeCompte +  montant_Ajoute;
            
        }
        static void DebiterCompte(ref Compte unCompte, int montant_Soustrait)
        {
            
            unCompte.soldeCompte = unCompte.soldeCompte - montant_Soustrait;

        }

        static int GetNumero(ref Compte unCompte) 
        {
            return unCompte.numeroCompte;
        }
        static string GetNom(ref Compte unCompte)
        {
            return unCompte.nomCompte;
        }
        static string GetPrenom(ref Compte unCompte)
        {
            return unCompte.prenomCompte;
        }
        static int GetSolde(ref Compte unCompte)
        {

            return unCompte.soldeCompte;
        }

        static void Main(string[] args)
        {
            Compte c2 = new Compte();
            InitCompte(ref c2, 2, "Durand", "Marc");
            CrediterCompte(ref c2, 1500);
            
            DebiterCompte(ref c2, 300);
            
            DebiterCompte(ref c2, 50);
            
            Console.WriteLine("Compte N° {0}", GetNumero(ref c2)); 
            Console.WriteLine("Nom : {0}", GetNom(ref c2));
            Console.WriteLine("Prenom : {0}", GetPrenom(ref c2));
            Console.WriteLine("Solde : {0}", GetSolde(ref c2));
            Console.WriteLine();
            Console.ReadKey();
        }

        
    }
}
