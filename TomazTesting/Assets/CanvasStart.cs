using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Used to show canvas when first loaded
//(programmer dosent need to worry about turning them all on)
public class CanvasStart : MonoBehaviour
{
    [Header("Canvas")]
	[Tooltip("Show the canvas when the game first starts")]
	public bool DisplayOnStart = true;


    // Start is called before the first frame update
    void Start()
    {
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.alpha = DisplayOnStart ? 1 : 0;
    }

}
