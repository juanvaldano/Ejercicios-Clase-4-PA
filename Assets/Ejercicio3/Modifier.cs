
public class Modifier
{
    private int _modValue;
    private string _modName;

    public Modifier(int modValue, string modName)
    {
        _modValue = modValue;
        _modName = modName;
    }

    public int GetValue()
    {
        return _modValue;
    }

    public string GetName()
    {
        return _modName;
    }
}
