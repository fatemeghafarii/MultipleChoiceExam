namespace MultipleChoiceTest.Model.Models;
public abstract class Entity<TKey>
{
    public TKey? Id { get; protected set; }
}

