using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationTowerAbility : MonoBehaviour
{
    
    [SerializeField] private float _speedSlerp;
    [SerializeField] private Transform _towerTank;
    [SerializeField] private Camera _camera;

    private void FixedUpdate()
    {
        _towerTank.transform.rotation = Quaternion.Slerp(_towerTank.transform.rotation, _camera.transform.rotation, _speedSlerp);

    }
}
    