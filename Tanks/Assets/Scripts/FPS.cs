using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS : MonoBehaviour
{
    [SerializeField] private int _FPS;
    void Start()
    {
        Application.targetFrameRate = _FPS;
    }

}
