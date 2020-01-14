using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    //public GameObject PosTopLeft;
    //public GameObject PosTopRight;
    //public GameObject PosBottomLeft;
    //public GameObject PosBottomRight;

    [SerializeField] private GameObject[] ballPositions;
    [SerializeField] private GameObject ball;
    
    public void MoveTheBall(){
        Debug.Log(Random.Range(0, 2));
    }
}
