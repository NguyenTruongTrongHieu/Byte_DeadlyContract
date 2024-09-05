using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class checkbox : MonoBehaviour 
{
    [SerializeField]Transform itemcheckbox;
    [SerializeField]LayerMask box;
    [SerializeField]public bool boxcheck;
    Vector2 center;
    Vector2 size;
    public Text diemhienthi;
   public tongdiem point;
    public int diemitem;
 

    [SerializeField] public Button complet;
    // Start is called before the first frame update
    void Start()
    {
        complet.onClick.AddListener(tongket);
    }

    // Update is called once per frame
    void Update()
    {
        center = new Vector2(itemcheckbox.position.x,itemcheckbox.position.y);
        size = new(8f, 1f);
        boxcheck = Physics2D.OverlapBox(center, size, 0, box);
        
    }
    public void tongket()
    {
        if (boxcheck)
        {
            point.diemtong += diemitem;
        }
        else
        {
            point.diemtong -= diemitem;
        }
        diemhienthi.text = ($"diem : {point.diemtong}");

    }
}
