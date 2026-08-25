using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_oop5
{
    public class DeliveryCenter
    {
        public string CenterName { get; set; }

        public Driver Driver { get; set; }

        private Shipment[] shipments = new Shipment[20];

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                {
                    return shipments[index];
                }

                return null;
            }
            set
            {
                if (index >= 0 && index < shipments.Length)
                {
                    shipments[index] = value;
                }
            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i] != null &&
                        shipments[i].TrackingCode == trackingCode)
                    {
                        return shipments[i];
                    }
                }

                return null;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }

            return false;
        }

        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null &&
                    shipments[i].TrackingCode == trackingCode)
                {
                    shipments[i] = null;
                    return true;
                }
            }

            return false;
        }

        public void PrintAllShipments()
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null)
                {
                    shipments[i].PrintShipment();
                    Console.WriteLine();
                }
            }
        }


        public void PrintTrackingStatuses()
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null)
                {
                    ITrackable trackable = shipments[i] as ITrackable;

                    if (trackable != null)
                    {
                        Console.WriteLine(trackable.GetTrackingStatus());
                        Console.WriteLine();
                    }
                }
            }
        }
    }


}
