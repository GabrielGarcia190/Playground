namespace ExemplosSOLID.Interface_Segregation_ISP;

public class Thermostat : ITemperatureSensor
{
    public double ReadTemperature() => 25.5;
}