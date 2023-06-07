using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int velocidad;
    public int vida;
    public float valorGravedad = 9.81f;
    CharacterController controller;
    public TextMeshProUGUI vidaTexto;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        //puntuacion = 10;
        //gameObject.name = "Billy";
        //gameObject.SetActive(false);
        //Debug.Log (gameObject.name);
        //Debug.Log (gameObject.transform.position);
        //Debug.Log ("Hola Mundo");
        //Debug.Log (gameObject.transform.rotation);
        //Debug.Log (gameObject.transform.localScale);

        Debug.Log(gameObject.GetComponent<Transform>().position);
        //Debug.Log(gameObject.GetComponent<Player>().enabled);
        //gameObject.GetComponent<Player>().gameObject.SetActive(false);
        //Debug.Log(gameObject.GetComponent<Player>().gameObject.transform.name);
    }

    // Update is called once per frame
    public void Update()
    {
        Movement();
    }

    public void Movement()
    {
        //Debug.Log("Hola Mundo cruel");
        //Debug.Log (gameObject.transform.position);

        float horizontal = Input.GetAxis("Horizontal");
        //Debug.Log(horizontal);
        float vertical = Input.GetAxis("Vertical");
        //Debug.Log(vertical);

        Vector3 direction = new Vector3(horizontal, 0, vertical);
        direction.y = direction.y - valorGravedad;
        //direction.y -= valorGravedad;

        //Saltar
        if (Input.GetButton("Jump"))
        {
            direction.y = 15;
        }

        controller.Move(direction * Time.deltaTime * velocidad);        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger " + other.name);
        
        if (other.tag == "Explosive")
        {
            vida = vida - 1; //Resta 1 vida a las vidas actuales (me da vergüenza saber que tuve que esperar a que me lo dijeran D=)
            //vida -= 1;
            //vida--;
            other.gameObject.SetActive(false);
            vidaTexto.text ="Vida: " + vida.ToString();
        }

        if (other.tag == "Food")
        {
            vida++;
            other.gameObject.SetActive(false);
            vidaTexto.text = "Vida: " + vida.ToString();
        }
    }   


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");
    }
}
