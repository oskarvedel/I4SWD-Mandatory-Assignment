namespace CompositeDemo
{
    public class Team : CompanyPart
    {
        //constructor
        public Team(string componentName, int numOfPens, float moneySpentOnPens) : base(componentName,numOfPens,moneySpentOnPens)
        {
            ComponentName = componentName;
            NumOfPens = numOfPens;
            MoneySpentOnPens = moneySpentOnPens;
        }
        //get and set methods
        public override int GetNumOfPens()
        {
            return NumOfPens;
        }

        public override float GetMoneySpentOnPens()
        {
            return MoneySpentOnPens;
        }
        
        //pattern specific methods
        public override bool IsComposite()
        {
            return false;
        }
    }
}