using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private BallController ballController;

    void Start()
    {
        ballController.InstantiateBall();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
