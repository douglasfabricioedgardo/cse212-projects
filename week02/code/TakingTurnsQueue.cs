public class TakingTurnsQueue
{
    private readonly PersonQueue _people = new();

    public int Length => _people.Length;

    public void AddPerson(string name, int turns)
    {
        _people.Enqueue(new Person(name, turns));
    }

    public Person GetNextPerson()
    {
        if (_people.IsEmpty())
            throw new InvalidOperationException("No one in the queue.");

        Person person = _people.Dequeue();

        if (person.Turns <= 0)
        {
            _people.Enqueue(person); // Infinite turns
        }
        else if (person.Turns > 1)
        {
            person.Turns--; // Decrease turn
            _people.Enqueue(person);
        }
        // If person had exactly 1 turn, don't re-add

        return person;
    }

    public override string ToString()
    {
        return _people.ToString();
    }
}
