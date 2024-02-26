using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Assignment6
{
    ///<summary> 
    // Trucks extends the Vehicile class
    // </summary>
    internal class Truck : Vehicle
    {
        /****** fields section***/
        private double _sizeOfTruckBed;
        /****** contructors section ****/
        ///<summary>
        ///Constructor that takes 4 parameters: truckBrand, truckModel, truckNumberofWheels, and sizeoftruckBed
        ///it resuses the base class (vehicle) constructor that takes 3 parameters: brand, model, numberofwheels
        ///</summary>
        ///<param name="truckBrand"></param>
        ///<param name="truckModel"></param>
        ///<param name="truckNumberOfWheels"></param>
        ///<param name="sizeOfTruckBed"></param>
        public Truck(string truckBrand, string truckModel, int truckNumberOfWheels, double sizeOfTruckBed) : base(truckBrand, truckModel, truckNumberOfWheels)
        {
            sizeOfTruckBed = sizeOfTruckBed;
        }
        /****** propertues section ******/

        public double SizeOfTruckBed
        {
            get { return _sizeOfTruckBed; }
            set { _sizeOfTruckBed = value; }
        }

        /****** methods section ****/
        ///<summary>
        ///Overides the base Vehicles GetInfo() but adds on to it. 
        ///</summary>
        public override void GetInfo()
        {
            Console.WriteLine($"I'm a {nameof(Truck)}.");
            base.GetInfo();
            Console.WriteLine($"I also have a {SizeOfTruckBed} ft truck bed");
        }

    }
}