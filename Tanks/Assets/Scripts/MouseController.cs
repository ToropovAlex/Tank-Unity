using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{

    private Rigidbody _rigidbodyPlayer;
    private Vector2 _mouseInput;
    private Camera _camera;
    private float _mouseX;
    private float _mouseY;
    private float _rotationX;
    private float _rotationY;


    [SerializeField] private float _speed;
    [SerializeField] private Transform _towerTank;
    [SerializeField] private float _sensitivity = 3.0f;
    [SerializeField] private float _speedCamera = 2.0f;



    private void Awake()
    {
        _rigidbodyPlayer = GetComponent<Rigidbody>();
        _camera = Camera.main;
    }

    private void Update()
    {
        _mouseX = Input.GetAxis("Mouse X");
        _mouseY = Input.GetAxis("Mouse Y");
        _mouseInput = new Vector2(_mouseX, _mouseY);
        _rotationX += _mouseX * _sensitivity;
        _rotationY -= _mouseY * _sensitivity;

    }
    private void FixedUpdate()
    {
        _towerTank.transform.rotation = Quaternion.Slerp(_towerTank.transform.rotation, _camera.transform.rotation, 0.1f);

    }
    private void LateUpdate()
    {
        _camera.transform.rotation = Quaternion.Euler(0f, _rotationX, 0f);
       

    }
}
