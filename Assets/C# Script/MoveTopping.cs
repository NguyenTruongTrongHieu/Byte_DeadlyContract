using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTopping : MonoBehaviour
{
    public int occupiedSlot = 99;

    public string mouseControlled = "no";
    // Start is called before the first frame update
    void Start()
    {
        occupiedSlot = Gameplay.selectedSlot;
    }

    // Update is called once per frame
    void Update()
    {
        if (occupiedSlot == Gameplay.selectedSandwich)
        {
            mouseControlled = "yes";
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 ojPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = new Vector2(ojPosition.x, ojPosition.y - .4f);
        }

        if ((Gameplay.deleteFood == "yes") && (mouseControlled == "yes"))
        {
            Destroy(gameObject);
            Gameplay.deleteFood = "no";
        }
    }
}
