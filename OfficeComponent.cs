using System;

namespace CompositeDemo
{
    public abstract class OfficeComponent
    {
        //private variables
        protected int _numOfPens;
        protected float _moneySpentOnPens;
        
        //constructor
        protected OfficeComponent(int numOfPens, float moneySpentOnPens)
        {
            _numOfPens = numOfPens;
            _moneySpentOnPens = moneySpentOnPens;
        }
        
        //get and set methods
        public void AddPens(int numOfPensToAdd)
        {
            _numOfPens += numOfPensToAdd;
        }

       public void AddMoneySpentOnPens(float moneySpentOnPensToAdd)
        {
            _moneySpentOnPens += moneySpentOnPensToAdd;
        }

        public abstract int GetNumOfPens();
        public abstract float GetMoneySpentOnPens();
        
        //pattern specific methods
        public virtual void addChild(OfficeComponent officeComponent)
        {
            throw new NotImplementedException();
        }

        public virtual void removeChild(OfficeComponent officeComponent)
        {
            throw new NotImplementedException();
        }

        public virtual bool isComposite()
        {
            return true;
        }
    }
}