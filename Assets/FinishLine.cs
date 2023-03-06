using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    public GameObject text;

    private void OnTriggerEnter2D(Collider2D collider) {
        GameObject hitObj = collider.gameObject.transform.parent.gameObject;
        
        if(hitObj.tag == "Player"){
            Debug.Log("next level");
            text.SetActive(true);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
