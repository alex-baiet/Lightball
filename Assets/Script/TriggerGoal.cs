using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGoal : MonoBehaviour
{
    [SerializeField] private Counter counter = null;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "ball") { counter.AddPoint(name.Replace("trigger ", "") == "0" ? 1 : 0); }
    }
}
