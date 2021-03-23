using UnityEngine;
using UnityEngine.InputSystem;

public class NewPlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speedMove;
    private Vector2 _movDirection;

    public void OnMove(InputAction.CallbackContext context)
    {
        _movDirection = context.ReadValue<Vector2>();
    }

    public void OnShoot(InputAction.CallbackContext context)
    {
        Debug.Log("Piu,Piu !!!");
    }

    void Move(Vector2 direction)
    {
        float scaleMoveSpeed = _speedMove * Time.deltaTime;
        Vector3 moveDirection = new Vector3(direction.x, 0, direction.y);
        transform.position += moveDirection * scaleMoveSpeed;
    }

    // Update is called once per frame
   public void Update()
    {
        Move(_movDirection);
    }
}
