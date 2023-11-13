using UnityEngine.SceneManagement;

public static class SceneLoader
{
    public enum Scenes
    {
        MainMenu,
        FirstPrototypeMap,
    }
   
    public static void Load(Scenes scene)
    {
        SceneManager.LoadSceneAsync(scene.ToString(), LoadSceneMode.Single);
    }
}
