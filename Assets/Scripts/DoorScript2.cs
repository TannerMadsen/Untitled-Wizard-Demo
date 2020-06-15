using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript2 : MonoBehaviour
{
    private GameObject[] Reqs;
    public GameObject Fade;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Reqs = GameObject.FindGameObjectsWithTag("DoorReq");
        if(Reqs.Length == 0){
            GameObject FinalFade = Instantiate(Fade) as GameObject;
            FinalFade.transform.position = transform.position;
            Destroy(this.gameObject);
        }
    }
}
