using System;

public class Resources
{
    public Resources()
    {

        public string NewResource = string.Empty;
    public int ResourceIdentity = 0;

    public void CreattionMethod(string _newName)
    {
        Console.Log(_newName);
        NewResource = _newName;
    }
}
}
