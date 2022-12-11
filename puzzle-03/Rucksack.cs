using Microsoft.VisualBasic;

namespace puzzle_03;

public class Rucksack
{
    public string Data { get; private set; }
    public string FirstCompartment { get; private set; }
    public string SecondCompartment { get; private set; }
    public char CommonItemType { get; private set; }

    public Rucksack(string data)
    {
        Data = data;
        FirstCompartment = data.Substring(0, data.Length / 2);
        SecondCompartment = data.Substring(data.Length / 2, data.Length / 2);
        CommonItemType = FirstCompartment.Intersect(SecondCompartment).First();
    }
}