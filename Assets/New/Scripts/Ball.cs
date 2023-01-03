using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PaintHit
{
    public class Ball : MonoBehaviour
    {
        [SerializeField] private Rigidbody rigidbody;
        private float speed = 100;
        private ColorData _colorData;

        public void MoveForward()
        {
            rigidbody.AddForce(Vector3.forward * speed, ForceMode.Impulse);
            Destroy(gameObject, 2.0f);
        }

        public void SetColorData(ColorData colorData)
        {
            _colorData = colorData;
            gameObject.GetComponent<MeshRenderer>().material.color = _colorData.color;
        }

        public ColorData GetColorData()
        {
            return _colorData;
        }


    }
}

