using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainMover : MonoBehaviour
{

    [SerializeField] private float _speed;
    [SerializeField] private float _startPos;
    [SerializeField] private float _resetPos;
    private void Update()
    {
        transform.position -= new Vector3(_speed, 0, 0);
        CheckPosition();
    }
    private void CheckPosition()
    {
        if(_startPos>_resetPos)
        {
            if (transform.position.x < _resetPos)
                transform.position = new Vector3(_startPos, transform.position.y, transform.position.z);
        }
        else
        {
            if (transform.position.x > _resetPos)
                transform.position = new Vector3(_startPos, transform.position.y, transform.position.z);
        }

    }
}
