using RestWithASPNETUdemy_Calculator.Model;

namespace RestWithASPNETUdemy_Calculator.Services.Implementations;

public class PersonServiceImplementation: IPersonService
{
    private volatile int count;

    public Person Create(Person person)
    {
        return person;
    }

    public void Delete(long id)
    {
        
    }

    public List<Person> FindAll()
    {
        List<Person> persons = [];
        for (int i = 0; i < 8; i++)
        {
            Person person = MockPerson(i);
            persons.Add(person);
        }
        return persons;
    }



    public Person FindById(long id)
    {
        return new Person
        {
            Id = IncrementAndGet( ),
            FirstName = "Miguel",
            LastName = "Brito",
            Adress = "Queimados - RJ - Brasil",
            Gender = "Male"
        };
    }

    public Person Update(Person person)
    {
        return person;
    }
    private Person MockPerson(int i)
    {
        return new Person
        {
            Id = IncrementAndGet(),
            FirstName = "Person Name" + i,
            LastName = "Person Last Name" + i,
            Adress = "Person Adress" + i,
            Gender = "Person Gender"
        };
    }

    private long IncrementAndGet()
    {
        return Interlocked.Increment(ref count);
    }
}
