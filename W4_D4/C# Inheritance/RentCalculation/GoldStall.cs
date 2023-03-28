class GoldStall : Stall
{
    public double _discount;
    public GoldStall() { }
    public GoldStall(string _name, string _detail, string _owner, double _costPerDay, double _discount) : base(_name, _detail, _owner, _costPerDay)
    {
        this._discount = _discount;
    }
   double rent;

    public override double CalculateRent(int days)
    {
        rent = (days * base.costPerDay) - ((days * base.costPerDay )* discount/100);
    }
    public override string ToString()
    {
        //Fill your code here
        Console.WriteLine("Your Total Cost {0}", rent );

        return "";
    }
}