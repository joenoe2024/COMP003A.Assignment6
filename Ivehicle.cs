using System;

public class Class1
{
    ///<summary>
    ///Interfaces are contracts that the inheriting class has to implement.
    ///Read https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/abstractions-abstract-types-and-interfaces
    ///</summary>
    iternal interface IVehicle
    {
        ///<summary>
        ///this method is required to be implemendted in the inheriting class
        ///</summary>
        public void GetInfo();
    }
}
