using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace PaintHit
{
    public class Circle : MonoBehaviour
    {
        private List<CircleFragment> _fragments = new List<CircleFragment>();
        private void Start()
        {
            RotateCirlce();
         }

        public void Setup(ColorData colorData)
        {
            Prepare();
            if (_fragments.Count > 0)
            {
                _fragments[0].SetColor(colorData);
            }
          
        }


        private void Prepare()
        {
            if (_fragments.Count <= 0)
            {
                CircleFragment[] fragmentsArray = gameObject.GetComponentsInChildren<CircleFragment>();
                for (int i = 0; i < fragmentsArray.Length; i++)
                {
                    _fragments.Add(fragmentsArray[i]);  
                }
            }
        }

        public void RotateCirlce()
        {
            this.gameObject.transform.DORotate(new Vector3(0, 360, 0), 5.0f, RotateMode.FastBeyond360).
                SetLoops(-1, LoopType.Restart).SetEase(Ease.InOutSine);


        }
    }

}

