using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class male : MonoBehaviour
{
    public float speed = 10;
    public float rotSpeed = 100;
    public double maxDistance = 8;
    public double farDistance = 7;
    public double dangerDistance = 1.31;
	public Animator m_anim;
	public CharacterController m_controller;
    public Transform Zombie;
    private bool z_isdead;
    private float lastTimeStamp = 0;

    // Start is called before the first frame update
    void Start()
    {
        m_anim = GetComponent<Animator>();
        m_controller = GetComponent<CharacterController>();
        z_isdead = false;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Vertical");
        float y = Input.GetAxis("Horizontal");
        Vector3 move = transform.right*x;
        float distance = Vector3.Distance(Zombie.position, transform.position);
        //print(distance);
        if(distance>=dangerDistance && !z_isdead){
            m_anim.SetFloat("m_speed", x);
            transform.Rotate(0, y*rotSpeed*Time.deltaTime, 0);
            if(x>0){
                m_controller.Move(transform.forward*x*speed*Time.deltaTime);
            }
        }else if(distance <= dangerDistance && !z_isdead){
            m_anim.SetFloat("m_speed", 0);
            m_anim.SetBool("m_dead", true);
        }else if(distance <= dangerDistance && z_isdead){
            m_anim.SetFloat("m_speed", 0);
            if (Time.time - lastTimeStamp >= 7f){
                lastTimeStamp = Time.time;
                m_anim.SetBool("m_dead", true);
            }  
        }else if(distance > maxDistance){
            z_isdead = true;
        }


    }
}
