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
            Person person = new Person("maja", "Eichen", 21, JobTypes.Politician);

            person.AssignNewJob("Poor student");
            Assert.IsNull(person.GetJob);
        }
    }
}