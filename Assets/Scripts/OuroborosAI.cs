using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuroborosAI : MonoBehaviour
{
    public Transform Player;
    public Rigidbody2D riggity;
    public float Rotationspeed;
    public float speed;
    private Quaternion _lookRotation;
    private Vector3 _direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _lookRotation = Quaternion.LookRotation(Player.position - transform.position);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, _lookRotation, Time.deltaTime * Rotationspeed);
        riggity.AddForce(transform.forward * speed * Time.deltaTime);
    
    }
}
