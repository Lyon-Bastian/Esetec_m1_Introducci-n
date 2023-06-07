using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int velocidad;
    CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        //puntuacion = 10;
        gameObject.name = "Billy";
        //gameObject.SetActive(false);
        Debug.Log (gameObject.name);
       // Debug.Log (gameObject.transform.position);
        Debug.Log ("Hola Mundo");
        //Debug.Log (gameObject.transform.rotation);
        //Debug.Log (gameObject.transform.localScale);

        Debug.Log(gameObject.GetComponent<Transform>().position);
        Debug.Log(gameObject.GetComponent<Player>().enabled);
        //gameObject.GetComponent<Player>().gameObject.SetActive(false);
        //Debug.Log(gameObject.GetComponent<Player>().gameObject.transform.name);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Hola Mundo cruel");
        //Debug.Log (gameObject.transform.position);

        float horizontal = Input.GetAxis("Horizontal");
        Debug.Log(horizontal);
        float vertical = Input.GetAxis("Vertical");
        Debug.Log(vertical);

        Vector3 direction = new Vector3(horizontal, 0, vertical);
        
        controller.Move(direction * Time.deltaTime * velocidad);
    }
}
