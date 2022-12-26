using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PaintHit
{
    public class CircleController : MonoBehaviour
    {
        [SerializeField] private Circle circlePrefab;

        List<Circle> circleList = new List<Circle>();

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Instantiate();
            }
        }

        public void Instantiate()
        {
            MoveDownAll();
            GameObject gameObject = Instantiate(circlePrefab.gameObject);
            gameObject.transform.position = new Vector3(0, 0, 23);
            gameObject.name = "Circle";

            Circle circle = gameObject.GetComponent<Circle>();
            circleList.Add(circle);

        }

        private void MoveDownAll()
        {
           
            foreach (Circle target in circleList)
            {
                iTween.MoveBy(target.gameObject, iTween.Hash(new object[]
                {
                    "y",
                    -2.98f,
                    "easetype",
                    iTween.EaseType.spring,
                    "time",
                    0.5
                }));
            }
        }

    }
}


