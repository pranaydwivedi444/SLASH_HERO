using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _movSpeed = 7f, _jumpForce= 20f;
    private Rigidbody2D _myBody;
    private Transform _groundCheckPos;
    [SerializeField] private LayerMask _groundLayer;
    private bool _canDoubleJump;
    private PlayerAnimationsWithtransitions _playerAnim;
    private float _attackWaitTime = 0.5f;
    private float _attackTimer;
    private bool _canAttack;

    // Start is called before the first frame update
    private void Awake()
    {
        _myBody = GetComponent<Rigidbody2D>();
        _groundCheckPos = transform.GetChild(0).transform;
        _playerAnim = GetComponent<PlayerAnimationsWithtransitions>();
    }
  
    private void FixedUpdate()
    {
        MovePlayer();
    }

    

    // Update is called once per frame
    void Update()
    {
        PlayerJump();
        AnimatePlayer();
        GetAttackInput();
        HandleAttackAction();
    }

    private void MovePlayer()
    {
        _myBody.velocity = new Vector2(_movSpeed, _myBody.velocity.y);
    }

    //Checking if its grounded
    bool IsGrounded()
    {
        return Physics2D.Raycast(_groundCheckPos.position, Vector2.down, 1f, _groundLayer);
    }
    void PlayerJump()
    {
        if(Input.GetKeyDown(KeyCode.W)||Input.GetButtonDown(TagManager.JUMP_BUTTON))
        {   
            if(!IsGrounded()&&_canDoubleJump)
            {
                _canDoubleJump = false;
                _myBody.velocity = Vector2.zero;
                _myBody.AddForce(new Vector2(0f, _jumpForce), ForceMode2D.Impulse);
                _playerAnim.PlayDoubleJump();
            }
            if(IsGrounded())
            {
                _canDoubleJump = true;
                _myBody.AddForce(new Vector2(0f, _jumpForce), ForceMode2D.Impulse); 
            }
        }
    }

    //Animations
    void AnimatePlayer()
    {
        _playerAnim.PlayJump(_myBody.velocity.y);
        _playerAnim.PlayFromJumpingToRunning(IsGrounded());
    }
    //Attack Animations
    void GetAttackInput()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            if(Time.time > _attackTimer)
            {
                _attackTimer = Time.time + _attackWaitTime;
                _canAttack = true;
            }
        }

    }
    void HandleAttackAction()
    {
        if(_canAttack && IsGrounded())
        {
            
            _playerAnim.PlayAttack();
            _canAttack = false;
        }
        else if(_canAttack && !IsGrounded())
        {
            _canAttack = false;
            _playerAnim.PlayJumpAttack();
        }
    }
}
