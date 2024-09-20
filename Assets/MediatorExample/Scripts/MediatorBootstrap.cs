using UnityEngine;
using Zenject;

public class MediatorBootstrap : MonoBehaviour
{
    private Level _level;

    [Inject] 
    private void Construct(Level level)
    {
        _level = level;
    }

    private void Awake()
    {
        _level.Start();
    }
}
