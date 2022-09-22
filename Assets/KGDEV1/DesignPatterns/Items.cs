using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : IUpgrades
{
    public int amount { get ; set; }
    public ItemType type { get; set ; }
    public Items(int _amount)
    {
        amount = _amount;
    }
    public void Upgraded()
    {
        Debug.Log("you have this many upgrades: " + amount);
    }
}
