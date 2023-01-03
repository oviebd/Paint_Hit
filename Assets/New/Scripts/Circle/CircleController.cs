using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace PaintHit
{
    public class CircleController : MonoBehaviour
    {
        [SerializeField] private Circle circlePrefab;

        List<Circle> circleList = new List<Circle>();

        

        public void InstantiateCircle()
        {
            ColorData colorData = ColorManager.instance.GetCurrentColor();
            MoveDownAll();
            GameObject gameObject = Instantiate(circlePrefab.gameObject);
            gameObject.transform.position = new Vector3(0, 10, 23);
            gameObject.transform.DOMoveY(0, 0.2f).SetEase(Ease.InOutSine);
            gameObject.name = "Circle " + circleList.Count;

            Circle circle = gameObject.GetComponent<Circle>();
            circle.Setup(colorData);
            circleList.Add(circle);

        }

        private void MoveDownAll()
        {

            foreach (Circle target in circleList)
            {
             
                Vector3 newPos = new Vector3(target.transform.position.x, target.transform.position.y - 3.0f, target.transform.position.z);
                target.gameObject.transform.DOMoveY(newPos.y, 0.5f).SetEase(Ease.InOutSine);
            }
        }

    }
}


