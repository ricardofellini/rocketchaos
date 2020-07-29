using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsMovement : MonoBehaviour
{
    [SerializeField]
    Transform[] Positions;

    int NextPosIndex;

    Transform NextPos;

    public float Speed;

    void Start()
    {
        NextPos = Positions[0];
    }

    
    void Update()
    {
        MoveGameObjects();
    }

    void MoveGameObjects()
    {


        if (transform.position == NextPos.position)
        {

            NextPosIndex++;
            if(NextPosIndex >= Positions.Length)
            {
                NextPosIndex = 0;

            }
            NextPos = Positions[NextPosIndex];
        }
        else
        {


            transform.position = Vector3.MoveTowards(transform.position, NextPos.position, Speed * Time.deltaTime);
        }
    }
    
}
