using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickmanBehaviour : MonoBehaviour
{   
    public Rigidbody2D player;
    public GameObject bullet;
    public GameObject ak;
    bool isJumpKeyPressed;
    int jumpCount;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && jumpCount<2)
        {
            isJumpKeyPressed = true;
            jumpCount++;
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Instantiate(bullet,
                new Vector2(ak.transform.position.x + 1.2f, ak.transform.position.y + 0.1f),
                new Quaternion(0, 0, 0, 0));
        }
    }

    private void FixedUpdate() {

        player.velocity = new Vector2(Input.GetAxisRaw("Horizontal")*10, player.velocity.y);

        if (isJumpKeyPressed) {
            player.AddForce(Vector2.up * 15, ForceMode2D.Impulse);
            isJumpKeyPressed = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {   
        if(collision.gameObject.name == "Floor")
        {
            jumpCount = 0;
        }
    }
}
