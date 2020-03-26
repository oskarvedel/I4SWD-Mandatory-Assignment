using System;
using System.Collections.Generic;

namespace CompositeDemo
{
    class Company : CompanyPart
    {
        //private variables
        List<CompanyPart> _children = new List<CompanyPart>();
        
        //constructor
        public Company(string componentName, int numOfPens, float moneySpentOnPens) : base(componentName,numOfPens,moneySpentOnPens)
        {
            ComponentName = componentName;
            NumOfPens = numOfPens;
            MoneySpentOnPens = moneySpentOnPens;
        }
        //get and set methods
        public override int GetNumOfPens()
        {
            int total = NumOfPens;

            foreach (CompanyPart component in this._children)
            {
                total += component.GetNumOfPens();
            }
            return total;
        }

        public override float GetMoneySpentOnPens()
        {
            float total = MoneySpentOnPens;

            foreach (CompanyPart component in this._children)
            {
                total += component.GetMoneySpentOnPens();
            }
            return total;
        }
        

        public override void AddChild(CompanyPart CompanyPart)
        {
            this._children.Add(CompanyPart);
        }

        public override void RemoveChild(CompanyPart CompanyPart)
        {
            this._children.Remove(CompanyPart);
        }
    }
}