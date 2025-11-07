using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    private int speed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -Time.deltaTime * speed * 10);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.down, -Time.deltaTime * speed * 10);
        }
    }
}
