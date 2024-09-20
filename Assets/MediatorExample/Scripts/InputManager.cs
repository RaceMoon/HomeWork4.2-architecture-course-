using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
public class InputManager : ITickable
{
    private Level _level;

    [Inject] 
    private void Construct(Level level)
    {
        _level = level;
    }
    public void Tick()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _level.OnDefeat();
        }
    }
}
