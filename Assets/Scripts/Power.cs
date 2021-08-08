using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Power : MonoBehaviour
{
    public Transform playerpos;
    public RectTransform rectTransform;
    public Transform Object;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Distance:" + Vector3.Distance(Object.position, playerpos.position));
        if (Vector3.Distance(Object.position, playerpos.position) < 5.8f && rectTransform.localScale.x <= 0.5f)
        {

            EnemyFollow.damage += 0.5f;
            rectTransform.localScale = new Vector3(EnemyFollow.damage, rectTransform.localScale.y, rectTransform.localScale.z);
            Destroy(gameObject);
        }
    }

    
}
