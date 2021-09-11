using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int playerId = 0;
    [SerializeField] private float speed = 1f;
    [SerializeField] private Rigidbody2D rg;


    
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Movement();
    }


    private void Movement()
    {
        float diag = Mathf.Abs(InputPlayer.GetAxisRawHorizontal(playerId)) == 1f && Mathf.Abs(InputPlayer.GetAxisRawVertical(playerId)) == 1f ? 1 / Mathf.Sqrt(2) : 1;
        float moveX = InputPlayer.GetAxisHorizontal(playerId);
        float moveY = InputPlayer.GetAxisVertical(playerId);
        print(diag);
        rg.velocity = new Vector3(moveX, moveY) * diag * speed;
    }
}
