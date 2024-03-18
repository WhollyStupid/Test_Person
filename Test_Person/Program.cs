public class Person
{
    string firstName;
    string lastName;
    int age;
    JobTypes? job; //Nullable
    DogBreeds? dog;

    public Person(string myfirstName, string lastName, int age, JobTypes? job, DogBreeds? dog)
    {
        this.firstName = myfirstName;
        this.lastName = lastName;
        this.age = age;
        if (this.age < 0)
            this.age = 0;
        this.job = job;
        this.dog = dog;
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
    public void ChooseNewDog(string dog)
    {
        try
        {
            this.dog = (DogBreeds)Enum.Parse(typeof(DogBreeds), dog);
        }
        catch
        {
            this.dog = null;
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
    PerryThePlatypus
}

public enum DogBreeds
{
    GoldenRetriever,
    Samoyed,
    GermanShepherd,
    Labrador,
    BelgianMalinois

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

public enum MotorcycleBrands
{
    Suzuki,
    Yamaha,
    Harley_Davidson,
    Indian,
    Honda,
    Triumph,
    Ducati,
    Yamasaki,
    Kawazaki,
    Boss_Hoss
}


