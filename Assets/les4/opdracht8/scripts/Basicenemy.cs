using UnityEngine;

public class Basicenemy : MonoBehaviour
{
    protected int health = 100;
    protected int speed = 3;
    // Update is called once per frame
    void Update()
    {
        move();
    }
    protected void move()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected with " + collision.gameObject.name);
        if (collision.gameObject.CompareTag("Bullet"))
        {
            health -= 50;
            Destroy(collision.gameObject);
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger detected with " + other.gameObject.name);
        if (other.gameObject.CompareTag("Bullet"))
        {
            health -= 50;
            Destroy(other.gameObject);
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
