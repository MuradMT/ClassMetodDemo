using ClassMetodDemo.Abstract;
using ClassMetodDemo.Concrete;
using ClassMetodDemo.Entities;
using ClassMetodDemo.Validation;

namespace ClassMetodDemo
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            IValidator validator = new Validator();
            IGamerManager manager = new GamerManager(validator);
            manager.Remove(new Gamer() { ID=1,Name="as",SurName="alas",TCNO="12345"});
        }
    }
}