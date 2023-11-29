using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleObstacleBehaviour : MonoBehaviour
{
    [SerializeField] private Vector3 _start;
    [SerializeField] private Vector3 _end;
    [SerializeField] private float _duration;
    private float _current;

    private void Update()
    {
        _current += Time.deltaTime;
        var progress = Mathf.PingPong(_current, _duration) / _duration;
        
        var newScale = Vector3.Lerp(_start, _end, progress);
        transform.localScale = newScale;
    }
}
