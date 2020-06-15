using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTreeAI : MonoBehaviour
{
    public GameObject floaty;
    public GameObject Player;
    public float senseDistance;
    public float CooldownTotal;
    private float Cooldown;
    public float BurstCooldownTotal;
    private float BurstCooldown;
    public GameObject Fireball;
    private Vector2 move;
    public float firespeed;
    private float State;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Cooldown = CooldownTotal;
        BurstCooldown = BurstCooldownTotal;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Vector2.Distance(floaty.transform.position, Player.transform.position) <= senseDistance){
            
            if(Cooldown <=0){
                if(State == 2){
                    State= Random.Range(0,2);
                }else{
                    State= Random.Range(0,3);
                }
                
                Cooldown = CooldownTotal;
            }else{
                Cooldown -= Time.deltaTime;
            }
            if(State==0){
                
                if(BurstCooldown <= 0){
                    GameObject projectile = Instantiate(Fireball, floaty.transform) as GameObject;
                    projectile.transform.position = floaty.transform.position;
                    move = Player.transform.position-floaty.transform.position;
                    move.Normalize();
                    projectile.GetComponent<Rigidbody2D>().velocity = move * firespeed;

                     projectile = Instantiate(Fireball, floaty.transform) as GameObject;
                    projectile.transform.position = floaty.transform.position;
                    move = Player.transform.position+new Vector3(Random.Range(-3,3),Random.Range(-3,3),0) -floaty.transform.position;
                    move.Normalize();
                    projectile.GetComponent<Rigidbody2D>().velocity = move * firespeed;

                     projectile = Instantiate(Fireball, floaty.transform) as GameObject;
                    projectile.transform.position = floaty.transform.position;
                    move = Player.transform.position+new Vector3(Random.Range(-3,3),Random.Range(-3,3),0) -floaty.transform.position;
                    move.Normalize();
                    projectile.GetComponent<Rigidbody2D>().velocity = move * firespeed;

                    BurstCooldown = BurstCooldownTotal;
                }else{
                    BurstCooldown -= Time.deltaTime;
                }
            }
            if(State==1){
                
                if(BurstCooldown <=0){
                    GameObject projectile = Instantiate(Fireball, floaty.transform) as GameObject;
                    projectile.transform.position = floaty.transform.position;
                    move = new Vector2(1,0);
                    move.Normalize();
                    projectile.GetComponent<Rigidbody2D>().velocity = move * firespeed;

                    projectile = Instantiate(Fireball, floaty.transform) as GameObject;
                    projectile.transform.position = floaty.transform.position;
                    move = new Vector2(-1,0);
                    move.Normalize();
                    projectile.GetComponent<Rigidbody2D>().velocity = move * firespeed;
                    
                    projectile = Instantiate(Fireball, floaty.transform) as GameObject;
                    projectile.transform.position = floaty.transform.position;
                    move = new Vector2(0,1);
                    move.Normalize();
                    projectile.GetComponent<Rigidbody2D>().velocity = move * firespeed;
                    

                    projectile = Instantiate(Fireball, floaty.transform) as GameObject;
                    projectile.transform.position = floaty.transform.position;
                    move = new Vector2(0,-1);
                    move.Normalize();
                    projectile.GetComponent<Rigidbody2D>().velocity = move * firespeed;

                    projectile = Instantiate(Fireball, floaty.transform) as GameObject;
                    projectile.transform.position = floaty.transform.position;
                    move = new Vector2(-1,-1);
                    move.Normalize();
                    projectile.GetComponent<Rigidbody2D>().velocity = move * firespeed;

                    projectile = Instantiate(Fireball, floaty.transform) as GameObject;
                    projectile.transform.position = floaty.transform.position;
                    move = new Vector2(1,-1);
                    move.Normalize();
                    projectile.GetComponent<Rigidbody2D>().velocity = move * firespeed;

                    projectile = Instantiate(Fireball, floaty.transform) as GameObject;
                    projectile.transform.position = floaty.transform.position;
                    move = new Vector2(-1,1);
                    move.Normalize();
                    projectile.GetComponent<Rigidbody2D>().velocity = move * firespeed;

                    projectile = Instantiate(Fireball, floaty.transform) as GameObject;
                    projectile.transform.position = floaty.transform.position;
                    move = new Vector2(1,1);
                    move.Normalize();
                    projectile.GetComponent<Rigidbody2D>().velocity = move * firespeed;
                    BurstCooldown = BurstCooldownTotal;
                }else{
                    BurstCooldown -= Time.deltaTime;
                }
            }
            if(State==2){
                if(BurstCooldown <= 0){
                    GameObject projectile = Instantiate(Fireball, floaty.transform) as GameObject;
                    projectile.transform.position = floaty.transform.position;
                    move = new Vector3(Random.Range(-3,3),Random.Range(-3,3),0);
                    move.Normalize();
                    projectile.GetComponent<Rigidbody2D>().velocity = move * firespeed;

                     projectile = Instantiate(Fireball, floaty.transform) as GameObject;
                    projectile.transform.position = floaty.transform.position;
                    move = new Vector3(Random.Range(-3,3),Random.Range(-3,3),0);
                    move.Normalize();
                    projectile.GetComponent<Rigidbody2D>().velocity = move * firespeed;

                     projectile = Instantiate(Fireball, floaty.transform) as GameObject;
                    projectile.transform.position = floaty.transform.position;
                    move = new Vector3(Random.Range(-3,3),Random.Range(-3,3),0);
                    move.Normalize();
                    projectile.GetComponent<Rigidbody2D>().velocity = move * firespeed;

                     projectile = Instantiate(Fireball, floaty.transform) as GameObject;
                    projectile.transform.position = floaty.transform.position;
                    move = new Vector3(Random.Range(-3,3),Random.Range(-3,3),0);
                    move.Normalize();
                    projectile.GetComponent<Rigidbody2D>().velocity = move * firespeed;

                     projectile = Instantiate(Fireball, floaty.transform) as GameObject;
                    projectile.transform.position = floaty.transform.position;
                    move = new Vector3(Random.Range(-3,3),Random.Range(-3,3),0);
                    move.Normalize();
                    projectile.GetComponent<Rigidbody2D>().velocity = move * firespeed;

                     projectile = Instantiate(Fireball, floaty.transform) as GameObject;
                    projectile.transform.position = floaty.transform.position;
                    move = new Vector3(Random.Range(-3,3),Random.Range(-3,3),0);
                    move.Normalize();
                    projectile.GetComponent<Rigidbody2D>().velocity = move * firespeed;

                     projectile = Instantiate(Fireball, floaty.transform) as GameObject;
                    projectile.transform.position = floaty.transform.position;
                    move = new Vector3(Random.Range(-3,3),Random.Range(-3,3),0);
                    move.Normalize();
                    projectile.GetComponent<Rigidbody2D>().velocity = move * firespeed;

                     projectile = Instantiate(Fireball, floaty.transform) as GameObject;
                    projectile.transform.position = floaty.transform.position;
                    move = new Vector3(Random.Range(-3,3),Random.Range(-3,3),0);
                    move.Normalize();
                    projectile.GetComponent<Rigidbody2D>().velocity = move * firespeed;



                    BurstCooldown = BurstCooldownTotal;
                }else{
                    BurstCooldown -= Time.deltaTime;
                }
            }
        }else{
            
        }
    }
}
