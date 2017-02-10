using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firefly_Movement : MonoBehaviour {


    
    public float smoothTime = 0.1F;
    private Vector3 velocity = Vector3.zero;

    public float bounceStrength = 0.01f;
    public float bounceSpeed = 2f;



    void Start() {

    }

    RaycastHit hit;
    void moveToMouse() {
        Vector3 mouse = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mouse);
            
        if (Physics.Raycast(castPoint, out hit, Mathf.Infinity)) {
            Vector3 targetPosition = hit.point;
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        }
        //transform.position = new Vector3 (  transform.position.x + ((float)Mathf.Cos(Time.time * bounceSpeed * Random.Range(0,10) ) * bounceStrength),transform.position.y + ((float)Mathf.Sin(Time.time * bounceSpeed * Random.Range(0,10) ) * bounceStrength), transform.position.z);
    }

    void Update() {
        moveToMouse();
    }
}
