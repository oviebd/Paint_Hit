using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbody;
    private float speed = 100;

    public void MoveForward()
    {
        rigidbody.AddForce(Vector3.forward * speed, ForceMode.Impulse);
        Destroy(gameObject, 2.0f);
    }


}
