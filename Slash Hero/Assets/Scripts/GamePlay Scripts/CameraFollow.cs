using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{   
    private Transform _playerPos;
    [SerializeField]
    private float _offsetX = -6f;
    private Vector3 _tempPos;
    private void Awake()
    {
        FindPlayerReference();
    }

    

    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        FollowPlayer();
    }
    private void FindPlayerReference()
    {
        _playerPos = GameObject.FindGameObjectWithTag(TagManager.Player_Tag).transform;
    }
    void FollowPlayer()
    {     if (!_playerPos)
            return;

        _tempPos = transform.position;
        _tempPos.x = _playerPos.position.x - _offsetX;
        transform.position = _tempPos;
    }
}
