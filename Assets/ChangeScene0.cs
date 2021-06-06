using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene0 : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("SampleScene");
        
    }
}
