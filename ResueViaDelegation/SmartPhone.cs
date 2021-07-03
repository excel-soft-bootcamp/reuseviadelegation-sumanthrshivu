using System;
using System.Collections.Generic;
using System.Text;

namespace ResueViaDelegation
{
    public class SmartPhone : ICamera, IGPS, IPhone
    {
        ICamera _cameraRef;
        IGPS _gpsRef;
        IPhone _phoneRef;

        public void SetSmartPhone(ICamera cameraRef, IGPS gpsRef, IPhone phoneRef)
        {
            this._cameraRef = cameraRef;
            this._gpsRef = gpsRef;
            this._phoneRef = phoneRef;
        }
        public void Click()
        {
            this._cameraRef.Click();
        }
        public void TakePicture()
        {

        }
        public void Hangup()
        {
            this._phoneRef.Hangup();
        }
        public void Release()
        {
            this._phoneRef.Release();
        }
        public void Navigate()
        {
            this._gpsRef.Navigate();
        }
    }
}
