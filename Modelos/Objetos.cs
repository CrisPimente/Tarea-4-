using System.Security.Cryptography.X509Certificates;
public enum Tipo
{
    Serie = 'S',
    Pelicula = 'P',
    Libro = 'L'
}
public class SeriePeliculaLibro
{
    public int Id {get; set;}
    public string Nombre {get; set;}= "";
    public Tipo Tipo {get; set;} = Tipo.Serie;
    public string Pais {get; set;}= "";
    public string Idioma {get; set;}= "";
    public string FotoUrl {get; set;}= "";
    public string Resumen {get; set;}= "";


    public List<Personaje> Personajes {get; set;} =new List<Personaje>();  
}
public class Personaje{
    public int Id {get; set;}
    public string Nombre {get; set;}= "";
    public string Apodo {get; set;}= string.Empty;
    public string Raza {get; set;}= "";
    public string FotoUrl {get; set;}= "";
    public int Edad {get; set;}= 0;
    public string PoderCaracteristico {get; set;}= "";
    public int SeriePeliculaLibroId {get; set;}
    public SeriePeliculaLibro SeriePeliculaLibro {get; set;}= null!;

}
