using Aircompany.Models;
using Aircompany.Planes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aircompany
{
    public class Airport
    {
        public List<Plane> planes;

        public Airport(IEnumerable<Plane> planes)
        {
            planes = planes.ToList();
        }

        public List<PassengerPlane> GetPassengersPlanes()
        {
            List<PassengerPlane> passengerplanes = new List<PassengerPlane>();
            for (int i=0; i < planes.Count; i++)
            {
                if (planes[i].GetType() == typeof(PassengerPlane))
                {
                    passengerplanes.Add((PassengerPlane)planes[i]);
                }
            }
            return passengerplanes;
        }

        public List<MilitaryPlane> GetMilitaryPlanes()
        {
            List<MilitaryPlane> militaryplanes = new List<MilitaryPlane>();
            for (int i = 0; i < planes.Count; i++)
            {
                if (planes[i].GetType() == typeof(MilitaryPlane))
                {
                    militaryplanes.Add((MilitaryPlane)planes[i]);
                }
            }
            return militaryplanes;
        }

        public PassengerPlane GetPassengerPlaneWithMaxPassengersCapacity()
        {
            List<PassengerPlane> passengerplanes = GetPassengersPlanes();
            return passengerplanes.Aggregate((w, x) => w.GetPassengersCapacity() > x.GetPassengersCapacity() ? w : x);             
        }

        public List<MilitaryPlane> GetTransportMilitaryPlanes()
        {
            List<MilitaryPlane> transportMilitaryplanes = new List<MilitaryPlane>();
            List<MilitaryPlane> militaryplanes = GetMilitaryPlanes();
            for (int i = 0; i < militaryplanes.Count; i++)
            {
                MilitaryPlane plane = militaryplanes[i];
                if (plane.GetPlaneType() == MilitaryType.TRANSPORT)
                {
                    transportMilitaryplanes.Add(plane);
                }
            }

            return transportMilitaryplanes;
        }

        public Airport SortByMaxDistance()
        {
            return new Airport(planes.OrderBy(w => w.GetMaxFlightDistance()));
        }

        public Airport SortByMaxSpeed()
        {
            return new Airport(planes.OrderBy(w => w.GetMS()));
        }

        public Airport SortByMaxLoadCapacity()
        {
            return new Airport(planes.OrderBy(w => w.GetMaxLoadCapacity()));
        }


        public IEnumerable<Plane> GetPlanes()
        {
            return planes;
        }

        public override string ToString()
        {
            return "Airport{" +"planes=" + string.Join(", ", planes.Select(x => x.GetModel())) +'}';
        }
    }
}
