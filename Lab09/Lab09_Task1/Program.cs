namespace Lab09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car dummy = new Car();
            dummy.seats.setSeatComfortability("Comfy");
            dummy.engine.setEnergyProduction(200);
            dummy.doors.setDoorOpeningMode("sideways");
            Console.WriteLine(dummy.DisplayInfo());
        }
    }
}