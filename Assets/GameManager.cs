using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    Text text;
    public int score;
    public static int coinAmount;
    void OnTriggerEnter2D(Collider2D collision)
    {
        Score.coinAmount += 5;//5점씩 증가
        Destroy(gameObject);//동전아 사라져랏!
        Sound.SoundPlay();

        if (collision.gameObject.tag == "Co")//코인들한테 Co태그 줬거든요
        {
            collision.gameObject.SetActive(false);
        }


        // Start is called before the first frame update
        void Start()
        {
            score = 0;
            text = GetComponent<Text>();
        }

        // Update is called once per frame
        void Update()
        {
            text.text = coinAmount.ToString();
        }







    }
}
