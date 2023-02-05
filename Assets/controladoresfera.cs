using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controladoresfera : MonoBehaviour {

    public float speed;
    private int count;
    public Text text;

    private void Start() {
     count = 0;    
     text.text = "Puntitos = 0";
    }

   void FixedUpdate() {
    float horizontal = Input.GetAxis("Horizontal");
    float vertical = Input.GetAxis("Vertical");

    Vector3 direction = new Vector3(horizontal, 0, vertical);

    GetComponent<Rigidbody>().AddForce(direction * speed);
   }

    void OnTriggerEnter(Collider other) {
    if(other.tag == "pickup"){
        Destroy(other.gameObject);
        count++;
        text.text = "Puntitos: " + count;

    }
   }
}
