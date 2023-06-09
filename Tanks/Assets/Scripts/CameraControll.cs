using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private float _sensitivity = 3.0f;
    [SerializeField] private PlayerInput _playerInput;

    private Vector3 _offset;
    private float _rotationX;
    


    void Awake()
    {
        _offset =this.transform.position;        
    }

    private void Start()
    {
        this.transform.position = _playerTransform.position + _offset;
    }
    private void Update()
    {
       
        _rotationX += _playerInput.MouseX * _sensitivity;
    }

    private void LateUpdate()
    {
        this.transform.position = _playerTransform.position + _offset;
        this.transform.rotation = Quaternion.Euler(0f, _rotationX, 0f);
    }
}
