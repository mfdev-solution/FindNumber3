using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        int parser = 0;
        int nombre = 0;
        int nbEssais = 0;
        ArrayList listNbrTested = new ArrayList();
        Console.WriteLine("Veuillez saisir la borne inférieure : ");
        string  borneInf = Console.ReadLine();
        Console.WriteLine("Veuillez saisir la borne inférieure : ");
        string borneSup = Console.ReadLine();
        Console.WriteLine("Entrez le nombre de fois que vous essayer");
        var nbEssaisPossible = Console.ReadLine();
        Boolean isCorrect = false;

        if(int.TryParse(borneInf, out parser) && int.TryParse(borneSup,out parser))
        {
            //reordonneer les bornes
            int intborneInf = Convert.ToInt32(borneInf);
            int intborneSup = Convert.ToInt32(borneSup);
            if(intborneInf > intborneSup)
            {
                int temp = intborneInf;
                intborneInf = intborneSup;
                intborneSup = temp;

            }
            //genrer un nombre aleatoir
            Random rand = new Random();
            nombre = rand.Next(intborneInf,intborneSup+1);
            int intnbEssaisPossible = Convert.ToInt32(nbEssaisPossible);

            while (!isCorrect && nbEssais < intnbEssaisPossible)
            {
                Console.WriteLine("Veuillez saisir un nombre :");
                string nb = Console.ReadLine();

                nbEssais++;
                listNbrTested.Add(nb);

                if (int.TryParse(nb, out parser))
                {
                    int intnb = Convert.ToInt32(nb);
                    if (intborneInf <= nombre && nombre <= intborneSup)
                    {
                        if (nombre == intnb)
                        {
                            Console.WriteLine("Vous avez gagné avec une note de  "+intnbEssaisPossible+"/" +nbEssais);

                            isCorrect= true;
                        }
                        else if(nombre > intnb)
                        {
                            Console.WriteLine("le nombre est plus grand");
                        }
                        else
                        {
                            Console.WriteLine("le nombre est plus petit");
                        }
                        

                    }
                    else
                    {
                        Console.WriteLine("Le nombre saisi n'est pas compris entre {0} et {0} !",intborneInf,intborneSup);
                    }
                }
                else
                {
                    Console.WriteLine("La valeur  entrée n'est pas un nombre entier ");
                }

                foreach (var nbrTested in listNbrTested)
                {
                    Console.Write(nbrTested + "\t");
                }
                Console.WriteLine();
            }

        }else
        {
            Console.WriteLine("Les bornes doivent etre des entiers");
        }


        if(nbEssais == Convert.ToInt32(nbEssaisPossible))
        {

        Console.WriteLine("Vous avez perdu -:) !");        /*  Boolean isCorrect = false; */
        }


        
    }
}