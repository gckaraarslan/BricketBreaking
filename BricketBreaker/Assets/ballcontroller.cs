using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ballcontroller : MonoBehaviour
{

    public Rigidbody rbBall;
    //GameObject[] tuglalar;
    float hiz=0.5f;
    Vector3 startPos;
    int skor=0;

    void Start()
    {
        
        startPos=transform.position;
        startBall();
        
    }
void startBall()
{
    rbBall.velocity=Vector3.zero;
    transform.position=startPos;
    rbBall.velocity=new Vector3(hiz,0,hiz);
}
    // Update is called once per frame
  
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag=="tugla")
        {
            Destroy(other.gameObject);
            skor+=100;
            Debug.Log(skor);
            rbBall.velocity = new Vector3(rbBall.velocity.x, 0, -hiz);
            // ContactPoint dokunduguYuzey = other.contacts[0];  //çarptığı yüzeylerin ilki demek

            // if (dokunduguYuzey.normal == Vector3.right)
            // {
            //     rbBall.velocity = Vector3.zero;
            //     rbBall.velocity = new Vector3(-rbBall.velocity.x, 0, -hiz);
            // }
            // if (dokunduguYuzey.normal == Vector3.left)
            // {
            //     rbBall.velocity = Vector3.zero;
            //     rbBall.velocity = new Vector3(-rbBall.velocity.x, 0, -hiz);
            // }
            // if (dokunduguYuzey.normal == Vector3.back)
            // {
            //    rbBall.velocity = Vector3.zero;
            //     rbBall.velocity = new Vector3(-rbBall.velocity.x, 0, -rbBall.velocity.z);
            // }
            // if (dokunduguYuzey.normal == Vector3.forward)
            // {
            //     rbBall.velocity = Vector3.zero;
            //     rbBall.velocity = new Vector3(rbBall.velocity.x, 0, -hiz);
            // }


           

        }

        if (other.gameObject.tag=="solduvar")
        {
            rbBall.velocity=new Vector3(hiz,0,rbBall.velocity.z);
        }
        if (other.gameObject.tag == "sagduvar")
        {
            rbBall.velocity = new Vector3(-hiz, 0, rbBall.velocity.z);
        }
        if (other.gameObject.tag == "altduvar")
        {
            SceneManager.LoadScene(0);
            startBall();
        }
        if (other.gameObject.tag == "ustduvar")
        {
            rbBall.velocity = new Vector3(rbBall.velocity.x, 0, -rbBall.velocity.z);
            
        }


        if (other.gameObject.tag == "playerparent")
        
        {
            rbBall.velocity = new Vector3(rbBall.velocity.x, 0, -rbBall.velocity.z);


            // if(rbBall.velocity.x==0.0f)
            // {
            //     rbBall.velocity = new Vector3(hiz, 0, -rbBall.velocity.z);
            // }
            // else
            // {
            // rbBall.velocity = new Vector3(rbBall.velocity.x, 0, -rbBall.velocity.z);
            // }
           // --------------------------------------------
            // ContactPoint dokunduguYuzey = other.contacts[0];
            // if (dokunduguYuzey.normal == Vector3.forward)
            // {
            //     // rbBall.velocity = new Vector3(rbBall.velocity.x, 0, hiz);
            //     if(rbBall.velocity.x==0)
            //     {
            //         rbBall.velocity = new Vector3(hiz, 0, hiz);
            //     }
            //     else if(rbBall.velocity.x != 0)
            //     {
            //         rbBall.velocity = new Vector3(rbBall.velocity.x, 0, -rbBall.velocity.z);
            //     }
                
            // }
        }

        // if (other.gameObject.tag == "player2")

        // {
        //     rbBall.velocity = new Vector3(-hiz, 0, -rbBall.velocity.z);


        // }
        // if (other.gameObject.tag == "player3")

        // {
        //     rbBall.velocity = new Vector3(0, 0, -rbBall.velocity.z);


        // }
        // if (other.gameObject.tag == "player4")

        // {
        //     rbBall.velocity = new Vector3(hiz, 0, -rbBall.velocity.z);


        // }
        // if (other.gameObject.tag == "player4")

        // {
        //     rbBall.velocity = new Vector3(hiz, 0, -rbBall.velocity.z);


        // }
    }
}
