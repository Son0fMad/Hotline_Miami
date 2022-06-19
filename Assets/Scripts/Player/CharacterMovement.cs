using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
   //Переменные перемещения персонажа 
    Rigidbody2D rb;
    public float speed;

    float x, y;
    public bool canMove = true;
    
    //Переменные поворота персонажа
    Vector3 mousePosition; 
    Vector3 direct;

	Camera cam;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cam = Camera.main;
    }
    void Update()
    {
        InputManager();
    }

    private void FixedUpdate()
    {
        if (canMove)
        {
            MovementManager();
        }
        RotationCharacter();
    }

    void InputManager()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
    }

    void MovementManager()
    {
        rb.velocity = new Vector2(x * speed, y * speed);
    }

    void RotationCharacter()
    {
        mousePosition = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,
            Input.mousePosition.z - cam.transform.position.z));
        rb.transform.eulerAngles = new Vector3(0, 0, Mathf.Atan2((mousePosition.y - transform.position.y), (mousePosition.x - transform.position.x)) * Mathf.Rad2Deg);
    }
}
