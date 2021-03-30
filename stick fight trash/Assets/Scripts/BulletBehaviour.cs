using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    private float fireballXValue;
    // Start is called before the first frame update
    void Start()
    {
        fireballXValue = gameObject.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        fireballXValue += 0.1f;
        // setting new X value to position
        gameObject.transform.position = new Vector2(fireballXValue, gameObject.transform.position.y);
    }
}
