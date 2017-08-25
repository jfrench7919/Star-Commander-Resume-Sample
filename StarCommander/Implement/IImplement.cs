namespace StarCommander.Implement
{
    public interface IImplement
    {
        int Power { get; set; }
        int Size { get; set; }
        int Health { get; set; }
        int ShipSpeedModification { get; set; }
        int ShipPowerModification { get; set; }
        int ShipHealthModification { get; set; }
        int ShipArmorModification { get; set; }
    }
}