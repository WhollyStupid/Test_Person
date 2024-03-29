namespace Nunit_1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            JobTypes job = new JobTypes();
            Person person = new Person("maja", 
                "Eichen", 21, JobTypes.Politician, DogBreeds.Labrador);

            person.AssignNewJob("Poor student");
            Assert.IsNull(person.GetJob);
        }

        [Test]
        public void BirthdayNotification()
        {
            Person person = new Person("Sterling", 
                "Archer", 34, JobTypes.Comedian, DogBreeds.GoldenRetriever);
            person.AssignNewJob("Secret Agent");
            Assert.IsTrue(person.GetJob != null);

        }
    }
}