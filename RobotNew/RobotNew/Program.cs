using System;
using System.Collections.Generic;


public class Robot
{
    static Random random = new Random();

    private static Dictionary<Robot, string> names = new Dictionary<Robot, string>();
    public Robot()
    {
        names.Add(this, null);
    }
    public string Name
    {
        get
        {
            names.TryGetValue(this, out string value);
            if (value == null)
            {
                value = GenerateName();
                names[this] = value;
            }
            return value;
        }
    }
    public string GenerateName()
    {
        string newName = String.Empty;
        do
        {
            newName = Convert.ToChar(random.Next('A', 'Z' + 1)).ToString()
                + Convert.ToChar(random.Next('A', 'Z' + 1)) +
                random.Next(100, 1000).ToString();
        }
        while (names.ContainsValue(newName));
        return newName;
    }
    public void Reset()
    {
        names[this] = null;
        names[this] = Name;
    }
}
