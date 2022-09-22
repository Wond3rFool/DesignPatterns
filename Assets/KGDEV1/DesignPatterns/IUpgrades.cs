using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Damage,
    attackSpeed,
}
public interface IUpgrades
{
    int amount { get; set; }
    ItemType type { get; set; }

    void Upgraded();
}
