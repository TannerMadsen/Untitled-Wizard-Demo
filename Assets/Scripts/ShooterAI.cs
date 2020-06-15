using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterAI : MonoBehaviour
{
    public GameObject floaty;
    public GameObject Player;
    public Pathfinding.AIPath path;
    public float senseDistance;
    public float CooldownTotal;
    private float Cooldown;
    public GameObject Fireball;
    private Vector2 move;
    public float firespeed;
    public SpriteRenderer spritey;
    
    // Start is called before the first frame update
    void Start()
    {
        Cooldown = CooldownTotal;
        
    }

    // Update is called once per frame
    void Update()
    {
        spritey.flipX = Player.transform.position.x > floaty.transform.position.x;
        if(Vector2.Distance(floaty.transform.position, Player.transform.position) <= senseDistance){
            path.enabled = true;
            if(Cooldown <= 0){
                GameObject projectile = Instantiate(Fireball, floaty.transform) as GameObject;
                projectile.transform.position = floaty.transform.position;
                move = Player.transform.position -floaty.transform.position;
                move.Normalize();
                projectile.GetComponent<Rigidbody2D>().velocity = move * firespeed;
                Cooldown = CooldownTotal;
            }else{
                Cooldown -= Time.deltaTime;
            }
        }else{
            path.enabled = false;
        }
    }
}
