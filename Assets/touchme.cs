using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;

public class touchme : MonoBehaviour
{
    public GameObject[] obj; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)

    //OnCollisionEnter(Collision collision)
    {
        //this.gameObject.SetActive(false);
        if (obj.Length > 0)
        {
            for(int i=0;i<obj.Length;i++)
            {
                obj[i].SetActive(true);
            }
        }
    }

    public void grabaciton()
   // void OnCollisionEnter(Collision collision)
        {
            this.gameObject.SetActive(false);
                if (obj.Length > 0)
                {
                    for (int i = 0; i < obj.Length; i++)
                    {
                        obj[i].SetActive(true);
                    }
                }
        }
    }

