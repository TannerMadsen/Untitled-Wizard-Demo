using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilFireballExplode : MonoBehaviour
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
        GameObject Explosion = Instantiate(explosion) as GameObject;
        Explosion.transform.position = transform.position;
        
        Destroy(gameObject);
    }
}
