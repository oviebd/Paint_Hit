using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] Ball ballPrefab;

    private Ball _currentBall;

    public void InstantiateBall()
    {
        GameObject gameObject = Instantiate<GameObject>(ballPrefab.gameObject, new Vector3(0, 0, -8), Quaternion.identity);
        gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
        _currentBall = gameObject.GetComponent<Ball>();

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _currentBall.MoveForward();
           Invoke("InstantiateBall",2.0f);
        }
    }
}
