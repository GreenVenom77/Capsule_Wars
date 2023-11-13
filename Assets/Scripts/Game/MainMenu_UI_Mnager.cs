using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu_UI_Mnager : MonoBehaviour
{
    [SerializeField] GameObject Play_Btn;
    [SerializeField] GameObject Settings_Btn;
    [SerializeField] GameObject Settings_Menu;
    [SerializeField] GameObject Exit_Btn;
    [SerializeField] GameObject SocialMedia_Btn;
    [SerializeField] GameObject SocialMedia_Menu;
    [SerializeField] AudioClip Btn_sfx;
    AudioSource audioSource;


    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    
    public void Play()
    {
        SceneLoader.Load(SceneLoader.Scenes.FirstPrototypeMap);
        Sfx_Btn_s();
    }
    
    public void Settings()
    {
        Play_Btn.SetActive(false);
        Settings_Btn.SetActive(false);
        Exit_Btn.SetActive(false);
        //SocialMedia_Btn.SetActive(false);
        Settings_Menu.SetActive(true);
        Sfx_Btn_s();
    }

    public void SocialMedia()
    {
        Play_Btn.SetActive(false);
        Settings_Btn.SetActive(false);
        Exit_Btn.SetActive(false);
        SocialMedia_Btn.SetActive(false);
        SocialMedia_Menu.SetActive(true);
        Sfx_Btn_s();
    }

    public void Close_Menu()
    {
        Play_Btn.SetActive(true);
        Settings_Btn.SetActive(true);
        Exit_Btn.SetActive(true);
        //SocialMedia_Btn.SetActive(true);
        Settings_Menu.SetActive(false);
        SocialMedia_Menu.SetActive(false);
        Sfx_Btn_s();
    }
    
    public void Exit()
    {
        Application.Quit();
        Sfx_Btn_s();
    }
    
    void Sfx_Btn_s()
    {
        audioSource.PlayOneShot(Btn_sfx);
    }
}
