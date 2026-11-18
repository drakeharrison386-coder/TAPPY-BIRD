
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    public float speed = 3f;

    void Update()
    {
        if (Time.timeScale == 0f)
            return;

        transform.position += Vector3.left
            * speed * Time.deltaTime;

        if (transform.position.x < -15f)
            Destroy(gameObject);
    }
}

