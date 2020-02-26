namespace DoorControlProject
{
    public class DoorControlClass
    {
        private IDoor _door;
        private IUserValidation _userValidation;
        private IEntryNotification _entryNotification;

        public DoorControlClass(IDoor door, IUserValidation userValidation, IEntryNotification entryNotification)
        {
            _door = door;
            _userValidation = userValidation;
            _entryNotification = entryNotification;
        }

        public void RequestEntry(int id)
        {
            if (_userValidation.ValidateEntryRequest(id))
            {
                _door.Open();
                _entryNotification.NotifyEntryGranted();
            }
        }

        public void DoorOpen()
        {
            _door.Close();
        }

        public void DoorClosed()
        {
        }
        
    }
}