namespace ParcialProgramacion;
class Program
{
    static void Main(string[] args)
    {

        static string rot13(string palabra)
        {
            char[] letras = palabra.ToCharArray();

            for (int i = 0; i < palabra.Length; i++)
            {
                char x = palabra[i];
                if (x >= 'A' && x <= 'M')
                {
                    letras[i] = (char)(x + 13);
                }
                else if (x >= 'N' && x <= 'Z')
                {
                    letras[i] = (char)(x - 13);
                }
                
            }
            return new string(letras);
        }

        Console.WriteLine(rot13("NLRE RFGNON YYBIVRAQB..."));
        Console.ReadKey();
    }
}

