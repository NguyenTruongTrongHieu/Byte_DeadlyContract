using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class TimeOneDay : MonoBehaviour
{
    public float setTimeOneDay = 10f;
    float timeOneDay;
    bool isContinue;

    public GameObject TimeOverPanel;
    public GameObject Puzzle;
    public GameObject XepHinh;
    public GameObject ChooseBox;
    public GameObject Storage;
    public GameObject Grid;
    public GameObject Score;

    public Button play;
    public Button playAgain;

    public Text countTime;

    private Grid gridInstance;
    private CompletePuzzle completeInstance;

    public void Start()
    {
        playAgain.onClick.AddListener(OutOfTime);

        gridInstance = Grid.GetComponent<Grid>();
        completeInstance = Score.GetComponent<CompletePuzzle>();
        timeOneDay = setTimeOneDay;
        isContinue = true;
    }

    private void Update()
    {
        //Dem thoi gian
        int minute = Mathf.FloorToInt(timeOneDay / 60);
        int second = Mathf.FloorToInt(timeOneDay % 60);
        countTime.text = string.Format("{0:00}:{1:00}", minute, second);

        //Tinh thoi gian
        if (isContinue == true)
        {
            if (timeOneDay <= 0)
            {
                TimeOverPanel.SetActive(true);
                timeOneDay = setTimeOneDay;
                isContinue = false;
            }
            else
            {
                timeOneDay -= Time.deltaTime;
            }
        }
    }

    public void OutOfTime()//Reset cac chuc nang
    {
        isContinue = true;

        Puzzle.SetActive(false);
        ChooseBox.SetActive(true);
        XepHinh.SetActive(false);
        TimeOverPanel.SetActive(false);

        completeInstance.isReturnNewLevel = true;
        Storage.transform.SetParent(play.transform);
        gridInstance.ResetGrid();
    }
}
