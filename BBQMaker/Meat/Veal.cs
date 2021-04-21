namespace BBQMaker.Meat
{
    class Veal : AbstractMeat
    {
        public Veal()
        {
            Name = "Veal";
        }
        public override string GetName()
        {
            return Name;
        }
    }
}
