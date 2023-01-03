using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PaintHit
{
    public class BallController : MonoBehaviour
    {
        [SerializeField] Ball ballPrefab;

        private Ball _currentBall;
       

        public void InstantiateBall()
        {

            ColorData colorData = ColorManager.instance.GetBallColor();
            GameObject gameObject = Instantiate<GameObject>(ballPrefab.gameObject, new Vector3(0, 0, -8), Quaternion.identity);
            _currentBall = gameObject.GetComponent<Ball>();
            _currentBall.SetColorData(colorData);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _currentBall.MoveForward();
                Invoke("InstantiateBall",0.5f);
            }
        }
    }

}

