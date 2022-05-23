using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class exclamationScript : MonoBehaviour
{
    private bool runUpdate = false;
    Component[] canvasPopups;
    VideoPlayer video = null;
    GameObject returnObject = null;

    void Start(){
        //gets all canvases under the object
        canvasPopups = GetComponentsInChildren(typeof(Canvas));
        if(canvasPopups!=null){
            //Debug.Log(canvasPopups.Length);
            //sets all canvases to hidden, and saves if there is a videoplayer
            foreach (Canvas c in canvasPopups)
            {
                //Debug.Log(c);
                //Debug.Log(c.gameObject);//.SetActive(false);
                c.gameObject.SetActive(false);
                video = c.gameObject.GetComponentInChildren<VideoPlayer>();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(runUpdate){
            //Debug.Log(name + " running");
            if(video != null){
                //close video when it reaches the end
                if(video.isPaused){
                    foreach (Canvas c in canvasPopups){
                        c.gameObject.SetActive(false);
                        returnObject.BroadcastMessage("LockPlayer", false);
                    }
                }
            }
        }
    }

    //called when script is enabled
    void Trigger(GameObject returnObject){
        this.returnObject = returnObject;
        runUpdate= !runUpdate;

        //runs once when turned on
        if(runUpdate){
            //Debug.Log("Show Canvases");
            foreach (Canvas c in canvasPopups){
                c.gameObject.SetActive(true);
            }
            returnObject.BroadcastMessage("LockPlayer", true);
            returnObject.BroadcastMessage("SetLockObject", this.gameObject);
        }
        //runs once when disabled
        else{
            //Debug.Log("Hide Canvases");
            foreach (Canvas c in canvasPopups){
                c.gameObject.SetActive(false);
            }
            returnObject.BroadcastMessage("LockPlayer", false);
        }
    }



        
}
