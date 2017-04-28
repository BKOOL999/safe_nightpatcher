public class NameWrapper
{
    public string ingameName;
    public string dataName;
    public NameWrapper(string iname, string dname)
    {
        ingameName = iname;
        dataName = dname;
    }

    public override string ToString()
    {
        return ingameName;
    }
}