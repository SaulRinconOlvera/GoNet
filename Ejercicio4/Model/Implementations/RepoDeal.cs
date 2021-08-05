using System;

public class RepoDeal : InventoryBase, IInventory {
    public double Price { get; set; }
    public string Counterparty { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}