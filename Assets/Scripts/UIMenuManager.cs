using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIMenuManager : MonoBehaviour
{
    public InputField playerNameInputField;
    public TextMeshProUGUI noNameWarning;

    private void Awake()
    {
        noNameWarning.enabled = false;
    }

    public void StartGame()
    {
        if (playerNameInputField.text == string.Empty)
        {
            noNameWarning.enabled = true;
        }
        else
        {
            DataManager.Instance.playerName = playerNameInputField.text;
            SceneManager.LoadScene(1);
        }

    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
