using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerationPlayer : MonoBehaviour
{
    private Player _player;
    private float _horizontalAcceleration;
    private float _verticallAcceleration;

    [SerializeField] float _speedAcceleration;
    [SerializeField] float _speedTank;

    void Awake()
    {
        _player = GetComponent<Player>();
        _player.Speed = _speedTank;
    }

    void Update()
    {
       ChangeSpeed();
    }

    private void ChangeSpeed()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _player.Speed = _speedAcceleration;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            _player.Speed = _speedTank;
        }
    }

   


}
