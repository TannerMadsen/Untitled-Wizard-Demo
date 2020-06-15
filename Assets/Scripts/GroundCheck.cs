using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public PlayerMovement pscript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D other){
        if(other.gameObject.tag == "Ground"){
            Debug.Log("Grounded!");
        }else if(!pscript.Dashing){
            Debug.Log("Falling!");
        }
    }
    void OnTriggerExit2D(Collider2D other){
        if(other.gameObject.tag == "Ground" && !pscript.Dashing){
            Debug.Log("Falling!");
        }
    }
}
