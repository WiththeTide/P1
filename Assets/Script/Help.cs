using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Help : MonoBehaviour
{
    public GameObject help1;
    public GameObject help2;
    public GameObject help3;
    public Vector3 target1;
    public Vector3 target2;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        help1.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("h"))
        {
            Debug.Log(help1.transform.position.y);
            if (help1.transform.position.y > -1)
            {
              
                help1.transform.position = Vector3.Lerp(help1.transform.position, target2, Time.deltaTime * speed);
            }
        }

        else
        {
            if (help1.transform.position.y < 11)
            {
                help1.transform.position = Vector3.Lerp(help1.transform.position, target1, Time.deltaTime * speed);
            }
        }

        
    }
}
