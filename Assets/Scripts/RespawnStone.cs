using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnStone : MonoBehaviour
{
    public PlayerHealth hp;
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
        if(other.tag == "Player"){
            Manager.ResY = transform.position.y;
            Manager.ResX = transform.position.x;
            Manager.RespawnScene = SceneManager.GetActiveScene().name;
            hp.CurrentHP = hp.MaxHP;
            
        }

    }
}
