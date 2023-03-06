using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskGuy : MonoBehaviour
{
    [SerializeField]
    public float damage;

    private Vector3 respawnPoint;
    private float health = 1f;

   
    void Start()
    {
       
    }


    void Update ()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        
        Debug.Log (collision.collider.name);
        if(collision.collider.tag == "Head"){
            Debug.Log("Hit on the head");

            collision.gameObject.GetComponent<Player>().healthBar.Damage(0.2f);

            health-=0.3f;
            Debug.Log("health:"+ health);

            if(health<=0){
                Debug.Log("respawn");
                collision.gameObject.transform.position =  collision.gameObject.GetComponent<Player>().respawnPoint;
                health =1f;
            } 
        }

        else if(collision.collider.tag == "Body"){
            Debug.Log("Hit on the body");

            collision.gameObject.GetComponent<Player>().healthBar.Damage(0.1f);

            health-=0.2f;
            Debug.Log("health:"+ health);

            if(health<=0){
                Debug.Log("respawn");
                collision.gameObject.transform.position =  collision.gameObject.GetComponent<Player>().respawnPoint;
                health = 1f;
            } 
        }
    }
}
