using zoologicoEjercicio;

internal class Program
{
    private string nombre { get; set; }

    static void Main(string[] args)
    {
        
        Animal a = new Animal("leon", "felino", "carne");
        cuidador cu = new cuidador();
        cu.nombre = "pablo";
        Zoo z = new Zoo();
        z.nuevoAnumal(a);
        z.nuevoCuidador(cu);

        z.nuevoAnumal(new Animal("dsfdsf", "sdfsd", "tyutyhj"));
        z.nuevoAnumal(new Animal("gng", "igi", "jykoth"));
        z.nuevoAnumal(new Animal("tyjs", "yjty", "pei"));
        z.nuevoAnumal(new Animal("kgrk", "klthklt", "jkdgr"));
        z.nuevoAnumal(new Animal("erkl", "wlñr", "klker"));
        z.poblacion();

        Console.WriteLine("*****************");

        z.list_cuidador[0].alimentar(z.list_animal);
    }
}