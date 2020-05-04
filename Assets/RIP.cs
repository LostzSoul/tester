using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RIP : MonoBehaviour
{
    // Start is called before the first frame update


    public GameObject goalGameObject;
    
    private void OnMouseDrag()
    {
        
        Vector3 mouse =  Input.mousePosition;
        mouse.z = transform.position.z - Camera.main.transform.position.z;
        mouse = Camera.main.ScreenToWorldPoint(mouse);
        transform.position = new Vector3(mouse.x,mouse.y,mouse.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.Equals(goalGameObject) )
        {
            Debug.Log("win");
        }

    }

}
