using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MatchRules : MonoBehaviour
{
    [SerializeField] private Text textCounter = null;

    private void Start()
    {
        AddPointToWin(0);
    }

    public void AddPointToWin(int toAdd)
    {
        Counter.pointsToWin += toAdd;
        Counter.pointsToWin = Counter.pointsToWin < 1 ? 1 : Counter.pointsToWin;
        textCounter.text = Counter.pointsToWin.ToString();
    }
}
