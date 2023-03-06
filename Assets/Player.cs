using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [ SerializeField ]
    public float speed = 0.05f;
    float jump_speed = 8f;
    private Rigidbody2D player;

    public Vector3 respawnPoint;
    public GameObject fall;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        respawnPoint =  transform.position;
    }
    
    

    // Update is called once per frame
    void Update ()
    {
        Vector3 pos = transform.position ;

        if ( Input.GetKey ( KeyCode .A))
        {
            pos.x -= speed ;
        }
        if ( Input.GetKey ( KeyCode .D))
        {
            pos.x += speed ;
        }
        transform.position = pos ;
        
        if(Input.GetButtonDown("Jump"))
        {
            player.velocity = new Vector2(player.velocity.x, jump_speed);
        }

        fall.transform.position = new Vector2(transform.position.x, fall.transform.position.y);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("collision name="+other.gameObject.name);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collision trigger name="+collision.name);
        if (collision.tag == "Fall")
        {
            Debug.Log("Fall");
            transform.position = respawnPoint;
        }
        else if (collision.name == "Apple_0") {
                player.gravityScale = 0.5f;
                Destroy(collision.gameObject);
        }
    }
}
