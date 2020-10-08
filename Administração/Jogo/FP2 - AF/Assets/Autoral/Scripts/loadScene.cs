using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class loadScene : MonoBehaviour
{
    
  

   public void LoadScene (string load)
    {
        SceneManager.LoadScene(load);
        Time.timeScale = 1;
        
    }
}
