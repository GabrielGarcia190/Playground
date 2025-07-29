namespace ExemplosSOLID.Interface_Segregation_ISP;

public class IndustrialMachine : ITemperatureSensor, IEnergyMonitor
{
    public double ReadTemperature() => 65.2;
    public double GetPowerConsumption() => 1500;
}