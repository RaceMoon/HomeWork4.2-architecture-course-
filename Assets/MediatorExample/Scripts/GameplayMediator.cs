using System;
using UnityEngine;
using Zenject;

public class GameplayMediator : MonoBehaviour
{
    [SerializeField] private DefeatPanel _defeatPanel;
    private Level _level;

    [Inject]
    public void Construct(Level level)
    {
        _level = level;
    }

    private void OnEnable()
    {
        _level.Defeat += OnDefeat;
    }

    private void OnDisable()
    {
        _level.Defeat -= OnDefeat;
    }

    private void OnDefeat() => _defeatPanel.Show();

    public void RestartLevel()
    {
        _defeatPanel.Hide();
        _level.Restart();
    }
}
