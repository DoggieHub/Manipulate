using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxManipulate : MonoBehaviour
{
    [SerializeField]
    private float _speed = 0.0f;
    [SerializeField]
    internal string _name;
    private Transform _transform;
    // Start is called before the first frame update
    void Start()
    {
        _transform = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void StepForward(int step)// step - distance tp box
    {
        var position = _transform.position;
        position = new Vector3(position.x  + step, transform.position.y, position.z);
        _transform.position = position;
    }
    
    
}
