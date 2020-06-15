using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FraggemScript : MonoBehaviour
{

    // Start is called before the first frame update
    public Manager Manager;
    public Image Background;
    public Text Text1;
    public Text Text2;
    public GameObject explosion;
    public PlayerMovement movie;
    public bool PlayingCutscene;
    // Start is called before the first frame update
    void Start()
    {
        Manager = GameObject.FindWithTag("GameController").GetComponent<Manager>();
        if(Manager.GotFrag){
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayingCutscene){
            if(Input.GetButtonDown("Jump")){
                Manager.canFrag = true;
                Manager.GotFrag = true;
                Manager.AllowedSpells.Add(1);
                PlayingCutscene = false;
                movie.enabled = true;
                Background.enabled = false;
                Text1.enabled = false;
                Text2.enabled = false;
                GameObject Explosion = Instantiate(explosion) as GameObject;
                Explosion.transform.position = transform.position;
                Destroy(this.gameObject);
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Player"){
            PlayingCutscene = true;
            movie.enabled = false;
            Background.enabled = true;
            Text1.enabled = true;
            Text2.enabled = true;
            
        }
    }
}
