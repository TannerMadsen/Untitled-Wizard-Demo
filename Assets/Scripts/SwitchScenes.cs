using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SwitchScenes : MonoBehaviour
{
    public float ExitX;
    public float ExitY;
    public string TargetScene;
    public Manager Manager;
    // Start is called before the first frame update
    void Start(){
        Manager = GameObject.FindWithTag("GameController").GetComponent<Manager>();
    }
    void OnTriggerEnter2D(Collider2D other){
        Manager.InitX = ExitX;
        Manager.InitY = ExitY;
        SceneManager.LoadScene (sceneName:TargetScene);
    }
    
}
