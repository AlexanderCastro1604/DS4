class Template : iTemplate
{
    public void ponerVariable(string nombre, string var)
    {
        Console.WriteLine($"Método poner variable {nombre} : {var}");
    }

    public void verHtml(string template)
    {
        Console.WriteLine(template);
    }
}
