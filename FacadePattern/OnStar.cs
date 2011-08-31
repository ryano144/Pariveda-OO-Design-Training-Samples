using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacadePattern.Client;

namespace FacadePattern
{
    public class OnStar: IOnStar
    {
        private List<IDoorLock> _doorLocks;
        private IGPSSensor _gpsSensor;

        private IOnStarService _onStarService;

        public void LockDoors()
        {
            foreach (IDoorLock doorLock in _doorLocks)
            {
                doorLock.Lock();
            }
        }

        public void GetGpsLocation()
        {
            if (!_gpsSensor.HasLock)
            {
                _gpsSensor.AcquireSatalites(this);
            }
            float lat = _gpsSensor.Latitude;
            float lon = _gpsSensor.Longitude;
            GPSAccuracyEnum accuracy = _gpsSensor.Accuracy;
            SendGpsLocation(lat, lon, accuracy);
        }

        private void SendGpsLocation(float lat, float lon, GPSAccuracyEnum accuracy) 
        {
            _onStarService.SetGpsLocation(lat, lon, accuracy);
        }

        public void OnGpsLockAcquired(float lat, float lon, GPSAccuracyEnum accuracy)
        {
            SendGpsLocation(lat, lon, accuracy);
        }
    }
}
