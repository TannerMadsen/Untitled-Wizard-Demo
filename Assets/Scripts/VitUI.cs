using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VitUI : MonoBehaviour
{
    private Image GemImage;
    public Manager Manager;
    // Start is called before the first frame update
    void Start()
    {
        Manager = GameObject.FindWithTag("GameController").GetComponent<Manager>();
        GemImage = this.gameObject.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Manager.HoldingVitality){
            GemImage.enabled = true;
        }else{
            GemImage.enabled = false;
        }
    }
}
