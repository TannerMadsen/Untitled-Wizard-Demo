using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    public float MaxHP;
    public float CurrentHP;
    public RectTransform HpMask;
    public bool Invincible = false;
    public float TotalIframes;
    private float CurrentIframes;
    public BoxCollider2D hitbox;
    public GameObject explosion;
    public GameObject Player;
    public Manager Manager;
    public float deathanim = 4;
    private float deathdelay;


    // Start is called before the first frame update
    void Start()
    {
        deathdelay = deathanim;
        Manager = GameObject.FindWithTag("GameController").GetComponent<Manager>();
        CurrentHP = Manager.Hp;
        MaxHP = Manager.MaxHp;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.O)){
            Manager.DebugMode = !Manager.DebugMode;
        }
        if(CurrentHP <0){
            CurrentHP = 0;
        }
        
        Manager.Hp = CurrentHP;
        Manager.MaxHp = MaxHP;
        if(Invincible && CurrentIframes>0){
            hitbox.enabled = false;
            CurrentIframes -= Time.deltaTime;


        }else{
            CurrentIframes = TotalIframes;
            hitbox.enabled = true;
            Invincible = false;
        }
        HpMask.localScale = new Vector3((CurrentHP/MaxHP)*5,1,1);
        if(CurrentHP<=0){
            if(deathdelay == deathanim){
                GameObject Explosion = Instantiate(explosion) as GameObject;
                Explosion.transform.position = transform.position;
                hitbox.enabled = false;
                Player.GetComponent<SpriteRenderer>().enabled = false;
                Player.GetComponent<PlayerMovement>().enabled = false;
                Player.GetComponent<PlayerShooting>().enabled = false;
            }
            if(deathdelay>0){
                deathdelay -= Time.deltaTime;
            }else{
                Manager.InitX = Manager.ResX;
                Manager.InitY = Manager.ResY;
                Manager.Hp = MaxHP;
                SceneManager.LoadScene (sceneName:Manager.RespawnScene);
            }
            
        }
    }
    void FullRegen(){
        CurrentHP = MaxHP;
    }
    void OnCollisionEnter2D(Collision2D other){
        if(!Manager.DebugMode){
            CurrentHP -= 1;
            Invincible = true;
            if(Manager.HoldingVitality){
                Manager.HoldingVitality = false;
            }
        }
    }
}
