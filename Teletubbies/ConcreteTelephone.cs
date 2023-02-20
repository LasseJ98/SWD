using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teletubbies
{
	public class ConcreteTelephone : Telephone
	{
		private SubjectData state = new SubjectData();

		//public ConcreteTeletubbies()
		//{
		//	_observers = new List<ITeletubbies>();
		//}

		public void SetData(string data)
		{
			state.Subject = data;
			Notify();
		}

		public override void Notify()
		{
			foreach (var t in _observers)
			{
				t.Update(state);
			}
		}
	}
}
