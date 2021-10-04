class Name
{
    ##region Properties 

    public string firstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public string lastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }

    public int weight
    {
        get { return _weight; }
        set { _weight = value; }
    }

    public int beginYear
    {
        get { return _beginYear; }
        set { _beginYear = value; }
    }

    public string weapon
    {
        get { return _weapon; }
        set { _weapon = value; }
    }

    public string armor
    {
        get { return _armor; }
        set { _armor = value; }
    }

    ##endregion

    ##region Attributes

    private string _firstName; 
    
    private string _lastName;
    
    private int _weight;
    
    private int _beginYear;
    
    private string _weapon;
    
    private string _armor;
    
    ##endregion

    public Person(Parameters)
    {
        
    }
}