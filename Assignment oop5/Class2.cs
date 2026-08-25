using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_oop5
{
    public class DeliveryReport
    {
        public void PrintShipment(ITrackable shipment)
        {
            Console.WriteLine(shipment.GetTrackingStatus());
        }

        public void PrintInsurance(IInsurable shipment)
        {
            Console.WriteLine($"Insurance Cost: {shipment.CalculateInsurance():F2} EGP");
        }
    }

}
