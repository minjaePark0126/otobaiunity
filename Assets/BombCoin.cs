using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombCoin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        Score.coinAmount += -10;//5���� ����
        Destroy(gameObject);//������ �������!
        Sound.SoundPlay();

        if (collision.gameObject.tag == "Co")//���ε����� Co�±� ��ŵ��
        {
            collision.gameObject.SetActive(false);
        }
    }
}
