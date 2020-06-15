using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public Manager Manager;
    
    public void PlayNewGame(){
        Manager = GameObject.FindWithTag("GameController").GetComponent<Manager>();
        Destroy(Manager.gameObject);
        SceneManager.LoadScene("Box");
        
    }
    public void ContinuePlaying(){
        Manager = GameObject.FindWithTag("GameController").GetComponent<Manager>();
        Manager.InitX = Manager.ResX;
        Manager.InitY = Manager.ResY;
        SceneManager.LoadScene(Manager.RespawnScene);
    }
    public void ToPlayMenu(){
        SceneManager.LoadScene("Play");
    }
    public void QuitGame(){
        Application.Quit();
        Debug.Log("Quit!");
    }
    public void QuitToMenu(){
        SceneManager.LoadScene("MainMenu");
    }
    public void GoToInformation(){
        SceneManager.LoadScene("InfoMenu");
    }
}
