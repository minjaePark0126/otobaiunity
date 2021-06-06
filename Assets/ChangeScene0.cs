using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene0 : MonoBehaviour
{

    public int score;
    private void OnMouseDown()
    {
        SceneManager.LoadScene("SampleScene");
        score = 0;
    }
}
