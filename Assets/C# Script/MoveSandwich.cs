using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSandwich : MonoBehaviour
{
    public int occupiedSlot = 0;    

    public string mousecontrolled = "no";
    // Start is called before the first frame update
    void Start()
    {
        occupiedSlot = Gameplay.selectedSlot;
    }

    // Update is called once per frame
    void Update()
    {
        if (mousecontrolled == "yes")
        {
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 ojPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = ojPosition;
            
        }

        if ((Gameplay.deleteFood == "yes") && (mousecontrolled == "yes"))
        {
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        mousecontrolled = "yes";
        Gameplay.selectedSandwich = occupiedSlot;
    }
}
