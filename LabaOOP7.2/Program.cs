namespace LabaOOP7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Device[] aeropart = GenDevice.GetAeroPark(14);
                Registr.ShowAllDevices(aeropart);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
