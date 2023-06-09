using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashAbility : MonoBehaviour
{
    [SerializeField] float _speedAcceleration;
    [SerializeField] Rigidbody _rigidbody;
    [SerializeField] PlayerInput _playerInput;

    private void OnEnable()
    {
        _playerInput.OnDashPush += Dash;
    }
    private void OnDisable()
    {
        _playerInput.OnDashPush -= Dash;

    }

    private void Dash()
    {
        _rigidbody.AddForce(Vector3.forward * _speedAcceleration, ForceMode.VelocityChange);
    }

}