using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedCommand : ICommand
{
    public void Execute(IAnItem item)
    {
        SpeedDecorater speedDecorater = new SpeedDecorater(1);
        item = speedDecorater.Decorate(item);
        item.Upgraded();
    }
}
