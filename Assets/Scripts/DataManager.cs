using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    public string playerName;
    public int highScore;
    public string highScoreOwner;

    private void Start()
    {
        Debug.Log(Application.persistentDataPath);
        LoadData();
    }

    // Singleton pattern
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    [System.Serializable]
    class SaveHighScore
    {
        public int highScore;
        public string playerName;
    }

    public void SaveData()
    {
        SaveHighScore data = new SaveHighScore();
        data.highScore = highScore;
        data.playerName = highScoreOwner;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadData()
    {
        string path = Application.persistentDataPath + "/savefile.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveHighScore data = JsonUtility.FromJson<SaveHighScore>(json);

            highScore = data.highScore;
            highScoreOwner = data.playerName;
        }
    }
}
