using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;
using Normal.Realtime;

public class InteractableRequestOwnership : MonoBehaviour
{
    Grabbable grabbable;
    RealtimeTransform realtimeTransform;

    // Start is called before the first frame update
    void Start()
    {
        grabbable = GetComponent<Grabbable>();
        realtimeTransform = GetComponent<RealtimeTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(grabbable.SelectingPointsCount >= 1){
            //Request Ownership
            realtimeTransform.RequestOwnership();
        }
    }
}
