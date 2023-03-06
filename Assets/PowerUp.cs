using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PowerUp : MonoBehaviour
{
    public float increase = 0.051f;

    private void OnTriggerEnter2D(Collider2D col){
        if(col.tag == "Player"){
            GameObject player = col.gameObject;
            Rigidbody2D r = player.GetComponent<Rigidbody2D>();
            if(r){
                r.gravityScale = 0.5f;
                Destroy(gameObject);
            }
           // Player playerScript = player.GetComponent<Player>();
            /*if (playerScript) {
                playerScript.speed += increase;
                Destroy(gameObject);
            }*/
        }
    }
}
