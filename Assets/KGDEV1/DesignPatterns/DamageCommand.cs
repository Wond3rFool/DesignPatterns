using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCommand : ICommand
{
    public void Execute(IUpgrades item)
    {
        DamageDecorater damageDecorater = new DamageDecorater(1);
        item = damageDecorater.Decorate(item);
        item.Upgraded();
    }
}
