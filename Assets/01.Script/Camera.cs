using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform _target;
    public Vector3  _offset;
    private Transform _position;
    private float _prevAngle;

    private float _velocity = 2;
    void Start()
    {
        _position = this.gameObject.GetComponent<Transform>();
        
        if(_target)
            _prevAngle = _target.rotation.y;
    }

    // Update is called once per frame
    void Update()
    {
        TraceTarget();
    }

    bool TraceTarget()
    {
        if(_target)
        {
            _position.position = _target.position + _offset;
            

            Vector3 vecCampPos = new Vector3(_position.position.x, _target.position.y, _position.position.z);

            Vector3 vecDir = _target.position - vecCampPos;

            vecDir.Normalize();

            float angle = Vector3.Dot(_target.forward, vecDir);
            Vector3 vecCross = Vector3.Cross(vecDir, _target.forward);

            
            float sign = vecCross.y >= 0.0f ? 1.0f : -1.0f;


            angle = Mathf.Acos(angle);

            angle = angle * Mathf.Rad2Deg * sign;

            _position.RotateAround(_target.position, Vector3.up, angle);

            _position.LookAt(_target);
            
            return true;
        }
        else
        {
            return false;
        }
    }

}
