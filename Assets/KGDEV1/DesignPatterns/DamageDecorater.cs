using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDecorater : ItemDecorater
{
    public DamageDecorater(int _amount) : base(_amount) { }

    public override IAnItem Decorate(IAnItem item)
    {
        Debug.Log("you added more Damage");
        item.type |= ItemType.Damage;
        item.amount += amount;
        return item;
    }
}
