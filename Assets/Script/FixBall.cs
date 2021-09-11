using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixBall : MonoBehaviour
{
    [SerializeField] private float forceToAdd = 1;
    private Rigidbody2D rg;

    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        Collider2D[] colliders = new Collider2D[10];
        if (rg.GetContacts(colliders)>1)
        {
            if (Mathf.Abs(transform.position.x) > 5 && Mathf.Abs(transform.position.x) < 6 && 
                Mathf.Abs(transform.position.y) > 3 && Mathf.Abs(transform.position.y) < 4)
            {
                rg.AddForce(new Vector3(1, 1) * forceToAdd);
            }

        }
    }
}
