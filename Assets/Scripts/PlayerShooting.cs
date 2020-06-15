using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShooting : MonoBehaviour
{
    public Transform playerPos;
    public GameObject Fireball;
    public GameObject Spear;
    public GameObject Frag;
    public PlayerMovement movie;
    public float firespeed;
    public float spearspeed;
    public float fragspeed;
    private Vector2 move;
    private float angle;

    public float CooldownTotal;
    private float Cooldown;
    private bool SpellScrollUp = true;
    public RectTransform WeaponBar;
    public Image Wbar;
    public Image WSprite;
    public Color FireballColor;
    public Sprite FireballSprite;
    public Color SpearColor;
    public Sprite SpearSprite;
    public Color FragColor;
    public Sprite FragSprite;

    // Start is called before the first frame update
    void Start()
    {
        Wbar.color = new Color(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        CooldownTotal = movie.Manager.SpellCooldown;
        if(Input.GetKeyDown(KeyCode.Q)){
            movie.Manager.CurrentSpell -= 1;
            SpellScrollUp = false;

        }
        if(Input.GetKeyDown(KeyCode.E)){
            movie.Manager.CurrentSpell += 1;
            SpellScrollUp = true;
        }
        if(movie.Manager.AllowedSpells.Contains(movie.Manager.CurrentSpell)){
            if(SpellScrollUp){
                movie.Manager.CurrentSpell += 1;
            }
            if(!SpellScrollUp){
                movie.Manager.CurrentSpell -= 1;
            }
        }
        if(movie.Manager.CurrentSpell < 1){
            movie.Manager.CurrentSpell = movie.Manager.AllowedSpells.Count;
            SpellScrollUp = false;
        }
        if(movie.Manager.CurrentSpell > movie.Manager.AllowedSpells.Count){
            movie.Manager.CurrentSpell = 1;
            SpellScrollUp = true;
        }
        

        if(Cooldown < CooldownTotal){
            WeaponBar.localScale = new Vector3(Cooldown/CooldownTotal, 1, 1);
            Cooldown += Time.deltaTime;
            
        }else{
            Cooldown = CooldownTotal;
            WeaponBar.localScale = new Vector3(Cooldown/CooldownTotal, 1, 1);
        }
        if(movie.Manager.CurrentSpell == 2){
            Wbar.color = FireballColor;
            WSprite.sprite = FireballSprite;
        }
        if(movie.Manager.CurrentSpell == 3){
            Wbar.color = SpearColor;
            WSprite.sprite = SpearSprite;
        }
        if(movie.Manager.CurrentSpell == 4){
            Wbar.color = FragColor;
            WSprite.sprite = FragSprite;
        }
        if(Input.GetButtonDown("Fire1") && movie.Manager.CurrentSpell == 2 && Cooldown >= CooldownTotal){
            GameObject projectile = Instantiate(Fireball) as GameObject;
            projectile.transform.position = playerPos.position;
            move = movie.mousePoint -playerPos.position;
            move.Normalize();
            projectile.GetComponent<Rigidbody2D>().velocity = move * firespeed;
            Cooldown = 0;
        }
        if(Input.GetButtonDown("Fire1") && movie.Manager.canSpear && movie.Manager.CurrentSpell == 3 && Cooldown >= CooldownTotal){
            GameObject spar = Instantiate(Spear) as GameObject;
            spar.transform.position = playerPos.position;
            move = movie.mousePoint -playerPos.position;
            move.Normalize();
            spar.GetComponent<Rigidbody2D>().velocity = move * spearspeed;
            Cooldown = 0;
        }
        if(Input.GetButtonDown("Fire1") && movie.Manager.canFrag && movie.Manager.CurrentSpell == 4 && Cooldown >= CooldownTotal){
            GameObject fragi = Instantiate(Frag) as GameObject;
            fragi.transform.position = playerPos.position;
            move = movie.mousePoint -playerPos.position;
            move.Normalize();
            fragi.GetComponent<Rigidbody2D>().velocity = move * fragspeed;
            Cooldown = 0;
        }
    }
}
