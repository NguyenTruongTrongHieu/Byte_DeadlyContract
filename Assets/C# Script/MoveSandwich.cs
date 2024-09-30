using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSandwich : MonoBehaviour
{
    private int pivot;

    public int occupiedSlot = 0;    

    public string mousecontrolled;
    // Start is called before the first frame update
    void Start()
    {
        occupiedSlot = Gameplay.selectedSlot;
        mousecontrolled = "no";

        //Chinh vi tri cua banh
        if (transform.position == new Vector3(-1, -0.8f, 0))
        {
            pivot = 1;
        }
        if (transform.position == new Vector3(0, -0.8f, 0))
        {
            pivot = 2;
        }
        if (transform.position == new Vector3(1, -0.8f, 0))
        {
            pivot = 3;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if (mousecontrolled == "yes")
        {
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 ojPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = ojPosition;

            if (pivot == 1)
            {
                Gameplay.cuttingboardS1 = "empty";
            }
            if (pivot == 2)
            {
                Gameplay.cuttingboardS2 = "empty";
            }
            if (pivot == 3)
            {
                Gameplay.cuttingboardS3 = "empty";
            }

        }

        if ((Gameplay.deleteFood == "yes") && (mousecontrolled == "yes"))
        {
            //Gameplay.deleteFood = "no";
            Gameplay.selectedSlot = 0;
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        mousecontrolled = "yes";
        Gameplay.selectedSandwich = occupiedSlot;
    }
}
