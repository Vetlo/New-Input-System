using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
[SerializeField]
private float _moveSpeed;



    // Update is called once per frame
    void Update()
    {
        float horizontalDirection = Input.GetAxis("Horizontal");
        float verticalDirection = Input.GetAxis("Vertical");
        
        Vector2 direction = new Vector2(horizontalDirection, verticalDirection);
        Move(direction);
        if (Input.GetMouseButtonDown(0))
        {
         Shoot();   
        }

    }

    void Move(Vector2 direction)
    {
        float scaleMoveSpeed = _moveSpeed * Time.deltaTime;
        Vector3 moveDirection = new Vector3(direction.x, 0, direction.y);
        transform.position += moveDirection * scaleMoveSpeed;
    }

    private void Shoot()
    {
        Debug.Log("");
    }
}
