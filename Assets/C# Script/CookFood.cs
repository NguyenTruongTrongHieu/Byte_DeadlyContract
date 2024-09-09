using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookFood : MonoBehaviour
{
    [SerializeField]
    private float cookingTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cookingTime += Time.deltaTime;
        if (cookingTime <= 3)
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
        }
        if (cookingTime > 3 && cookingTime <= 6)
        { 
            GetComponent<SpriteRenderer>().color = new Color (1, 1, 0);
        }
        if (cookingTime > 6)
        {
            GetComponent<SpriteRenderer>().color = new Color(0, 0, 0);
        }
    }
}
