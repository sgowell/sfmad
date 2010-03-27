using NUnit.Framework;

namespace UnitTests
{
    public class base_test
    {
        [SetUp]
        public void setup()
        {
            establish_context();
            because();
        }
        public virtual void establish_context()
        {
            
        }

        public virtual void because()
        {
            
        }
    }
}