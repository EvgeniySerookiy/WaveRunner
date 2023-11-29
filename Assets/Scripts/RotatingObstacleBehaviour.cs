using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingObstacleBehaviour : MonoBehaviour
{
    [SerializeField]
    private float _duration = 1f;

    private void Update()
    {
        transform.Rotate(Vector3.back, _duration);
    }
}
