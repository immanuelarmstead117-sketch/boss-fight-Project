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
        float xAxis = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float zAxis = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(xAxis, 0, zAxis);
    }
}
