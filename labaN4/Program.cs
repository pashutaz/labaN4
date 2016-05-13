using System;

namespace labaN4
{
  internal class MainClass
  {
    private interface IHuman
    {
      string GetName();
      string GetBirthday();
      string GetAddress();
      string GetJob();
    }

    private class Human : IHuman
    {


      private string _name;
      private string _birthday;
      private string _address;
      private string _job;



      public void SetHuman(string inputName, string inputBirthday, string inputAddress, string inputJob)
            {
              _name = inputName;
              _birthday = inputBirthday;
              _address = inputAddress;
              _job = inputJob;
            }

      public string GetName() => _name;

      public string GetBirthday() => _birthday;

      public string GetAddress() => _address;

      public string GetJob() => _job;
    }


    public static void Main(string[] args)
    {
      var person1 = new Human();
      person1.SetHuman("pavel", "10/04/95", "moscow", "engineer");

      Console.WriteLine(person1.GetName());
    }
  }
}
