using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovingObstacleBehaviour : MonoBehaviour
{
    [SerializeField] private float _offsetStep = 1f;
    [SerializeField] private float _duration = 1f;
    [SerializeField ]private float _pauseTimeStep = 1f;
    private Vector3 _startPosition;
    private Vector3 _endPosition;
    
    private float _current;
    private float _pauseTime;

    private void Start()
    {
        _startPosition = transform.position;
        _endPosition = new Vector3(_startPosition.x, _startPosition.y + _offsetStep, _startPosition.z);
    }
    
    private void GenerateNextPosition()
    {
        _startPosition = transform.position;
        _endPosition = new Vector3(_startPosition.x, _startPosition.y + _offsetStep, _startPosition.z);
    }

    private void Update()
    {
        if (_pauseTime > 0f)
        {
            _pauseTime -= Time.deltaTime;
            return;
        }
        _current += Time.deltaTime;
        var progress = _current / _duration;
        transform.position = Vector3.Lerp(_startPosition, _endPosition, progress);
        
        if (_current >= _duration)
        {
            _current = 0f;
            _pauseTime = _pauseTimeStep;
            GenerateNextPosition();
        }
    }
}
