namespace DesignPatterns.Creational.Prototype
{
    public interface IPrototype<out T>
    {
        T DeepCopy();
    }
}
