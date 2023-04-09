using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    float hiz=1f;
    
    // Start is called before the first frame update


    // Update is called once per frame
    void FixedUpdate()
    {
        oyuncuHareketi();

    }

    void oyuncuHareketi()
    {

        // float hareket = Input.GetAxis("Horizontal");
        // transform.Translate(hareket * hiz*Time.deltaTime, 0, 0);
        // float xPos = Mathf.Clamp(transform.position.x, -0.396f, 0.406f);
        // transform.position = new Vector3(xPos, transform.position.y, transform.position.z);


       float yönGirdisi = Input.GetAxis("Horizontal");   //saga bastığımda yön girdisi 1e eşit oluyor, sola bastığımda -1'e...hiç basmadığımda 0'a
        rb.velocity = (Vector3.right * hiz) * yönGirdisi;
        float xPos = Mathf.Clamp(transform.position.x, -0.396f, 0.406f);
        transform.position = new Vector3(xPos, transform.position.y,transform.position.z);
        
    }
    // public float speed = 0.2f; // topun hareket hızı

    // void Update()
    // {
    //     float moveHorizontal = Input.GetAxis("Horizontal"); // yatay hareket girdisi
    //     Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f); // hareket vektörü
    //     transform.position += movement * speed * Time.deltaTime; // nesneyi hareket ettir
    // }




}
