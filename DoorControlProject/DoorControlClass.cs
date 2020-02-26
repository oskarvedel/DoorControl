namespace DoorControlProject
{
    public class DoorControlClass
    {
        private IDoor _door;
        private IUserValidation _userValidation;

        public DoorControlClass(IDoor door, IUserValidation userValidation)
        {
            _door = door;
            _userValidation = userValidation;
        }

        public void RequestEntry(int id)
        {
            if (_userValidation.ValidateEntryRequest(id) == true)
            {
                _door.Open();
            }
        }

        private void DoorOpen()
        {
            _door.Close();
        }

        public void DoorClosed()
        {
        }
        
    }
}