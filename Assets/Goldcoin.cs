using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goldcoin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.coinAmount += 5;
        Destroy(gameObject);
        Sound.SoundPlay();
    }
}
