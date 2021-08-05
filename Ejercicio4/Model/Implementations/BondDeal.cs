using System;

public class BondDeal : InventoryBase, IInventory {
    public double Precio { get; set; }
    public string Titulos { 
        get { return Titles;} 
        set { Titles = value;} 
    }
    public string Contraparte { get; set; }
    public DateTime SettlementDate { get; set; }
}