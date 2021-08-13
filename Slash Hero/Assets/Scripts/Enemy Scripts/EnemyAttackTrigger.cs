 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    private EnemyAnimation _enemyAnim;

    private void Awake()
    {
        _enemyAnim = GetComponentInParent<EnemyAnimation>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag(TagManager.Player_Tag))
        {
            _enemyAnim.PlayAttack();
        }
    }
}
