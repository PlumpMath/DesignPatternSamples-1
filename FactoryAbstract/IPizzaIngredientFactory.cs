namespace FactoryAbstract
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ISauce CreateSauce();
    }
}