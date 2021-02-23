using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public int GroundCollected = 0;

    void Awake()
    {
        if (instance != null && instance != this)
            Destroy(gameObject);    // Ensures that there aren't multiple Singletons

        instance = this;

    }
    
    public void IncreaseGround(int groundEarned)
    {
        GameManager.instance.GroundCollected += groundEarned;
    }

    public void DecreaseGround()
    {
        GameManager.instance.GroundCollected -= 1;
    }
        
    
}
