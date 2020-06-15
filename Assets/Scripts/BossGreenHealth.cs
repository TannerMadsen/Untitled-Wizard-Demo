using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossGreenHealth : MonoBehaviour
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
        if(!Manager.BossGreenAlive){
            Destroy(self);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(HP<=0){
            GameObject Explosion = Instantiate(explosion) as GameObject;
            Explosion.transform.position = transform.position;
            Manager.BossGreenAlive = false;
            Destroy(self);
        }
    }
    
}
