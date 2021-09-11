using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    [HideInInspector] public static int pointsToWin = 5;

    [SerializeField] private Transform[] players = new Transform[2];
    [SerializeField] private Transform ball = null;

    private int[] points = new int[2];
    [SerializeField] private Text[] textScores = new Text[2];
    private bool gameEnded;

    private float clock = 0f;
    private bool scoreDone = false;
    private int playerIdScored;
    [SerializeField] private Text textBut = null;

    private void Start()
    {

    }
    private void Update()
    {
        ButAnimation();
        if (InputPlayer.GetKeyDownRestartPoint()) { RestartPoint(); }
    }

    public void AddPoint(int playerId)
    {
        points[playerId]++;
        for (int i = 0; i < 2; i++)
        {
            textScores[i].text = points[i].ToString();
        }
        playerIdScored = playerId;
        scoreDone = true;

        if (points[playerId] >= pointsToWin)
        {
            gameEnded = true;
            SummaryLoader.StartLoadSummary(playerId);
        }
    }

    private void ButAnimation()
    {
        if (scoreDone && !gameEnded)
        {
            clock += Time.deltaTime;
            if (clock < 1)
            {
                textBut.transform.localScale = new Vector3(2f - clock, 2f - clock);
                textBut.color = new Color((playerIdScored == 0 ? 1f : 0.5f), (playerIdScored == 1 ? 1f : 0.5f), 0.5f, 1 - clock);
            }
            else
            {
                RestartPoint();
            }
        }
    }

    private void RestartPoint()
    {
        textBut.color = new Color(1, 1, 1, 0);
        clock = 0f;
        scoreDone = false;
        players[0].position = new Vector3(-4f, 0);
        players[1].position = new Vector3(4f, 0);
        ball.position = Vector3.zero;
        ball.gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
    }
}
