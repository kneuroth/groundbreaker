using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{

    private BoxCollider2D boxcolliderground;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnDestroy()
    {
        GameManager.instance.IncreaseGround(1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
