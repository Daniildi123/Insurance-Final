namespace Insurance_VARIANT_2
{
    public class Damage
    {
        private readonly string partName;
        private readonly decimal partCost;

        public Damage(string partName, decimal partCost)
        {
            this.partName = partName;
            this.partCost = partCost;
        }

        public decimal Cost { get => partCost; set => _ = partCost; }
        public string PartName { get => partName; set => _ = partName; }
    }
}