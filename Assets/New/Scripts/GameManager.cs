using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;


namespace PaintHit
{
    public class GameManager : MonoBehaviour
    {
        [HideInInspector] public GameManager instance;

        [SerializeField] private CircleController circleController;
        [SerializeField] private BallController ballController;
       // [SerializeField] private ColorManager colorManager;

        public Camera camera;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
        }

        void Start()
        {
            ballController.InstantiateBall();
        }


       

        void Update()
        {

            if (Input.GetKeyDown(KeyCode.A))
            {
                circleController.InstantiateCircle();
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
             //   camera.DOShakePosition(5, 5, fadeOut: true);
            }
        }


    }

}
