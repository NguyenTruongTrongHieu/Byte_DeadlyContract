using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Patron : MonoBehaviour
{
    public string orderedMeat = "hamburger";

    [SerializeField] private GameObject cookPanel;

    public tongdiem point;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        if ((Gameplay.deleteFood == "yes") && (Gameplay.currentMeat == orderedMeat))
        {
            point.diemtong += 10;
            cookPanel.SetActive(false);
        }
    }
}
