using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teletubbies
{
	public abstract class Telephone
	{
		protected List<ITeletubbies> _observers = new List<ITeletubbies>();

		public Telephone()
		{
			
		}

		public void Attach(ITeletubbies tubbies)
		{
			_observers.Add(tubbies);
		}

		public void Detach(ITeletubbies tubbies)
		{
			_observers.Remove(tubbies);
		}

		public virtual void Notify(){}


	}
}
