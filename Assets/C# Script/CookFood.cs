using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookFood : MonoBehaviour
{
    [SerializeField]
    private float cookingTime = 0;

    private float firstPositionOnCuttingBoard = -1;
    private float secondPositionOnCuttingBoard = 0;
    private float thirdPositionOnCuttingBoard = 1;

    private float firstPositionOnGrill = 5.5f;
    private float secondPositionOnGrill = 6.5f;
    private float thirdPositionOnGrill = 7.5f;

    public int occupiedSlot = 100;

    public string mouseControlled = "no";

    public string toppingStatus;

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
        if ((cookingTime > 3 && cookingTime <= 6) && (transform.position.x > 5))
        { 
            GetComponent<SpriteRenderer>().color = new Color (1, 1, 0);
        }
        if ((cookingTime > 6) && (transform.position.x > 5))
        {
            GetComponent<SpriteRenderer>().color = new Color(0, 0, 0);
        }

        if (occupiedSlot == Gameplay.selectedSandwich)
        {
            mouseControlled= "yes";
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 ojPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = new Vector2 (ojPosition.x, ojPosition.y - .2f);
            if (gameObject.name == "hamburger patty(Clone)")
            {
                Gameplay.currentMeat = "hamburger";
            }
        }

        if ((Gameplay.deleteFood == "yes") && (mouseControlled == "yes"))
        {
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        if (transform.position.x == firstPositionOnGrill)
        {
            Gameplay.grillS1 = "empty";
        }
        if (transform.position.x == secondPositionOnGrill)
        {
            Gameplay.grillS2 = "empty";
        }
        if (transform.position.x == thirdPositionOnGrill)
        {
            Gameplay.grillS3 = "empty";
        }

        if ((Gameplay.cuttingboardS1 == "JustBun") && (toppingStatus != "placed"))
        {
            GetComponent<Transform>().position = new Vector2 (firstPositionOnCuttingBoard, -1f);
            Gameplay.cuttingboardS1 = "FullBun";
            occupiedSlot = 1;
            toppingStatus = "placed";
        }
        else
            if ((Gameplay.cuttingboardS2 == "JustBun") && (toppingStatus != "placed"))
        {
            GetComponent<Transform>().position = new Vector2(secondPositionOnCuttingBoard, -1f);
            Gameplay.cuttingboardS2 = "FullBun";
            occupiedSlot = 2;
            toppingStatus = "placed";
        }
        else
            if ((Gameplay.cuttingboardS3 == "JustBun") && (toppingStatus != "placed"))
        {
            GetComponent<Transform>().position = new Vector2(thirdPositionOnCuttingBoard, -1f);
            Gameplay.cuttingboardS3 = "FullBun";
            occupiedSlot = 3;
            toppingStatus = "placed";
        }
    }
}
