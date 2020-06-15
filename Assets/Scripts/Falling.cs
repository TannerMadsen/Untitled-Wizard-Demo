using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{
    public PlayerHealth PHP;
    public GameObject Respawn;
    public GameObject Player;
    public Manager Manager;
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
        if(other.gameObject.layer == 9){
            if(!Manager.DebugMode){
                PHP.CurrentHP -= 1;
                PHP.Invincible = true;
            }
            
            Player.transform.position = Respawn.transform.position;
        }
    }
}
