using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;

public class GameControl : MonoBehaviour
{
    public TextMeshProUGUI Finger1DebugText;
    public TextMeshProUGUI Finger2DebugText;

    public GameObject Circle1;
    public GameObject Circle2;

    public Animator RauteAnimator;

    public Route Raute1;
    public Route Raute2;

    private PlayerInput _playerInput;
    private bool _finger1;
    private bool _finger2;


    private Vector3 _hideCirclePosition = new Vector3(-100, 0, 0);

    private void Awake()
    {
        _playerInput = new PlayerInput();
        _playerInput.Player.Finger1Pos.performed += ctx => HandleFinger1Touch(ctx.ReadValue<Vector2>());
        _playerInput.Player.Finger1Touch.canceled += ctx => HandleFinger1Release();

        _playerInput.Player.Finger2Pos.performed += ctx => HandleFinger2Touch(ctx.ReadValue<Vector2>());
        _playerInput.Player.Finger2Touch.canceled += ctx => HandleFinger2Release();
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }

    private void HandleFinger1Touch(Vector2 touchPosition)
    {
        _finger1 = true;
        if (_finger1 && _finger2)
        {
            RauteAnimator.SetTrigger("Start");
        }
        var worldPosition = new Vector3(Camera.main.ScreenToWorldPoint(touchPosition).x, Camera.main.ScreenToWorldPoint(touchPosition).y, 0);

        Circle1.transform.position = worldPosition;
        RaycastHit2D hit;
        hit = Physics2D.Raycast(new Vector2(Camera.main.ScreenToWorldPoint(touchPosition).x, Camera.main.ScreenToWorldPoint(touchPosition).y), Vector2.zero, 0);
        if (hit.transform == null)
        {
            Finger1DebugText.text = "no";
        }
        else
        {
            Finger1DebugText.text = "hit";
        }
    }

    private void HandleFinger1Release()
    {
        _finger1 = false;
        Circle1.transform.position = _hideCirclePosition;
        Finger1DebugText.text = "rel";
    }

    private void HandleFinger2Touch(Vector2 touchPosition)
    {
        _finger2 = true;
        if (_finger1 && _finger2)
        {
            RauteAnimator.SetTrigger("Start");
        }
        var worldPosition = new Vector3(Camera.main.ScreenToWorldPoint(touchPosition).x, Camera.main.ScreenToWorldPoint(touchPosition).y, 0);

        Circle2.transform.position = worldPosition;
        RaycastHit2D hit;
        hit = Physics2D.Raycast(new Vector2(Camera.main.ScreenToWorldPoint(touchPosition).x, Camera.main.ScreenToWorldPoint(touchPosition).y), Vector2.zero, 0);
        if (hit.transform == null)
        {
            Finger2DebugText.text = "no";
        }
        else
        {
            Finger2DebugText.text = "hit";
        }
    }

    private void HandleFinger2Release()
    {
        _finger2 = false;
        Circle2.transform.position = _hideCirclePosition;
        Finger2DebugText.text = "rel";
    }
}
