using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler
{
    private ICommand qButtonPressed;
    private ICommand rButtonPressed;

    public InputHandler(ICommand _qButtonPressed, ICommand _rButtonPressed) 
    {
        qButtonPressed = _qButtonPressed;
        rButtonPressed = _rButtonPressed;   
    }

    public ICommand HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.Q)){ return qButtonPressed; }
        if (Input.GetKeyDown(KeyCode.R)){ return rButtonPressed; }
        return null;
    }
}
