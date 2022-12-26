using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PaintHit
{
    public class CircleFragment : MonoBehaviour
    {
        private MeshRenderer _meshRenderer;
        private ColorData _colorData;

        private void Start()
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
            if (collision.gameObject.GetComponent<Ball>())
            {
                ColorData data = new ColorData(Color.red,1);
                SetColor(data);
            }
        }
    }
}

