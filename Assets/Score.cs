using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    Text text;
    public int score;
    public static int coinAmount;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;//점수 0으로 초기화
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = coinAmount.ToString();

        
    }
}
