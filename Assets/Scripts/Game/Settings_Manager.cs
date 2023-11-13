using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings_Manager : MonoBehaviour
{
    [SerializeField] private Dropdown Graphics_Dropdown;
    
    void Awake()
    {
        Load();
    }

    public void Change_Graphics(int Quality_Index)
    {
        QualitySettings.SetQualityLevel(Quality_Index);
        PlayerPrefs.SetInt("Game_Quality", Graphics_Dropdown.value);
        Save();
    }
    
    private void Load()
    {
        Graphics_Dropdown.value = PlayerPrefs.GetInt("Game_Quality");
        QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("Game_Quality"));
    }

    private void Save()
    {
        PlayerPrefs.Save();
    }
}
