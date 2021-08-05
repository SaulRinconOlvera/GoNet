using System;

public interface IInventory {
    string DealName {get;}
    Guid LocalId {get;}
    string Titles {get;}
    int AvailableSince {get;}
}