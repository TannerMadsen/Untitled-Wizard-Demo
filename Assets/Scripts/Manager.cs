using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public float InitX;
    public float InitY;
    public static Manager Instance;
    public string RespawnScene;
    public float ResX;
    public float ResY;
    public float Hp;
    public float MaxHp;
    public bool Boss1Alive;
    public bool BossGreenAlive;
    public bool canSpear;
    public bool canFrag;
    public float CurrentSpell;
    public List<float> AllowedSpells;
    public float SpellCooldown;
    public bool DebugMode;
    public bool GotSpear;
    public bool GotFrag;
    public bool GotCooldown;
    public bool GotVitality;
    public bool HoldingVitality;

    void Awake ()   
       {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy (gameObject);
        }
      }
}
