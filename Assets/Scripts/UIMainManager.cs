using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIMainManager : MonoBehaviour
{
    public Text txtCurrentPlayer;

    private void Start()
    {
        if (DataManager.Instance != null)
        { 
            txtCurrentPlayer.text = "Current Player: " + DataManager.Instance.playerName;
        }
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
