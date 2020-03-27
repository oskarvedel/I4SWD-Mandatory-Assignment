using System;

namespace CompositeDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Client client = new Client();
            Team team1 = new Team("redTeam", 754, 100); 
            Team team2 = new Team("blueTeam", 643, 203); 
            Team team3 = new Team("greenTeam", 532, 156);
           Team team4 = new Team("orangeTeam", 235, 200);
           Department department1 = new Department("Department of Food", 914,2531);
           Department department2 = new Department("Department of Electricity", 843, 3453);
           Office office1 = new Office("Alabama Office", 473,1384);
           Office office2 = new Office("Washington Office", 203, 905);
           Company company1 = new Company("myCompany",0,0);

           department1.AddChild(team1);
           department1.AddChild(team2);
           department2.AddChild(team3);
           department2.AddChild(team4);
           
           office1.AddChild(department1);
           office2.AddChild(department2);
           
           company1.AddChild(office1);
           company1.AddChild(office2);

           Console.WriteLine(client.GetMoneySpentOnPens(team1));
           Console.WriteLine(client.GetMoneySpentOnPens(office1));
           Console.WriteLine(client.GetMoneySpentOnPens(company1));
           
           
        }
    }
}