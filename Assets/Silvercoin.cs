using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silvercoin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.coinAmount += 3;
        Destroy(gameObject);
        Sound.SoundPlay();
    }
}
