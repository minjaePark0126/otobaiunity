using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour
{

    public int score;

    public void Restart()
    {
        Time.timeScale = 1;

    }
    void Start()
    {
    }
    private void OnMouseDown()
    {
        
        SceneManager.LoadScene("SampleScene");
    }
    
}
