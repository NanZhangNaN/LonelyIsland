using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie : MonoBehaviour
{
    public float z_speed = 5;
    public double maxDistance = 8;
    public double farDistance = 7;
    public double dangerDistance = 1.32;
    public Animator z_anim;
    public CharacterController z_controller;
    public Transform Player;
    private bool z_isdead;
    // Start is called before the first frame update
    void Start()
    {
        z_anim = GetComponent<Animator>();
        z_controller = GetComponent<CharacterController>();
        z_isdead = false;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(Player.position, transform.position);
        if(distance<=maxDistance && distance>=dangerDistance && !z_isdead){
            transform.LookAt(Player.position);
            z_controller.Move(transform.forward*z_speed*Time.deltaTime);
        }else if(distance > maxDistance){
            //z_anim.SetBool("z_attack", true);
            z_anim.SetBool("z_dead", true);
            z_isdead = true;
        }else if(distance < dangerDistance){
            z_anim.SetBool("z_attack", true);
        }
    }
}
