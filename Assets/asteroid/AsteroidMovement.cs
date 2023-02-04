using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(Random.Range(-3, 3), Random.Range(-3, 3), Random.Range(-3, 3));
        rb.angularVelocity = Random.onUnitSphere * Random.Range(-100, 100);
    }

    void OnBecameInvisible()
    {
        Vector3 position = transform.position;
        if (position.x > Camera.main.orthographicSize || position.x < -Camera.main.orthographicSize)
        {
            position.x = -position.x;
        }
        if (position.y > Camera.main.orthographicSize || position.y < -Camera.main.orthographicSize)
        {
            position.y = -position.y;
        }
        if (position.z > Camera.main.orthographicSize || position.z < -Camera.main.orthographicSize)
        {
            position.z = -position.z;
        }
        transform.position = position;
    }
}
