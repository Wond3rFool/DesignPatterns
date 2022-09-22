using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemDecorater
{
    public int amount { get; set; }
    public ItemDecorater(int _amount) 
    {
        amount = _amount;
    }

    public abstract IUpgrades Decorate(IUpgrades item);
}
