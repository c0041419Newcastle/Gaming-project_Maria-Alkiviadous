using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private RectTransform bar;

    // Start is called before the first frame update
    void Start()
    {
        bar = GetComponent<RectTransform>();
        SetSize(Health.total);
    }

    public void Damage (float damage){
        if ((Health.total -= damage) >= 0f){
            Health.total -=damage;
        }
        else{
            Health.total = 0f;
        }

        SetSize(Health.total);
    }

    public void SetSize (float size){
        bar.localScale = new Vector3 (size, 1f);
    }
}
