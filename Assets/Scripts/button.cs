using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartBtn()
    {
        Debug.Log("Buttonclicked");
        SceneManager.LoadScene("Scrunner1");
    }
    public void QuitBtn()
    {
        Application.Quit();
    }
}
