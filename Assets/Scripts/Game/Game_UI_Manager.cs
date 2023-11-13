using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_UI_Manager : MonoBehaviour
{
    [SerializeField] GameObject Pause_Btn;
    [SerializeField] GameObject Pause_Menu;
    [SerializeField] GameObject Resume_Btn;
    [SerializeField] GameObject Settings_Btn;
    [SerializeField] GameObject Settings_Menu;
    [SerializeField] GameObject Home_Btn;
    [SerializeField] AudioClip Btn_sfx;
    AudioSource audioSource;


    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Pause()
    {
        Pause_Menu.SetActive(true);
        Pause_Btn.SetActive(false);
        Time.timeScale = 0f;
        Sfx_Btn_s();
    }
    
    public void Resume()
    {
        Pause_Menu.SetActive(false);
        Pause_Btn.SetActive(true);
        Time.timeScale = 1f;
        Sfx_Btn_s();
    }
    
    public void Settings()
    {
        Resume_Btn.SetActive(false);
        Settings_Btn.SetActive(false);
        Home_Btn.SetActive(false);
        Settings_Menu.SetActive(true);
        Sfx_Btn_s();
    }

    public void Close_Menu()
    {
        Resume_Btn.SetActive(true);
        Settings_Btn.SetActive(true);
        Home_Btn.SetActive(true);
        Settings_Menu.SetActive(false);
        Sfx_Btn_s();
    }

    public void Home()
    {
        SceneLoader.Load(SceneLoader.Scenes.MainMenu);
        Time.timeScale = 1f;
        Sfx_Btn_s();
    }

    void Sfx_Btn_s()
    {
        audioSource.PlayOneShot(Btn_sfx);
    }
}
