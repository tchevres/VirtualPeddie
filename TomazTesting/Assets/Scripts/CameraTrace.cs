using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrace : MonoBehaviour
{

    Ray RayOrigin;
    RaycastHit HitInfo;

    [Header("Ray Trace")]
	[Tooltip("Distance to cast the ray")]
	public float RayDistance = 100.0f;

    // Use this for initialization
    void Start () {
   
    }

    // Update is called once per frame
    void Update(){
        Look();

    }
   
    //call to detect where the player looks
    void Look () {
        Transform cameraTransform = Camera.main.transform;
        if(Physics.Raycast(cameraTransform.position,cameraTransform.forward, out HitInfo, RayDistance)){
            float dist = HitInfo.distance;
            Debug.DrawRay(cameraTransform.position, cameraTransform.forward * dist, Color.yellow);

            Debug.Log("looking " + dist);
            Trigger();
        }
        else{
            Debug.DrawRay(cameraTransform.position, cameraTransform.forward * RayDistance, Color.red);
            Debug.Log("no");
        }
    }

    void Trigger(){
        if(HitInfo.transform.CompareTag("Clickable")){
            HitInfo.transform.BroadcastMessage("Trigger");
        }
    }
}