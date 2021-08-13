using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamage : MonoBehaviour
{

    private bool _deactivateGameObject;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(TagManager.Player_Tag))
        {
            if (_deactivateGameObject)
                gameObject.SetActive(false);
        }

        if (collision.CompareTag(TagManager.ENEMY_TAG) || collision.CompareTag(TagManager.OBSTACLE_TAG))
        {

            Debug.Log("Damaged");
        }
    }
}
