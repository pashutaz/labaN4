using System;

namespace labaN4
{
  internal interface IHuman
  {
    string ShowInfo();
  }

  internal class Human : IHuman
  {
    private string[] _properties;

    public string this[int index]
    {
      set
      {
        Array.Resize(ref _properties,index+1);
        _properties[index] = value;
      }

      get { return _properties[index]; }
    }

    public string Name { get; set; }

    public string Job { get; set; }

    public string Address { get; set; }

    public string Birthday { get; set; }

    public Human(string name = "", string job = "", string address = "", string birthday = "")
    {
      _properties = new string[] {};
      Name = name;
      Job = job;
      Address = address;
      Birthday = birthday;
    }

    public string ShowInfo()
    {
      return Name + ":\n " + Address + "\n " + Job + "\n " + Birthday + "\n ";
    }
  }

  internal class MainClass
  {
    public static void Main(string[] args)
    {
      var person1 = new Human
      {
        Name = "Pavel",
        Job = "Engineer",
        Address = "Moscow",
        Birthday = "27/06/95",
        [5] = "Hello",
        [7] = "user",
      };
      Console.WriteLine(person1.ShowInfo());
      Console.WriteLine(person1[5]+", "+person1[7]);
    }
  }
}
//DONE