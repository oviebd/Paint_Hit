using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace PaintHit
{
    public class CircleFragment : MonoBehaviour
    {
        private MeshRenderer _meshRenderer;
    //    private ColorData _colorData;

        private void Awake()
        {
            GetMeshRenderer();
        }

        private MeshRenderer GetMeshRenderer()
        {
            if (_meshRenderer == null)
            {
                _meshRenderer = GetComponent<MeshRenderer>();
            }
            return _meshRenderer;
        }

        public void SetColor(ColorData color)
        {
            GetMeshRenderer().material.color = color.color;
        }


        private void OnCollisionEnter(Collision collision)
        {
            Ball ball = collision.gameObject.GetComponent<Ball>();
            if (ball != null)
            {

                ColorData data = ball.GetColorData();
                SetColor(data);
            }
        }
    }
}

