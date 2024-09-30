using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinControll : MonoBehaviour
{
    [SerializeField]
    private Transform bottomBunObj;
    [SerializeField]
    private Transform topBunObj;
    [SerializeField]
    private Transform burgersObj;
    [SerializeField]
    private Transform backRollObj;
    [SerializeField]
    private Transform frontRollObj;
    [SerializeField]
    private Transform hotDogObj;


    private float firstPositionOnCuttingBoard = -1;
    private float secondPositionOnCuttingBoard = 0;
    private float thirdPositionOnCuttingBoard = 1;

    private float firstPositionOnGrill = 5.5f;
    private float secondPositionOnGrill = 6.5f;
    private float thirdPositionOnGrill = 7.5f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnMouseDown()
    {
        if (gameObject.name == "bun bin")
        {
            if (Gameplay.cuttingboardS2 == "empty")
            {
                Instantiate(bottomBunObj, new Vector2(secondPositionOnCuttingBoard, -1f), Quaternion.identity);
                Instantiate(topBunObj, new Vector2(secondPositionOnCuttingBoard, -0.8f), Quaternion.identity);
                Gameplay.cuttingboardS2 = "JustBun";
                Gameplay.selectedSlot = 2;
            }

            //if (Gameplay.cuttingboardS1 == "empty")
            //{
            //    Instantiate(bottomBunObj, new Vector2(firstPositionOnCuttingBoard, -1f), Quaternion.identity);
            //    Instantiate(topBunObj, new Vector2(firstPositionOnCuttingBoard, -0.8f), Quaternion.identity);
            //    Gameplay.cuttingboardS1 = "JustBun";
            //    Gameplay.selectedSlot = 1;
            //}
            //else if (Gameplay.cuttingboardS2 == "empty")
            //{
            //    Instantiate(bottomBunObj, new Vector2(secondPositionOnCuttingBoard, -1f), Quaternion.identity);
            //    Instantiate(topBunObj, new Vector2(secondPositionOnCuttingBoard, -0.8f), Quaternion.identity);
            //    Gameplay.cuttingboardS2 = "JustBun";
            //    Gameplay.selectedSlot = 2;
            //}
            //else if (Gameplay.cuttingboardS3 == "empty")
            //{
            //    Instantiate(bottomBunObj, new Vector2(thirdPositionOnCuttingBoard, -1f), Quaternion.identity);
            //    Instantiate(topBunObj, new Vector2(thirdPositionOnCuttingBoard, -0.8f), Quaternion.identity);
            //    Gameplay.cuttingboardS3 = "JustBun";
            //    Gameplay.selectedSlot = 3;
            //}
        }
        if (gameObject.name == "hamburgers")
        {
            if (Gameplay.grillS2 == "empty")
            {
                Instantiate(burgersObj, new Vector2(secondPositionOnGrill, -0.74f), Quaternion.identity);
                Gameplay.grillS2 = "full";
            }

            //if (Gameplay.grillS1 == "empty")
            //{
            //    Instantiate(burgersObj, new Vector2(firstPositionOnGrill, -0.74f), Quaternion.identity);
            //    Gameplay.grillS1 = "full";
            //}
            //else if (Gameplay.grillS2 == "empty")
            //{
            //    Instantiate(burgersObj, new Vector2(secondPositionOnGrill, -0.74f), Quaternion.identity);
            //    Gameplay.grillS2 = "full";
            //}
            //else if (Gameplay.grillS3 == "empty")
            //{
            //    Instantiate(burgersObj, new Vector2(thirdPositionOnGrill, -0.74f), Quaternion.identity);
            //    Gameplay.grillS3 = "full";
            //}
        }
        //if (gameObject.name == "roll bin")
        //{
        //    if (Gameplay.cuttingboardS1 == "empty")
        //    {
        //        Instantiate(backRollObj, new Vector2(firstPositionOnCuttingBoard, -1f), Quaternion.identity);
        //        Instantiate(frontRollObj, new Vector2(firstPositionOnCuttingBoard, -1f), Quaternion.identity);
        //        Gameplay.cuttingboardS1 = "full";
        //    }
        //    else if (Gameplay.cuttingboardS2 == "empty")
        //    {
        //        Instantiate(backRollObj, new Vector2(secondPositionOnCuttingBoard, -1f), Quaternion.identity);
        //        Instantiate(frontRollObj, new Vector2(secondPositionOnCuttingBoard, -1f), Quaternion.identity);
        //        Gameplay.cuttingboardS2 = "full";
        //    }
        //    else if (Gameplay.cuttingboardS3 == "empty")
        //    {
        //        Instantiate(backRollObj, new Vector2(thirdPositionOnCuttingBoard, -1f), Quaternion.identity);
        //        Instantiate(frontRollObj, new Vector2(thirdPositionOnCuttingBoard, -1f), Quaternion.identity);
        //        Gameplay.cuttingboardS3 = "full";
        //    }
        //}
        //if (gameObject.name == "hotdog bin")
        //{
        //    if (Gameplay.grillS1 == "empty")
        //    {
        //        Instantiate(hotDogObj, new Vector2(firstPositionOnGrill, -0.74f), Quaternion.identity);
        //        Gameplay.grillS1 = "full";
        //    }
        //    else if (Gameplay.grillS2 == "empty")
        //    {
        //        Instantiate(hotDogObj, new Vector2(secondPositionOnGrill, -0.74f), Quaternion.identity);
        //        Gameplay.grillS2 = "full";
        //    }
        //    else if (Gameplay.grillS3 == "empty")
        //    {
        //        Instantiate(hotDogObj, new Vector2(thirdPositionOnGrill, -0.74f), Quaternion.identity);
        //        Gameplay.grillS3 = "full";
        //    }
        //}
    }
}
