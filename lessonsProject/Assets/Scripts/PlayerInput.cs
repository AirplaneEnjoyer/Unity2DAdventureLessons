using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame

    [SerializeField] private float _speed = 5f;
    private Vector2 movement;
    void Update()
    {
        float input = Input.GetAxisRaw("Horizontal");
        movement.x = input * _speed * Time.deltaTime;
        transform.Translate(movement);
        
        if(Input.GetKeyDown(KeyCode.W))
        {
            print("Omhoog");
        }


        if (Input.GetKeyDown(KeyCode.A))
        {
            print("Links");
        }


        if (Input.GetKeyDown(KeyCode.D))
        {
            print("Rechts");
        }
    }
}
