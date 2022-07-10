class Desarrollo
{
    public static void PrimerParcial()
    {
        Console.Clear();

        string cedula = Utils.LeerString("Digita la cedula");
        string url = "https://api.adamix.net/apec/cedula/" + cedula;

        System.Net.WebClient client = new System.Net.WebClient();
        string datos = client.DownloadString(url);

        Persona respuesta = Newtonsoft.Json.JsonConvert.DeserializeObject<Persona>(datos) ?? new Persona();

        if (respuesta.ok)
        {
            Console.WriteLine();
            Console.WriteLine("Nombre = " + respuesta.Nombres);
            Console.WriteLine("Apellido = " + respuesta.Apellido1);
            Console.WriteLine("Fecha de Nacimiento = " + respuesta.FechaNacimiento);
            Console.WriteLine("Lugar de Nacimiento = " + respuesta.LugarNacimiento);
            Console.WriteLine("Sexo = " + respuesta.IdSexo);
            Utils.MostrarError("Presiona ENTER para continuar.");
            Console.Clear();

            string plantilla = System.IO.File.ReadAllText("PantillaPersona.html");
            plantilla = plantilla.Replace("Nombres", respuesta.Nombres);
            plantilla = plantilla.Replace("Apellidos", respuesta.Apellido1 + " " + respuesta.Apellido2);
            plantilla = plantilla.Replace("url-foto", respuesta.foto);
            plantilla = plantilla.Replace("Sexo", respuesta.IdSexo);
            plantilla = plantilla.Replace("Fecha de nacimiento", respuesta.FechaNacimiento);
            plantilla = plantilla.Replace("Lugar de nacimiento", respuesta.LugarNacimiento);
            plantilla = plantilla.Replace("edad", respuesta.edad().ToString());


            System.IO.File.WriteAllText("cedula.html", plantilla);
            var uri = "cedula.html";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);

        }
        else
        {
            Utils.MostrarError("Cédula no valida");
        }


    }
}

public class Persona
{
    public string Cedula { get; set; } = "";
    public string Nombres { get; set; } = "";
    public string Apellido1 { get; set; } = "";
    public string Apellido2 { get; set; } = "";
    public string FechaNacimiento { get; set; } = "";
    public string LugarNacimiento { get; set; } = "";
    public string IdSexo { get; set; } = "";
    public string IdEstadoCivil { get; set; } = "";
    public string IDEstatus { get; set; } = "";
    public string CedulaAnterior { get; set; } = "";
    public bool ok { get; set; }
    public string foto { get; set; } = "";
    public double edad()
    {
        DateTime fechaNacimiento = DateTime.Parse(FechaNacimiento);
        DateTime fechaActual = DateTime.Now;
        int edad = fechaActual.Year - fechaNacimiento.Year;

        return edad;
    }

}
