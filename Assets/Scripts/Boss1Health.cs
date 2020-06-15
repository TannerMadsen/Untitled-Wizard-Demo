using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1Health : MonoBehaviour
{
    public float HP;
    public float MaxHP;
    public GameObject self;
    public GameObject explosion;
    public Manager Manager;

    // Start is called before the first frame update
    void Start()
    {
        Manager = GameObject.FindWithTag("GameController").GetComponent<Manager>();
        if(!Manager.Boss1Alive){
            Destroy(self);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(HP<=0){
            GameObject Explosion = Instantiate(explosion) as GameObject;
            Explosion.transform.position = transform.position;
            Manager.Boss1Alive = false;
            Destroy(self);
        }
    }
    
}
