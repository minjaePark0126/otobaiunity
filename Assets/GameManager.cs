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
        Score.coinAmount += 5;//5���� ����
        Destroy(gameObject);//������ �������!
        Sound.SoundPlay();

        if (collision.gameObject.tag == "Co")//���ε����� Co�±� ��ŵ��
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
