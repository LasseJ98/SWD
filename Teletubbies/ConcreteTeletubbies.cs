using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teletubbies
{
	public class ConcreteTeletubbies : ITeletubbies
	{
		public ConcreteTeletubbies(Telephone subject)
		{
			subject.Attach(this);
		}

		public void Update(SubjectData state)
		{
			Console.WriteLine($"Den nye state er: {state.Subject}");
		}
	}
}
