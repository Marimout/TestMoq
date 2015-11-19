using System;
using NUnit.Framework;
using Moq;
using Moq.Protected;

namespace TestMoq
{
    [TestFixture]
    public class TestOneClass
    {
        [Test]
        public void should_call_protected_method()
        {
            var mock = new Mock<OneClass>();

            mock.Protected().Setup("OneProtectedMethod").Callback(() => Console.WriteLine("Goodbye"));

            var o = new OneClass();

            o.DoMethod();

            mock.Protected().Verify("OneProtectedMethod", Times.Once());
        }
    }
}
