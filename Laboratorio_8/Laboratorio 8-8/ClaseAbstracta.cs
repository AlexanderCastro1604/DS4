abstract class ClaseAbstracta
{
    
    protected abstract string tomarValor();
    public abstract string prefixValor(string prefix);

    
    public void printOut()
    {
        Console.WriteLine(tomarValor());
    }
}
