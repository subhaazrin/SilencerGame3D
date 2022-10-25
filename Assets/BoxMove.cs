using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMove : MonoBehaviour
{

    public Transform circleTransform;

    public float speed = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        circleTransform.position = new Vector3(circleTransform.position.x + (speed * Time.deltaTime) , 1f, -4f);
    }
}
