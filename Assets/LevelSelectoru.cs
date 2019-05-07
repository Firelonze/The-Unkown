using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectoru : MonoBehaviour
{
    public void LoadStartScreen()
    {
        SceneManager.LoadScene("StartScreen", LoadSceneMode.Single);
    }
    public void LoadIntroDuctionLevel()
    {
        SceneManager.LoadScene("IntroDuction", LoadSceneMode.Single);
    }
    public void LoadHelp()
    {
        SceneManager.LoadScene("Help", LoadSceneMode.Single);
    }
}
