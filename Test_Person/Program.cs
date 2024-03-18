public class Person
{
    string firstName;
    string lastName;
    int age;
    JobTypes? job; //Nullable

    public Person(string myfirstName, string lastName, int age, JobTypes? job)
    {
        this.firstName = myfirstName;
        this.lastName = lastName;
        this.age = age;
        if (this.age < 0)
            this.age = 0;
        this.job = job;
    }

    public void AssignNewJob(string job)
    {
        try
        {
            this.job = (JobTypes)Enum.Parse(typeof(JobTypes), job);
        }
        catch (ArgumentException)
        {
            this.job = null;
        }
    }

    public string GetFullName()
    {
        return firstName + " " + lastName + " " + firstName; // ekstra first name added
    }

    public int GetAge()
    {
        return age;
    }

    public JobTypes? GetJob()
    {
        return job;
    }

    public void HappyBirthday()
    {
        age += 1;
    }
}

public enum JobTypes // he aint got no job no more
{
    Teacher,
    Fireman,
    Policeman,
    Politician,
    Comedian,
    Mechanic,
    Programmer,
    Archelogist,
    Fuckboy,
    SecretAgent,
}

public enum DogBreeds
{
    GoldenRetriever,
    Samoyed,
    GermanShepherd,
    Labrador,
    Belgianmalinois

}


public class dog
{
    public int age;
    public bool cute;
    public string breed;
}

public class Motorcycle
{
    public string name;
    public int manufactureDate;
    public string tankSize;
}

