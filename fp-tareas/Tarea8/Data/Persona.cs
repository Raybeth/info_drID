public class Persona
{
    public string Cedula { get; set; }
    public string Nombres { get; set; }
    public string Apellido1 { get; set; }
    public string Apellido2 { get; set; }
    public string FechaNacimiento { get; set; }
    public string LugarNacimiento { get; set; }
    public string IdSexo { get; set; }
    public string IdEstadoCivil { get; set; }
    public string IDEstatus { get; set; }
    public string EstatusCedulaAzul { get; set; }
    public string CedulaAnterior { get; set; }
    public bool ok { get; set; }
    public string foto { get; set; }

    public double edad()
    {
        DateTime fechaNacimiento = DateTime.Parse(FechaNacimiento);
        DateTime fechaActual = DateTime.Now;
        int edad = fechaActual.Year - fechaNacimiento.Year;

        return edad;
    }

    public string signo()
    {
        /*DateTime fechaNacimiento = DateTime.Parse(FechaNacimiento);

        var mes = fechaNacimiento.Month;
        var dia = fechaNacimiento.Day;*/


        return "Libra";

        /* switch (mes)
         {
             case 1:
                 if (dia < 21)
                     Console.WriteLine("Capricornio");
                 else
                     Console.WriteLine("Acuario");

                 break;
             case 2:
                 if (dia < 19)
                     Console.WriteLine("Acuario");
                 else Console.WriteLine("Pisis");
                 break;
             case 3:
                 if (dia < 21)
                     Console.WriteLine("Pisis");
                 else Console.WriteLine("Aries");
                 break;
             case 4:
                 if (dia < 21)
                     Console.WriteLine("Aries");
                 else Console.WriteLine("Tauro");
                 break;
             case 5:
                 if (dia < 22)
                     Console.WriteLine("Tauro");
                 else Console.WriteLine("Geminis");
                 break;
             case 6:
                 if (dia < 22)
                     Console.WriteLine("Geminis");
                 else Console.WriteLine("Cancer");
                 break;
             case 7:
                 if (dia < 23)
                     Console.WriteLine("Cancer");
                 else Console.WriteLine("Leo");
                 break;
             case 8:
                 if (dia < 24)
                     Console.WriteLine("Leo");
                 else Console.WriteLine("Virgo");
                 break;
             case 9:
                 if (dia < 24)
                     Console.WriteLine("Virgo");
                 else Console.WriteLine("Libra");
                 break;
             case 10:
                 if (dia < 24)
                     Console.WriteLine("Libra");
                 else Console.WriteLine("Escorpion");
                 break;
             case 11:
                 if (dia < 23)
                     Console.WriteLine("Escorpion");
                 else Console.WriteLine("Sagitario");
                 break;
             case 12:
                 if (dia < 22)
                     Console.WriteLine("Sagitario");
                 else Console.WriteLine("Capricornio");
                 break;
         }
             return signo();

 */
    }

}

