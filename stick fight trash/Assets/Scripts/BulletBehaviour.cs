using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    private float bulletXValue;
    // Start is called before the first frame update
    void Start()
    {
        bulletXValue = gameObject.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        bulletXValue += 0.1f;
        // setting new X value to position

        if (gameObject.transform.position.x > 15 || gameObject.transform.position.x < -15)
        {
            Destroy(gameObject);
        }
    }

    void FixedUpdate()
    {
        gameObject.transform.position = new Vector2(bulletXValue, gameObject.transform.position.y);
    }
}
