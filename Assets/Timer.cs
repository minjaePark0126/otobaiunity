using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    static float deltaTime;
    public float LimitTime;
    public Text text_Timer;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LimitTime -= Time.deltaTime;
        text_Timer.text = "�ð� : "+Mathf.Round(LimitTime);
    }
}
