namespace BBQMaker.Meat
{
    public class Pork : AbstractMeat
    {
        public Pork()
        {
            Name = "pork";
        }

        public override string GetName()
        {
            return Name;
        }
    }
}
