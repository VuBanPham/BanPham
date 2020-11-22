using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI text;
    public TextMeshProUGUI text1;
    int score = 0;
    int dscore = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void ChangeScore(int cherryValue)
    {
        score += cherryValue;
        text.text = "X" + score.ToString();       
    }

    public void ChangeDiamondScore(int diamondValue)
    {
        dscore += diamondValue;
        text1.text = "X" + dscore.ToString();
    }
    
}
