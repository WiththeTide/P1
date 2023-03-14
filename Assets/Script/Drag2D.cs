using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Drag2D : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 startPos;
    //public Transform[] tempPosArr = new Transform[9];
    public Transform[] dragPos = new Transform[8];
    public Transform[] dragPosSave = new Transform[6];
    public bool test = true;
    private void Start()
    {
        GameStage.drag = true;
        startPos = transform.position;
    }
    private void Update()
    {
        // Debug.Log(Input.mousePosition.x + ", " + Input.mousePosition.y + "," + Input.mousePosition.z);
    }

    private void OnMouseDrag()
    {
        if (GameStage.drag)
        {
            transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, -2);

        }
        else if (!GameStage.drag)
        {
            return;
        }
    }
  
    private void OnMouseUp()
    {
        if (Mathf.Abs(transform.position.x - dragPos[0].position.x) + Mathf.Abs(transform.position.y - dragPos[0].position.y) <= 1)
        {
            //Debug.Log("enter");
            transform.position = dragPos[0].position;
        }
        else if (Mathf.Abs(transform.position.x - dragPos[1].position.x) + Mathf.Abs(transform.position.y - dragPos[1].position.y) <= 1)
        {
            //Debug.Log("enter");
            transform.position = dragPos[1].position;

        }
        else if (Mathf.Abs(transform.position.x - dragPos[2].position.x) + Mathf.Abs(transform.position.y - dragPos[2].position.y) <= 1)
        {
            //Debug.Log("enter");
            transform.position = dragPos[2].position;

        }
        else if (Mathf.Abs(transform.position.x - dragPos[3].position.x) + Mathf.Abs(transform.position.y - dragPos[3].position.y) <= 1)
        {
            //Debug.Log("enter");
            transform.position = dragPos[3].position;

        }
        else if (Mathf.Abs(transform.position.x - dragPos[4].position.x) + Mathf.Abs(transform.position.y - dragPos[4].position.y) <= 1)
        {
            //Debug.Log("enter");
            transform.position = dragPos[4].position;

        }
        else if (Mathf.Abs(transform.position.x - dragPos[5].position.x) + Mathf.Abs(transform.position.y - dragPos[5].position.y) <= 1)
        {
            //Debug.Log("enter");
            transform.position = dragPos[5].position;

        }
        else if (Mathf.Abs(transform.position.x - dragPos[6].position.x) + Mathf.Abs(transform.position.y - dragPos[6].position.y) <= 1)
        {
            //Debug.Log("enter");
            transform.position = dragPos[6].position;

        }
        else if (Mathf.Abs(transform.position.x - dragPos[7].position.x) + Mathf.Abs(transform.position.y - dragPos[7].position.y) <= 1)
        {
            //Debug.Log("enter");
            transform.position = dragPos[7].position;

        }
        else
        {
            transform.position = startPos;
        }
        /*  for (int i = 0; i < dragPosSave.Length; i++)
          {
              Debug.Log("test");
              for (int j = 0; j < dragPos.Length; j++)
              {

                  if (Mathf.Abs(dragPosSave[i].position.x - dragPos[j].position.x) + Mathf.Abs(dragPosSave[i].position.y - dragPos[j].position.y) <= 1)
                  {
                      dragPosSave[i].position = dragPos[j].position;
                      break;
                  }
                  transform.position = startPos;
              }

          }*/
        posCompare();

    }

    void posCompare() 
    {
     /*   if (dragPosSave[0].position == dragPosSave[1].position 
            || dragPosSave[0].position == dragPosSave[2].position 
            || dragPosSave[0].position == dragPosSave[3].position
            || dragPosSave[0].position == dragPosSave[4].position) 
        {
            transform.position = startPos;
        }
        else if (dragPosSave[1].position == dragPosSave[2].position
          || dragPosSave[1].position == dragPosSave[3].position
          || dragPosSave[1].position == dragPosSave[4].position)
        {
            transform.position = startPos;
        }
        else if (dragPosSave[2].position == dragPosSave[3].position
          || dragPosSave[2].position == dragPosSave[4].position)
        {
            transform.position = startPos;
        }
        else if (dragPosSave[3].position == dragPosSave[4].position)
        {
            transform.position = startPos;
        }*/

        for (int i = 0; i < dragPosSave.Length - 1; i++) 
        {
            for (int j = i; j < dragPosSave.Length - 1; j++) 
            {
                if (dragPosSave[i].position == dragPosSave[j + 1].position)
                {
                    transform.position = startPos;
                }
            }
            
        }
    }
}
