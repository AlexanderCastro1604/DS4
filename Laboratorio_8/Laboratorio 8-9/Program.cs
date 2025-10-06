internal class Program
{
    private static void Main(string[] args)
    {
        Template templ = new Template();

        templ.ponerVariable("var1", "Valor 1");
        templ.ponerVariable("var2", "Valor 2");
        templ.ponerVariable("var3", "Valor 3");

        templ.verHtml("<br>Texto de Prueba</br>");
    }
}

