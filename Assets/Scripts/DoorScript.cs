using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    private GameObject[] Reqs;
    public GameObject Destination;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Reqs = GameObject.FindGameObjectsWithTag("DoorReq");
        if(Reqs.Length == 0){
            transform.position = Destination.transform.position;
        }
    }
}
