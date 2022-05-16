using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class exclamationScript : MonoBehaviour
{
    private bool runUpdate = false;
    Component[] canvasPopups;

    void Start(){
        canvasPopups = GetComponentsInChildren(typeof(Canvas));
        if(canvasPopups!=null){
            foreach (Canvas c in canvasPopups)
            {
                Debug.Log(c);
                Debug.Log(c.gameObject);//.SetActive(false);
                c.gameObject.SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(runUpdate){
            //Debug.Log("Running");
        }
    }

    //called when script is enabled
    void Trigger(GameObject returnObject){
        //Debug.Log(gameObject+" triggered");
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
