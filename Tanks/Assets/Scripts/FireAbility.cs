using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAbility : MonoBehaviour
{

    [SerializeField] private GameObject _prefabBullet;
    [SerializeField] private Transform _pointFire;
    [SerializeField] private PlayerInput _input;

      void Update()
    {
        if (_input.LeftButtonMouse)
        {
            Instantiate(_prefabBullet,_pointFire.position, _pointFire.rotation);
        }
      
    }
}
