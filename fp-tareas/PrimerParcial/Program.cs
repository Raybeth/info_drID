bool continuar = true;

while (continuar)
{
    Console.Clear();
    Console.WriteLine(@"Examen primer parcial Fundamentos de Programacion
    
    Aceptar una cedula y mostrar datos de la misma.

    1. Verificar Cédula
    2. Salir

    ");
    string opcion = Utils.LeerString("Digita la opcion que deseas: ");
    switch (opcion)
    {
        case "1":
            Desarrollo.PrimerParcial();
            break;
        case "2":
            continuar = false;
            Utils.MostrarError("Gracias por consultar. Vuelva pronto.");
            break;
        default:
            Utils.MostrarError("Opcion no valida.");
            break;
    }


}
