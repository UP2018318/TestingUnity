using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClickController : MonoBehaviour
{
    public void OnClickClickerGame(){
        Debug.Log("YOU CLICKED IT");

    }
    public void LoadIdleGame(){
        SceneManager.LoadScene("IdleGame", LoadSceneMode.Single);
    }

    public void LoadWhiteNoiseGame(){
        SceneManager.LoadScene("WhiteNoise", LoadSceneMode.Single);
    }


    
}

