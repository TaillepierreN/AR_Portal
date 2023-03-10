using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;

public class taptoplace : MonoBehaviour
{
    [SerializeField] Text debugText;
    [SerializeField] ARRaycastManager arRaycastManager;
    List<ARRaycastHit> hits= new List<ARRaycastHit>();
    Vector2 touchPosition;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        debugText.text = "application launched";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {

        touchPosition = Input.GetTouch(0).position;
        Debug.Log(touchPosition);
        debugText.text= touchPosition.ToString();
        if(arRaycastManager.Raycast(touchPosition,hits,TrackableType.PlaneWithinPolygon))
        {
            debugText.text = "true";
        }
        }

        
    }
}
