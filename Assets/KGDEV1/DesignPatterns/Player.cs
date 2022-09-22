using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    IAnItem upgraes = new Items(0);
    InputHandler inputHandler;
    ICommand command;

    // Start is called before the first frame update
    void Awake()
    {
        inputHandler = new InputHandler(new DamageCommand(), new SpeedCommand());
    }

    // Update is called once per frame
    void Update()
    {
        command = inputHandler.HandleInput();
        if (command != null) { command.Execute(upgraes); }
 
    }
}
