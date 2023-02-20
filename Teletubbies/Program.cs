namespace Teletubbies
{
	internal class Program
	{
		static void Main(string[] args)
		{
		
			ConcreteTelephone Phone = new ConcreteTelephone();

			ConcreteTeletubbies teletubbie1 = new ConcreteTeletubbies(Phone);
			ConcreteTeletubbies teletubbie2 = new ConcreteTeletubbies(Phone);
			ConcreteTeletubbies teletubbie3 = new ConcreteTeletubbies(Phone);


			Phone.SetData("TV");
			Console.WriteLine("-----------------");
			Phone.SetData("Dinner");
			Console.WriteLine("-----------------");
			Phone.SetData("SES!");
			Console.WriteLine("-----------------");

		}
	}
}