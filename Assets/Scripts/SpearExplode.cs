using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearExplode : MonoBehaviour
{
    public GameObject explosion;
    public float Lifetime;
    private float LifetimeActual;
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
            GameObject Explosion = Instantiate(explosion) as GameObject;
            Explosion.transform.position = transform.position;
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D collision){
        
        if(collision.gameObject.GetComponent<EnemyHealth>()){
            collision.gameObject.GetComponent<EnemyHealth>().HP -=1;
        }else if(collision.gameObject.GetComponent<Boss1Health>()){
            collision.gameObject.GetComponent<Boss1Health>().HP -=1;
        }else if(collision.gameObject.GetComponent<Enemy2Health>()){
            collision.gameObject.GetComponent<Enemy2Health>().HP -=1;
        }
        
    }
    
}
