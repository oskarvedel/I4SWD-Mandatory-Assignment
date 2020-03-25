namespace CompositeDemo
{
    public class Team : OfficeComponent()
    {
        //get and set methods
        public override int GetNumOfPens()
        {
            return _numOfPens;
        }

        public override float GetMoneySpentOnPens()
        {
            return _moneySpentOnPens;
        }
        
        //pattern specific methods
        public override bool isComposite()
        {
            return false;
        }
    }
}