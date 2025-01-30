using UnityEngine;
using UnityEngine.InputSystem;

public class RollaBall_Player : MonoBehaviour
{
    Vector2 m; // allows us to call m in multiple placs
    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m = new Vector2(0,0);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x_dir = m.x;
        float z_dir = m.y; 
        Vector3 actual_movement = new Vector3(x_dir,0,z_dir);
        print(actual_movement);

        rb.AddForce(actual_movement);
    }


    void OnMove(InputValue movement)
    {
        m = movement.Get<Vector2>();
    }
}
