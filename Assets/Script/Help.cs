using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Help : MonoBehaviour
{
    public GameObject help1;
    public GameObject help2;
    // Start is called before the first frame update
    void Start()
    {
        help1.SetActive(false);
        help2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("h"))
        {
            //print("h key was pressed");
            help1.SetActive(true);
            help2.SetActive(true);
        }
        else if(Input.GetKeyUp("h"))
        {
            help1.SetActive(false);
            help2.SetActive(false);
        }
    }
}
