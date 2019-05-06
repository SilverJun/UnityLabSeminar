using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    private Rigidbody _rigid;
    
    [SerializeField] [Range(0.0f,30.0f)]
    private float _force;

    // Start is called before the first frame update
    void Start()
    {
        _rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rigid.AddForce(-Vector3.right * _force);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _rigid.AddForce(Vector3.right * _force);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _rigid.AddForce(Vector3.forward * _force);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            _rigid.AddForce(-Vector3.forward * _force);
        }
    }
}
