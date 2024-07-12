// See https://aka.ms/new-console-template for more informatio
namespace Contraseña
{ 
internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("\n");
int minLength = 8;
        string uppercase = "ABCDEFGHIJKMLOPQRSTWXYZ";

        string lowercase = " abcdefghijkmlopqrstwxys";
        string digits = " 0123456789";

        string specialChars = "-@$#";

        Console.WriteLine("Ingrese una contraseña segura \n" +
"1. Al menos 8 caracteres \n" +
"2. Utiliza un caracter especial \n" +
"3. Coloque al menos un digito entre 0-9");


            // captura la contraseña ingresada por el usuario 

string userPassword = Console.ReadLine();

            int score = 0;

            if (userPassword.Length >= minLength)
            {
                score += 1;
            
            }
            if (userPassword.Length < minLength)
            {
                Console.WriteLine("La contraseña debe contar con minimo de 8 caracteres");
            }

            //Valida si tiene algún caracter minúscula

            if (ContainsAny(userPassword, lowercase))
            { 
            score += 1;
            }
            //Valida si tiene algún caracter mayuscula
            if (ContainsAny(userPassword, uppercase))
            {
                score += 1;
            }
            //Valida si tiene algún caracter especial 
            if (ContainsAny(userPassword, specialChars))
            {
                score += 1;
            }

            if (ContainsAny(userPassword, digits))
            {
                score += 1;
            }
            //Valida si tiene algún digito
            static bool ContainsAny(string input, string characters)
            {
                foreach (char c in characters)
                {
                    if (input.Contains(c))
                    {
                        return true;
                    }
                }
                return false;
            }
            Console.WriteLine("El score de la contraseña es:" + score);

            if (score >= 5)
            {
                Console.WriteLine("Tú contraseña es perfecta");
            }
                else if (score == 3)
                {
                    Console.WriteLine("Tú contraseña es buena");
                }
              else
            {

                Console.WriteLine("Tú contraseña es debil");
            }
        }
    }

        }
        
    

