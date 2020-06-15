using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ReadTablet2 : MonoBehaviour
{
    public Image bg;
    public Text readText;
    public string mytextnow;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag=="Player"){
            bg.enabled = true;
            readText.text = mytextnow;
            readText.enabled = true;
        }
    }
    void OnTriggerExit2D(Collider2D other){
        if(other.tag=="Player"){
            bg.enabled = false;
            readText.enabled = false;
        }
    }
}
