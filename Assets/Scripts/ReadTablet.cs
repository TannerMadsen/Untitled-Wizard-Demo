using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ReadTablet : MonoBehaviour
{

    // Start is called before the first frame update
    public Manager Manager;
    public Image Background;
    public Text Text1;
    public GameObject QuitButton;

    public PlayerMovement movie;
    public bool PlayingCutscene;
    // Start is called before the first frame update
    void Start()
    {
        Manager = GameObject.FindWithTag("GameController").GetComponent<Manager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Player"){
            PlayingCutscene = true;
            movie.enabled = false;
            Background.enabled = true;
            Text1.enabled = true;
            QuitButton.SetActive(true);
            
        }
    }
}
