using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedDecorater : ItemDecorater
{
    public SpeedDecorater(int _amount) : base(_amount){}

    public override IUpgrades Decorate(IUpgrades item)
    {
        Debug.Log("you added more attackSpeed");
        item.type |= ItemType.attackSpeed;
        item.amount += amount;
        return item;
    }
}
