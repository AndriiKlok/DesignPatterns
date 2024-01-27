using System;

namespace Patterns.Prototype
{
	class Person
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public AdditionalInfo AdditionalInfo { get; set; }

		public Person ShallCopy()
		{
			return (Person)this.MemberwiseClone();
		}
		public Person DeepCopy()
		{
			Person clone = (Person)this.MemberwiseClone();

			clone.Name = String.Copy(this.Name);
			clone.AdditionalInfo = new AdditionalInfo()
			{
				FavoriteNumber = this.AdditionalInfo.FavoriteNumber,
			};

			return clone;
		}
	}

	class AdditionalInfo
	{
		public int FavoriteNumber { get; set; }
	}
}
