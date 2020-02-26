using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoorControlProject;
using NSubstitute;
using NUnit.Framework;

namespace DoorControl.Test.Unit
{
    [TestFixture]
    public class UnitTest1
    {
        private DoorControlClass _uut;
        private IDoor _door;
        private IUserValidation _userValidation;

        [SetUp]
        public void Setup()
        {
            _door = Substitute.For<IDoor>();
            _userValidation = Substitute.For<IUserValidation>();
            _uut = new DoorControlClass(_door,_userValidation);
        }

        [Test]
        public void RequestEntrySuccessOpensDoor()
        {
            _userValidation.ValidateEntryRequest(1111).Returns(true);

            _uut.RequestEntry(1111);
            _door.Received(1).Open();
        }
    }
}