using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoorControl;
using NSubstitute;
using NUnit.Framework;

namespace DoorControlTestClass
{
    [TestFixture]
    public class UnitTest1
    {
        private DoorControl _uut;
        private IDoor door_;
        private IUserValidation _userValidation;

        [SetUp]
        public void Setup()
        {
            door_ = Substitute.For<IDoor>();
            _userValidation = Substitute.For<IUserValidation>();
            _uut = new DoorControl(door_,_userValidation);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}