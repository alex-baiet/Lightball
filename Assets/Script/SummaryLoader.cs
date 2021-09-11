using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SummaryLoader : MonoBehaviour
{
    private static bool loadSummary = false;
    private static int playerWinner;

    [SerializeField] private float length = 1;
    [Space]
    [SerializeField] private GameObject summaryObject = null;
    [SerializeField] private RawImage background = null;
    [SerializeField] private Text[] victoryText = new Text[2];
    [SerializeField] private GameObject buttons = null;
    private float clock = 0;
    private bool loadEnded = false;


    void Start()
    {
        buttons.SetActive(false);
        loadSummary = false;
    }

    void Update()
    {
        if (loadSummary && !loadEnded)
        {
            if (clock == 0)
            {
                for (int i = 0; i < 2; i++) { victoryText[i].text = playerWinner == i ? "VICTOIRE" : "DEFAITE"; }
                summaryObject.SetActive(true);
            }

            clock += Time.deltaTime;
            if (clock < length)
            {
                float coef = clock / length;
                background.color = new Color(0, 0, 0, coef / 2);
                foreach (Text text in victoryText)
                {
                    text.color = new Color(text.color.r, text.color.g, text.color.b, coef);
                }
            }
            else
            {
                loadEnded = true;
                buttons.SetActive(true);

                background.color = new Color(0, 0, 0, 0.5f);
                foreach (Text text in victoryText)
                {
                    text.color = new Color(text.color.r, text.color.g, text.color.b, 1f);
                }
            }
        }
    }

    public static void StartLoadSummary(int playerIdWinner)
    {
        loadSummary = true;
        playerWinner = playerIdWinner;
    }
}
