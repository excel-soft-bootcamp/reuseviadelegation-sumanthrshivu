using System;

namespace ResueViaDelegation
{
    public class Program
    {

        public static void Main()
        {
            Camera _camera = new Camera();
            GPS _gps = new GPS();
            Phone _phone = new Phone();
            SmartPhone _smartPhone = new SmartPhone();//Smartphone Should Deleagte Calls to  Camera, Gps,Phone
            _smartPhone.SetSmartPhone(_camera, _gps, _phone);
            _smartPhone.TakePicture();
            _smartPhone.Hangup();
            _smartPhone.Release();
            _smartPhone.Navigate();

            //Substitute Camera with SmartPhone , GPS with SmartPhone , Phone With SamrtPhone

            PhotoGrapher _photoGrapher = new PhotoGrapher();
            _photoGrapher.Capture(_camera);
            _photoGrapher.Capture(_smartPhone);

            Traveller _traveller = new Traveller();
            _traveller.Hike(_gps);
            _traveller.Hike(_smartPhone);

            Person _person = new Person();
            _person.Communicate(_phone);
            _person.Communicate(_smartPhone);
        }
    }
}
