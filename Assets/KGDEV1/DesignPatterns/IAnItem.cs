using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Damage,
    attackSpeed,
}
public interface IAnItem
{
    int amount { get; set; }
    ItemType type { get; set; }

    void Upgraded();
}
