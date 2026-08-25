using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_oop5
{
    public abstract partial class Shipment
    {
        private string trackingStatus = "In Transit";

        public virtual string GetTrackingStatus()
        {
            return trackingStatus;
        }

        public void UpdateTrackingStatus(string newStatus)
        {
            trackingStatus = newStatus;
            OnTrackingStatusChanged(newStatus);
        }

        partial void OnTrackingStatusChanged(string newStatus);
    }
}
