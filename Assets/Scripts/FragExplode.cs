using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FragExplode : MonoBehaviour
{
    public GameObject explosion;
    public GameObject Fireball;
    public float firespeed;
    public float Lifetime;
    private float LifetimeActual;
    private Vector2 move;
    // Start is called before the first frame update
    void Start()
    {
        LifetimeActual = Lifetime;
    }

    // Update is called once per frame
    void Update()
    {
        LifetimeActual -= Time.deltaTime;
        if(LifetimeActual <= 0){
            Explode();
        }
    }
    void OnCollisionEnter2D(Collision2D collision){
        
        if(collision.gameObject.GetComponent<EnemyHealth>()){
            collision.gameObject.GetComponent<EnemyHealth>().HP -=1;
        }else if(collision.gameObject.GetComponent<Boss1Health>()){
            collision.gameObject.GetComponent<Boss1Health>().HP -=1;
        }else if(collision.gameObject.GetComponent<BossGreenHealth>()){
            collision.gameObject.GetComponent<BossGreenHealth>().HP -=1;
        }
        Explode();
        
    }
    void Explode(){
        GameObject Explosion = Instantiate(explosion) as GameObject;
        Explosion.transform.position = transform.position;

        GameObject projectile = Instantiate(Fireball) as GameObject;
        projectile.transform.position = transform.position+ new Vector3(0.1f,0,0);
        move = new Vector2(1,0);
        move.Normalize();
        projectile.GetComponent<Rigidbody2D>().velocity = move * firespeed;

        projectile = Instantiate(Fireball) as GameObject;
        projectile.transform.position = transform.position+ new Vector3(-0.1f,0,0);
        move = new Vector2(-1,0);
        move.Normalize();
        projectile.GetComponent<Rigidbody2D>().velocity = move * firespeed;
        
        projectile = Instantiate(Fireball) as GameObject;
        projectile.transform.position = transform.position+ new Vector3(0,0.1f,0);
        move = new Vector2(0,1);
        move.Normalize();
        projectile.GetComponent<Rigidbody2D>().velocity = move * firespeed;
        

        projectile = Instantiate(Fireball) as GameObject;
        projectile.transform.position = transform.position+ new Vector3(0,-0.1f,0);
        move = new Vector2(0,-1);
        move.Normalize();
        projectile.GetComponent<Rigidbody2D>().velocity = move * firespeed;

        projectile = Instantiate(Fireball) as GameObject;
        projectile.transform.position = transform.position+ new Vector3(-0.1f,-0.1f,0);
        move = new Vector2(-1,-1);
        move.Normalize();
        projectile.GetComponent<Rigidbody2D>().velocity = move * firespeed;

        projectile = Instantiate(Fireball) as GameObject;
        projectile.transform.position = transform.position+ new Vector3(0.1f,-0.1f,0);
        move = new Vector2(1,-1);
        move.Normalize();
        projectile.GetComponent<Rigidbody2D>().velocity = move * firespeed;

        projectile = Instantiate(Fireball) as GameObject;
        projectile.transform.position = transform.position+ new Vector3(-0.1f,0.1f,0);
        move = new Vector2(-1,1);
        move.Normalize();
        projectile.GetComponent<Rigidbody2D>().velocity = move * firespeed;

        projectile = Instantiate(Fireball) as GameObject;
        projectile.transform.position = transform.position+ new Vector3(0.1f,0.1f,0);
        move = new Vector2(1,1);
        move.Normalize();
        projectile.GetComponent<Rigidbody2D>().velocity = move * firespeed;
        Destroy(gameObject);
    }
}
