using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    Application.targetFrameRate = 120;
    }

    // Update is called once per frame
    void Update()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float zAxis = Input.GetAxis("Vertical");

        Vector3 Movement = new Vector3(xAxis, 0, zAxis);
        Vector3 trueMovement = Vector3.ClampMagnitude(Movement, 1);

        transform.Translate(trueMovement * speed * Time.deltaTime);
        Debug.Log(trueMovement.magnitude);
    }
}
