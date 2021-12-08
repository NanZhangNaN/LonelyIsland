using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
	public Transform PlayerTrans;
	private Vector3 cameraPos;
    // Start is called before the first frame update
    void Start()
    {
        cameraPos = new Vector3(0,3,-10);
        Vector3 pos = PlayerTrans.TransformDirection(cameraPos);
        transform.position = PlayerTrans.position + pos;
        transform.LookAt(PlayerTrans.position);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)){
        	float y = Input.GetAxis("Mouse Y");
        	transform.RotateAround(PlayerTrans.position, transform.right, -y);
        	float x = Input.GetAxis("Mouse X");
        	transform.RotateAround(PlayerTrans.position, transform.up, x);
        }
        if(Input.GetMouseButtonUp(0)){
        	cameraPos = new Vector3(0,3,-10);
	        Vector3 pos = PlayerTrans.TransformDirection(cameraPos);
	        transform.position = PlayerTrans.position + pos;
	        transform.LookAt(PlayerTrans.position);
        }

        float viewDistance = -Input.GetAxis("Mouse ScrollWheel")*2;
        Vector3 viewDist = viewDistance*(transform.position - PlayerTrans.position).normalized;
        //Vector3.Distance(transform.position, PlayerTrans.position);
        transform.position += viewDist;
    }
}
