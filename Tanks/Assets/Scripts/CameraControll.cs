using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private float _sensitivity = 3.0f;
    private Vector3 _offset;
    private float _rotationX;
    private float _mouseX;


    void Awake()
    {
        _offset =this.transform.position;        
    }

    private void Start()
    {
        this.transform.position = _playerTransform.position + _offset;
    }

    private void SetCamera()
    {
        this.transform.position = _playerTransform.position + _offset;
    }
    private void Update()
    {
        SetCamera();
        _mouseX = Input.GetAxis("Mouse X");
        _rotationX += _mouseX * _sensitivity;
    }

    private void LateUpdate()
    {
        this.transform.rotation = Quaternion.Euler(0f, _rotationX, 0f);
    }
}
