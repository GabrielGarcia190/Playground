namespace ExemplosSOLID.Interface_Segregation_ISP;

public class SmartPlug : IEnergyMonitor
{
    public double GetPowerConsumption() => 2.5;
}