namespace Patterns.Decorator
{
	abstract class BasePizza
	{
		protected double price;

		public virtual double GetPrice()
		{
			return price;
		}
	}

	abstract class ToppingsDecorator : BasePizza
	{
		protected BasePizza pizza;
        public ToppingsDecorator(BasePizza pizzaToDecorate)
        {
			pizza = pizzaToDecorate;
        }

		public override double GetPrice()
		{
			return pizza.GetPrice() + price;
		}
    }

	class Margherita : BasePizza
	{
		public Margherita()
		{
			price = 5;
		}
	}

	class Gourmet : BasePizza
	{
		public Gourmet()
		{
			price = 7;
		}
	}

	class ExtraCheeseTopping : ToppingsDecorator
	{
        public ExtraCheeseTopping(BasePizza pizzaToDecorate)
			:base(pizzaToDecorate)
		{
			price = 1;
		}
	}

	class MushroomTopping : ToppingsDecorator
	{
		public MushroomTopping(BasePizza pizzaToDecorate)
			: base(pizzaToDecorate)
		{
			price = 1.5;
		}
	}

	class JalapenoTopping : ToppingsDecorator
	{
		public JalapenoTopping(BasePizza pizzaToDecorate)
			: base(pizzaToDecorate)
		{
			price = 2;
		}
	}
}
