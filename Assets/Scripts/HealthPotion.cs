using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    public PlayerHealth hp;
    public float boost;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Player" && (hp.CurrentHP + boost) <= hp.MaxHP){
            hp.CurrentHP += boost;
            Destroy(this.gameObject);
        }else if(other.gameObject.tag == "Player" && (hp.CurrentHP + boost) > hp.MaxHP){
            hp.CurrentHP = hp.MaxHP;
            Destroy(this.gameObject);
        }
    }
}
