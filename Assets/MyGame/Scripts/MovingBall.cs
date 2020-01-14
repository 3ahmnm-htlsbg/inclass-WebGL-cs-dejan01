using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovingBall : MonoBehaviour
{

    public GameObject Ball;
    
    [SerializeField]private GameObject[] BallPositions;


    private int RandomNum()
    {
        return Random.Range(0, 4);
    }
 

    public void BallPos()
    { 
        Ball.transform.position = BallPositions[RandomNum()].transform.position;
    }

}