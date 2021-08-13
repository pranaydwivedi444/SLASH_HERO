using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This Class helps us save memory!!!!
public class RepositionBackground : MonoBehaviour
{
    private GameObject[] Backgrounds;
    [SerializeField]
    private string _bgTag;
    private float highestXPosition;
    private float offsetValue;
    private float newXPos;
    private Vector3 newPosition;

    // Start is called before the first frame update
    void Awake()
    {
        Backgrounds = GameObject.FindGameObjectsWithTag(_bgTag);
        offsetValue = Backgrounds[0].GetComponent<BoxCollider2D>().bounds.size.x;
        highestXPosition = Backgrounds[0].transform.position.x;
        for (int i = 1; i<Backgrounds.Length; i++)
        {
            if (Backgrounds[i].transform.position.x > highestXPosition)
                highestXPosition = Backgrounds[i].transform.position.x;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag(_bgTag))
        {
            newXPos = highestXPosition + offsetValue;
            highestXPosition = newXPos;
            newPosition = collision.transform.position;
            newPosition.x = newXPos;
            collision.transform.position = newPosition;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
