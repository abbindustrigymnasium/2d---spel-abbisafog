using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickmanBehaviour : MonoBehaviour
{   
    public Rigidbody2D player;
    bool isJumpKeyPressed;
    public GameObject bullet;
    public GameObject ak;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            isJumpKeyPressed = true;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet,
                new Vector2(ak.transform.position.x + 1.2f, ak.transform.position.y + 0.1f),
                new Quaternion(0, 0, 0, 0));
        }
    }

    private void FixedUpdate() {

        //player.velocity = new Vector2(Input.GetAxisRaw("Horizontal")*10, 0);

        if (isJumpKeyPressed) {
            Debug.Log("test");
            player.AddForce(Vector2.up * 15, ForceMode2D.Impulse);
            isJumpKeyPressed = false;
        }
    }
}
