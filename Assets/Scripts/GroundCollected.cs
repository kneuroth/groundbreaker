using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GroundCollected : MonoBehaviour
{
    public TextMeshProUGUI Score_UIText;
    // Start is called before the first frame update
    void Start()
    {
        Score_UIText.text = GameManager.instance.GroundCollected.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Score_UIText.text = GameManager.instance.GroundCollected.ToString();
    }
    
}
