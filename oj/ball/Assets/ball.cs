using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour
{ //멤버변수
    float startingPoint;
    bool shouldprintover20 = true;
    bool shouldprintover30 = true;
    // Use this for initialization
    void Start()
    {
        Debug.Log("Start");
        startingPoint = transform.position.z;

        // Update is called once per frame
    }
    void Update()
    {
            float distance;
            distance = transform.position.z - startingPoint;
        if (distance > 30) 
        {
            if (shouldprintover30)
            {
                Debug.Log("over 30:" + distance);
                shouldprintover30 = false;
            }
            
        }
        else if (distance > 20)
        {
            if (shouldprintover20)
            {
                Debug.Log("over 20:" + distance);
                shouldprintover20 = false;
            }
            
        }
       
    }             

   
}
