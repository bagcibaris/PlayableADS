using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class PlayerMovement : MonoBehaviour
{
   
    [SerializeField] private FloatingJoystick _joystick;
    [SerializeField] private AnimatorController _animatorController;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotateSpeed;

    private Rigidbody _rigidbody;
    private Vector3 _moveVector;
    public GameObject draw;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();    
    }

    private void Update()
    {
        CharacterMove();   
        
        if(transform.position.y <= -0.15f)  // Falling from the ground
        {
            gameObject.transform.position = new Vector3 (0f, 0f, -6.6f);
        }      
    }

    private void CharacterMove()
    {
        _moveVector = Vector3.zero;
        _moveVector.x = _joystick.Horizontal * _moveSpeed * Time.deltaTime;
        _moveVector.z = _joystick.Vertical * _moveSpeed * Time.deltaTime;

        if(_joystick.Horizontal != 0 || _joystick.Vertical != 0)
        {
            Vector3 direction = Vector3.RotateTowards(transform.forward, _moveVector, _rotateSpeed * Time.deltaTime, 0.0f);
            transform.rotation = Quaternion.LookRotation(direction);

            _animatorController.PlayRun();
        }
        else if(_joystick.Horizontal == 0 && _joystick.Vertical == 0)
        {
            _animatorController.PlayIdle();
        }

        _rigidbody.MovePosition(_rigidbody.position + _moveVector);
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name.Equals("FinishPlatform"))
        {
            Debug.Log("Finished");
            gameObject.transform.position = new Vector3 (0, 0, 15);
            draw.SetActive(true);
        }    

    } 
}
