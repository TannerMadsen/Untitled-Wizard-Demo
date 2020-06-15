using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BossBar : MonoBehaviour
{
    public GameObject Boss;
    public RectTransform Bar;
    public GameObject TotalBossBar;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Boss == null){
            Destroy(TotalBossBar);
        }else{
            if(Boss.GetComponent<EnemyHealth>()){
                Bar.localScale = new Vector3(Boss.GetComponent<EnemyHealth>().HP/Boss.GetComponent<EnemyHealth>().MaxHP, 1, 1);
            }else if(Boss.GetComponent<Enemy2Health>()){
                Bar.localScale = new Vector3(Boss.GetComponent<Enemy2Health>().HP/Boss.GetComponent<Enemy2Health>().MaxHP, 1, 1);
            }else if(Boss.GetComponent<Boss1Health>()){
                Bar.localScale = new Vector3(Boss.GetComponent<Boss1Health>().HP/Boss.GetComponent<Boss1Health>().MaxHP, 1, 1);
            }else if(Boss.GetComponent<BossGreenHealth>()){
                Bar.localScale = new Vector3(Boss.GetComponent<BossGreenHealth>().HP/Boss.GetComponent<BossGreenHealth>().MaxHP, 1, 1);
            }
        }
        
    }
}
