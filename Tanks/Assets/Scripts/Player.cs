using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody _rigidbodyPlayer;
    private float _horizontalDirect;
    private float _verticallDirect;
    private Vector3 _direction;
    private Vector3 _rotationTankVelocity;
    private float _speed;

    public float Speed { get { return _speed; } set { _speed = value; } }

    

    private void Awake()
    {
        _rigidbodyPlayer = GetComponent<Rigidbody>();
        _rotationTankVelocity = new Vector3(0, 100, 0);
    }

    private void Update()
    {
        InputDirectionTank();
        
    }

    private void FixedUpdate()
    {
        AddForceTank();

    }

    private void InputDirectionTank()
    {
        _horizontalDirect = Input.GetAxis("Horizontal");
        _verticallDirect = Input.GetAxis("Vertical");
        _direction = new Vector3(0f, 0f, _verticallDirect);
        
    }

    private void AddForceTank()
    {
        Quaternion _deltaRotation = Quaternion.Euler(_horizontalDirect * _rotationTankVelocity * Time.fixedDeltaTime);
        _rigidbodyPlayer.AddRelativeForce(_direction * _speed, ForceMode.VelocityChange);
        _rigidbodyPlayer.MoveRotation(_rigidbodyPlayer.rotation * _deltaRotation);
    }
}
