using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PaintHit
{
    public class Circle : MonoBehaviour
    {
        private List<CircleFragment> fragments = new List<CircleFragment>();

        private void Start()
        {
            CircleFragment[] fragmentsArray = gameObject.GetComponentsInChildren<CircleFragment>();
            for (int i = 0; i < fragmentsArray.Length; i++)
            {
                ColorData data = new ColorData(Color.green, 1);
                fragments.Add(fragmentsArray[i]);
                fragmentsArray[0].SetColor(data);
            }
         }
    }

}

