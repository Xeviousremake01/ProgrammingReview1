using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI scoreDisplay;
    public TextMeshProUGUI livesDisplay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = "score:" + 10;
        GetComponent<TextMeshProUGUI>().text = "lives:" - 1;
    }
}
