using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Character : MonoBehaviour
{
    [SerializeField] private CharacterView _characterView;
    [SerializeField] private CharacterConfig _config;
    [SerializeField] private GroundChecker _groundChecker;
    private PlayerInput _input;
    private CharacterStateMachine _stateMachine;
    private CharacterController _characterController;

    public CharacterController Controller => _characterController;
    public PlayerInput Input => _input;
    public CharacterConfig Config => _config;   
    public CharacterView View => _characterView;
    public GroundChecker GroundChecker => _groundChecker;

    private void Awake()
    {
        _characterView.Initialize();
        _characterController = GetComponent<CharacterController>();
        _input = new PlayerInput();
        _stateMachine = new CharacterStateMachine(this);
    }

    private void Update()
    {
        _stateMachine.HandleInput();

        _stateMachine.Update();
    }

    private void OnEnable() => _input.Enable();

    private void OnDisable() => _input.Disable();
}
