
using UnityEngine;
using UnityEngine.Events;

public class SimpleTriggerEventBehavor : MonoBehaviour
{
    public UnityEvent triggerEvent;

    private void OnTriggerEnter(Collider other)
    {
       // Trigger the event and test with a debug message
       triggerEvent.Invoke();
       Debug.Log("Player interacted with the object!"); 
    }       
}
