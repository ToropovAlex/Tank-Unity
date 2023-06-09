using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullletMovement : MonoBehaviour
{
    [SerializeField] private float _speedBullet;
   
    void Update()
    {
        this.transform.position += transform.forward * _speedBullet* Time.deltaTime;
    }
}
