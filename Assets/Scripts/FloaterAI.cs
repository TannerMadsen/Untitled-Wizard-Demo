using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloaterAI : MonoBehaviour
{
    public GameObject floaty;
    public GameObject Player;
    public Pathfinding.AIPath path;
    public float senseDistance;
    public SpriteRenderer spritey;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spritey.flipX = Player.transform.position.x > floaty.transform.position.x;
        if(Vector2.Distance(floaty.transform.position, Player.transform.position) <= senseDistance){
            path.enabled = true;
        }else{
            path.enabled = false;
        }
    }
}
