using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D riggity;
    public Animator Animateme;
    private Vector2 move;
    public float speed;
    public float Dashspeed;
    public bool Dashing;
    private Vector2 Dashmove;
    public float Dashtime;
    private float DashtimeActual;

    public Transform playertransform;
    public Vector3 mousePoint;
    public BoxCollider2D voidcheck;
    public Manager Manager;
    
    // Start is called before the first frame update
    void Start()
    {
        Manager = GameObject.FindWithTag("GameController").GetComponent<Manager>();
        playertransform.position = new Vector2(Manager.InitX, Manager.InitY);
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            SceneManager.LoadScene("MainMenu");
        }
        mousePoint = Camera.main.ScreenToWorldPoint(new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0));
        if(Input.GetButtonDown("Jump") && !Dashing){
            Dashmove = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),0);
            
            Dashmove.Normalize();
            Dashing = true;
            DashtimeActual = Dashtime;
        }
        if(Dashing){
            
            voidcheck.enabled = false;
            move = Dashmove;
            DashtimeActual -= Time.deltaTime;

        }else{
            
            voidcheck.enabled = true;
            move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),0);
            move.Normalize();
        }
        if(DashtimeActual <=0){
            Dashing = false;
        }
        Animateme.SetFloat("HorizontalInput", Input.GetAxis("Horizontal"));
        Animateme.SetFloat("VerticalInput", Input.GetAxis("Vertical"));
    }
    void FixedUpdate()
    {
        if(Dashing){
            riggity.velocity = move * Dashspeed;

        }else{
            riggity.velocity = move * speed;

        }
        
        
    }
}
