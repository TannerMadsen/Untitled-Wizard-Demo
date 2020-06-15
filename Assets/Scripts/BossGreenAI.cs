using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossGreenAI : MonoBehaviour
{
    public GameObject floaty;
    public GameObject Player;
    public Pathfinding.AIPath path;
    public float senseDistance;
    public float CooldownTotal;
    private float Cooldown;
    public float BurstCooldownTotal;
    private float BurstCooldown;
    public GameObject Fireball;
    public GameObject Minion;
    private Vector2 move;
    public float firespeed;
    private float State;
    public SpriteRenderer spritey;
    
    // Start is called before the first frame update
    void Start()
    {
        Cooldown = CooldownTotal;
        BurstCooldown = BurstCooldownTotal;
        
    }

    // Update is called once per frame
    void Update()
    {
        spritey.flipX = Player.transform.position.x > floaty.transform.position.x;
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
                path.enabled = true;
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
                path.enabled = false;
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
                GameObject minion = Instantiate(Minion, floaty.transform) as GameObject;
                minion.transform.position = floaty.transform.position;
                minion.GetComponent<Pathfinding.AIDestinationSetter>().target = Player.transform;
                minion.GetComponent<Boss1AI>().Player = Player;
                minion.GetComponent<Boss1AI>().spritey = minion.GetComponentInChildren<SpriteRenderer>();
                Cooldown = -1;
            }
        }else{
            path.enabled = false;
        }
    }
}
