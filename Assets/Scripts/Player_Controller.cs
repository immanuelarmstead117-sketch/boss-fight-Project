using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public Rigidbody rb;
    float speed = 5f;
    Vector3 Direction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    Application.targetFrameRate = 120;
    }

    // Update is called once per frame
    void Update()
    {
      Direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }

    void FixedUpdate()
    {
      Vector3 trueMovement = Vector3.ClampMagnitude(Direction, 1);

      rb.linearVelocity = new Vector3(trueMovement.x * speed, rb.linearVelocity.y, trueMovement.z * speed);
     
    }
}
