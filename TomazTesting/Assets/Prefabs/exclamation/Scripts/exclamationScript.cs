using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class exclamationScript : MonoBehaviour
{
    private bool runUpdate = false;

    // Update is called once per frame
    void Update()
    {
        if(runUpdate){
            Debug.Log("Running");



        }
    }

    //called when script is enabled
    void Trigger(){
        Debug.Log(name+" triggered");
        runUpdate= !runUpdate;
    }


    /*void Start()
    {
        GameObject myGO;
        GameObject myText;
        Canvas myCanvas;
        Text text;
        RectTransform rectTransform;

        // Canvas
        myGO = new GameObject();
        myGO.name = "TestCanvas";
        myGO.AddComponent<Canvas>();

        myCanvas = myGO.GetComponent<Canvas>();
        myCanvas.renderMode = RenderMode.ScreenSpaceOverlay;
        myGO.AddComponent<CanvasScaler>();
        myGO.AddComponent<GraphicRaycaster>();

        // Text
        myText = new GameObject();
        myText.transform.parent = myGO.transform;
        myText.name = "wibble";

        text = myText.AddComponent<Text>();
        text.font = (Font)Resources.Load("MyFont");
        text.text = "wobble";
        text.fontSize = 100;

        // Text position
        rectTransform = text.GetComponent<RectTransform>();
        rectTransform.localPosition = new Vector3(0, 0, 0);
        rectTransform.sizeDelta = new Vector2(400, 200);
    }*/
}
