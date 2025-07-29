namespace ExemplosSOLID.Interface_Segregation_ISP
{
    public static class ExemploDeUso
    {
        public static void Executar()
        {
            ITemperatureSensor thermostat = new Thermostat();
            IEnergyMonitor smartPlug = new SmartPlug();
            ITemperatureSensor industrialMachine = new IndustrialMachine();
            IEnergyMonitor industrialEnergyMonitor = (IEnergyMonitor)industrialMachine;

            Console.WriteLine($"Temperatura do termostato: {thermostat.ReadTemperature()} °C");
            Console.WriteLine($"Temperatura da máquina industrial: {industrialMachine.ReadTemperature()} °C");

            Console.WriteLine($"Consumo de energia do smart plug: {smartPlug.GetPowerConsumption()} W");
            Console.WriteLine($"Consumo de energia da máquina industrial: {industrialEnergyMonitor.GetPowerConsumption()} W");
        }
    }
}