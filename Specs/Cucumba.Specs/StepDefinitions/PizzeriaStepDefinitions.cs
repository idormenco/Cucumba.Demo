using Cucumba.Demo.Pizzeria;

namespace Cucumba.Specs.StepDefinitions
{
    [Binding]
    [Scope(Feature = "Pizzeria")]
    public class PizzeriaStepDefinitions
    {
        private IAmPizzaMaker _pizzaMaker;
        private Pizza _pizza;

        [Given(@"un creator de pizza")]
        public void GivenUnCreatorDePizza()
        {
            _pizzaMaker = Fac.O.Pizza;
        }

        [Given(@"pun blat pufos")]
        public void GivenPunBlatPufos()
        {
            _pizzaMaker.CuBlat(Blat.Pufos);
        }

        [Given(@"pun sos de rosii")]
        public void GivenPunSosDeRosii()
        {
            _pizzaMaker.PunSosDeRosii();
        }

        [Given(@"pun ananas")]
        public void GivenPunAnanas()
        {
            _pizzaMaker.Pun(Topping.Ananas);
        }

        [Given(@"pun peperoni")]
        public void GivenPunPeperoni()
        {
            _pizzaMaker.Pun(Topping.Pepperoni);
        }

        [Given(@"pun ceapa")]
        public void GivenPunCeapa()
        {
            _pizzaMaker.Pun(Topping.Ceapa);
        }

        [When(@"o bag la cuptor")]
        public void WhenOBagLaCuptor()
        {
            _pizza = _pizzaMaker.BagLaCuptor();
        }

        [Then(@"obtin o pizza")]
        public void ThenObtinOPizza()
        {
            _pizza.Ingredients.Should().HaveCount(5);
            _pizza.Ingredients.Should().BeEquivalentTo("Ceapa", "Pepperoni", "Ananas", "Sos rossi", "Blat Pufos");
        }
    }
}
