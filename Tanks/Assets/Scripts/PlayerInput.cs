using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class PlayerInput : MonoBehaviour
{

    private float _horizontalDirect;
    private float _verticallDirect;
    private float _mouseX;
    private float _mouseY;

    private Vector2 _secondaryMovementDirection;
    private Vector3 _primnaryMovementVertical;

    public Vector3 PrimnaryMovementVertical
    {
        get { return _primnaryMovementVertical; }
        private set { _primnaryMovementVertical = value; }
    }
    public Vector2 SecondaryMovementDirection
    {
        get { return _secondaryMovementDirection; }
        private set { _secondaryMovementDirection = value; }
    }

    public float HorizontzalDirection
    {
        get { return _horizontalDirect; }
        private set { _horizontalDirect = value; }
    }

    public float VerticalDirection
    {
        get { return _verticallDirect; }
        private set { _verticallDirect = value;}
    }

    public float MouseX
    {
        get { return _mouseX; }
        private set { _mouseX = value; }
    }

    public event Action OnDashPush;
 

    void Update()
    {
        PrimaryMoveInput();
        SecondaryMoveInput();
        DashInput();
    }

    void PrimaryMoveInput()
    {
        _horizontalDirect = Input.GetAxis("Horizontal");
        _verticallDirect = Input.GetAxis("Vertical");
        _primnaryMovementVertical = new Vector3(0f,0f, _verticallDirect);

    }
    private void SecondaryMoveInput()
    {
        _mouseX = Input.GetAxis("Mouse X");
        _mouseY = Input.GetAxis("Mouse Y");
        _secondaryMovementDirection = new Vector2(_mouseX,_mouseY);
    }

    void DashInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnDashPush?.Invoke();
        }
    }
}
