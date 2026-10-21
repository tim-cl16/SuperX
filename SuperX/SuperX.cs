using System;
using System.Collections.Generic;
using System.Text;

namespace superXDev
{
    public class SuperX
    {

        public void SeDeconnecter()
        {
            RunCommande run = new RunCommande();
            Console.WriteLine($@"
quelle fonction lancé : 
    D -> Deconnecte() 
    A -> Arret()
    R -> Redemarrer()
    V -> Veille(): ");

            switch (Console.ReadKey().KeyChar)
            {
                case 'R':
                    Redemarrer();
                    break;
            }
        }

        public void Redemarrer()
        {
            RunCommande.RunCommandWithBash("sudo -S reboot");
        }
    }

   
}