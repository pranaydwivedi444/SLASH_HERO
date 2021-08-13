using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationsWithtransitions : MonoBehaviour
{
    private Animator _anim;
    [SerializeField]
    private GameObject _damageCollider;
    // Start is called before the first frame update
    private void Awake()
    {
        _anim = GetComponent<Animator>();
        
    }
     public void PlayFromJumpingToRunning(bool running)
    {
        _anim.SetBool(TagManager.RUNNING_ANIMATION_PARAMERTER, running);
    }
    // Update is called once per frame
    public void PlayJump(float velY)
    {
        _anim.SetFloat(TagManager.JUMP_ANIMATION_PARAMERTER, velY);
    }
    public void PlayDoubleJump()
    {
        _anim.SetTrigger(TagManager.DOUBLE_JUMP_ANIMATION_PARAMERTER);
    }
    public void PlayAttack()
    {
        _anim.SetTrigger(TagManager.ATTACK_ANIMATION_PARAMERTER);
    }

    public void PlayJumpAttack()
    {
        _anim.SetTrigger(TagManager.JUMP_ATTACK_ANIMATION_PARAMERTER);
    }
    void Update()
    {
        
    }

    //To activate and deactivate Damange Collider
    void ActivateDamageDetector()
    {
        
        _damageCollider.SetActive(true);
    }
    void DeactivateDamageDetector()
    {
        _damageCollider.SetActive(false);
    }
}
