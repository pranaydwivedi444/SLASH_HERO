using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimation : MonoBehaviour
{
    private Animator _anim;
    [SerializeField] private GameObject _damageCollider;
    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }
    public void PlayAttack()
    {
        _anim.SetTrigger("Attack Trigger");
    }
   
    public void PlayDeath()
    {
        _anim.SetBool(TagManager.DEATH_ANIMATION_PARAMERTER,true);
    }

    void ActivateDamageDetector()
    {

        _damageCollider.SetActive(true);
    }
    void DeactivateDamageDetector()
    {
        _damageCollider.SetActive(false);
    }
}
