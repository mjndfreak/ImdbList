namespace ImdbList;

public class Film
{
    private double _rating;

    public double Rating
    {
        get
        {
            return _rating;
        }
        set
        {
            if (value >= 0 && value <= 10)
            {
                _rating = value;
            }
            else
            {
                Console.WriteLine("This value must be between 0-10");
            }
        }
    }

    public string Name { get; set; }

    public override string ToString()
    {
        return Name + " *** " + Rating;
    }
}