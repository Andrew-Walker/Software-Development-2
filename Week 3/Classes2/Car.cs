public class Car
{
    private string colour;
    private string type;
    private string make;
    private string country;
    private double cost;
    private double engineSize;

    public double EngineSize //property for manipulating colour
    {
        get { return engineSize; }
        set { engineSize = value; }
        // usually the above is written in the more compact form shown below
    }

    public string Colour //property for manipulating colour
    {
        get { return colour; }
        set { colour = value; }
        // usually the above is written in the more compact form shown below
    }
    public string Type //property for manipulating type
    {
        get { return type; }
        set { type = value; }
    }
    public string Country //property for manipulating country
    {
        get { return country; }
        set { country = value; }
    }
    public string Make //property for manipulating make
    {
        get { return make; }
        set { make = value; }
    }
    public double Cost //property for manipulating cost
    {
        get { return cost; }
        set { cost = value; }
    }
}