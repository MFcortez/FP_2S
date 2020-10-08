using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitGame : MonoBehaviour
{
    // só sai do jogo quando está Buildado.
    public void Exit()
    {
        Debug.Log("*Saiu*");
        Application.Quit();
    }
}
