using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAbilityTank : MonoBehaviour
{

    [SerializeField] private Rigidbody _rigidbodyPlayer;
    [SerializeField] PlayerInput _playerInput;
    [SerializeField] float _speedTank;
    [SerializeField] float _speedRotationTank;
    private Vector3 _rotationTankVelocity;
    
    private void Awake()
    {
        _rotationTankVelocity = new Vector3(0, _speedRotationTank, 0);
    }

    private void FixedUpdate()
    {
        AddForceTank();

    }
    private void AddForceTank()
    {
        Quaternion _deltaRotation = Quaternion.Euler(_playerInput.HorizontzalDirection * _rotationTankVelocity * Time.fixedDeltaTime);
        _rigidbodyPlayer.AddRelativeForce(_playerInput.PrimnaryMovementVertical * _speedTank, ForceMode.VelocityChange);
        _rigidbodyPlayer.MoveRotation(_rigidbodyPlayer.rotation * _deltaRotation);
        
    }
}
