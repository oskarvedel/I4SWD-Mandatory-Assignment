using System;

namespace CompositeDemo
{
    public abstract class CompanyPart
    {
        //private variables
        protected string ComponentName;
        protected int NumOfPens;
        protected float MoneySpentOnPens;
        
        //constructor
        protected CompanyPart(string componentName, int numOfPens, float moneySpentOnPens)
        {
            ComponentName = componentName;
            NumOfPens = numOfPens;
            MoneySpentOnPens = moneySpentOnPens;
        }
        
        //get and set methods

        public string GetComponentName()
        {
            return ComponentName;
        }
        
        public void AddPens(int numOfPensToAdd)
        {
            NumOfPens += numOfPensToAdd;
        }

       public void AddMoneySpentOnPens(float moneySpentOnPensToAdd)
        {
            MoneySpentOnPens += moneySpentOnPensToAdd;
        }

        public abstract int GetNumOfPens();
        public abstract float GetMoneySpentOnPens();
        
        //pattern specific methods
        public virtual void AddChild(CompanyPart officeComponent)
        {
            throw new NotImplementedException();
        }

        public virtual void RemoveChild(CompanyPart officeComponent)
        {
            throw new NotImplementedException();
        }

        public virtual bool IsComposite()
        {
            return true;
        }
    }
}