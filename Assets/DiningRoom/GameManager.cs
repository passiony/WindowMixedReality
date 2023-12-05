using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject light;
    public Material daySky;
    public Material nightsky;
    public void SetNight()
    {
        RenderSettings.skybox = nightsky;        
        DynamicGI.UpdateEnvironment();
    }
    public void SetDaySky()
    {
        RenderSettings.skybox = daySky;        
        DynamicGI.UpdateEnvironment();
    }
    
    public void lightoff()
    {
        light.SetActive(false);
    }
    public void lighton()
    {
        light.SetActive(true);
    }
    
    public void goToMain()
    {
        SceneManager.LoadScene(1);
    }
    public void exitGame()
    {
        Application.Quit();
    }
}
