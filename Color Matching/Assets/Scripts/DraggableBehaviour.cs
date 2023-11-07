using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class DraggableBehaviour : MonoBehaviour
{
    private Camera camereObj;
    public bool draggable;
    public Vector3 position, offset;
    public UnityEvent startDragEvent, endDragEvent;
    
    void Start()
    {
        camereObj = Camera.main;
    }
    
    public IEnumerator OnMouseDown()
    {
        offset = transform.position - camereObj.ScreenToWorldPoint(Input.mousePosition);
        draggable = true;
        startDragEvent.Invoke();
        yield return new WaitForFixedUpdate();

        while (draggable)
        {
            yield return new WaitForFixedUpdate();
            position = camereObj.ScreenToWorldPoint(Input.mousePosition) + offset;
            transform.position = position;
        }
    }

    private void OnMouseUp()
    {
        draggable = false;
        endDragEvent.Invoke();
    }
}
