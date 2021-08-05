using System;
using System.ComponentModel.DataAnnotations;

public abstract class InventoryBase : IInventory
{
    [Key]
    public string DealName  {get;set;}

    [Required]
    public Guid LocalId  {get;set;}

    [Required]
    public string Titles  {get;set;}

    [Required]
    public int AvailableSince {get;set;}
}