using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
[SerializeField]
private float _moveSpeed;

private PlayerInput _playerInput;

private void Awake()
{
    _playerInput = new PlayerInput();
    _playerInput.Player.Shoot.performed += context => Shoot();
}

private void OnEnable()
{
    _playerInput.Enable();
    
}

private void OnDisable()
{
    _playerInput.Disable();
}

// Update is called once per frame
    void Update()
    {
        Vector2 moveDirection = _playerInput.Player.Move.ReadValue<Vector2>();
        Move(moveDirection);
        /* float horizontalDirection = Input.GetAxis("Horizontal");
         float verticalDirection = Input.GetAxis("Vertical");
         
         Vector2 direction = new Vector2(horizontalDirection, verticalDirection);
         Move(direction);
         if (Input.GetMouseButtonDown(0))
         {
          Shoot();   
         }*/

    }

    void Move(Vector2 direction)
    {
        float scaleMoveSpeed = _moveSpeed * Time.deltaTime;
        Vector3 moveDirection = new Vector3(direction.x, 0, direction.y);
        transform.position += moveDirection * scaleMoveSpeed;
    }

    private void Shoot()
    {
        Debug.Log("Piu,Piu !!!");
    }
}
