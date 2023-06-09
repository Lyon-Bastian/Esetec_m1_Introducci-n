using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int velocidad;
    public int vida; //esto añade el parametro "Vida" al inspector del personaje.
    public float valorGravedad = 9.81f;
    CharacterController controller;
    public TextMeshProUGUI vidaTexto;
    public TextMeshProUGUI tiempoTexto;
    public GameObject comidaPrefab;
    public GameObject bombaPrefab;
    private Vector3 posicionInicialPlayer;

    //Contador
    float contadorSegundos = 0.0f;
    int tiempoCrearComida = 10;
    int tiempoCrearBomba = 5;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        posicionInicialPlayer = gameObject.transform.position;
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
        DebajoDelSuelo();
        Contador();
        crearComida();
        crearBomba();
    }

    public void crearComida()
    {
        if (contadorSegundos > tiempoCrearComida)
        {
            Debug.Log("Crear Comida");
            tiempoCrearComida = tiempoCrearComida + 10;

            int x = UnityEngine.Random.Range(-40, 40);
            int z = UnityEngine.Random.Range(-40, 40);
            int y = UnityEngine.Random.Range(1, 4);

            Vector3 nuevaPosicion = new Vector3(x, y, z);
            Instantiate(comidaPrefab, nuevaPosicion, Quaternion.identity);
        }
    }

    public void crearBomba()
    {
        if (contadorSegundos > tiempoCrearBomba)
        {
            Debug.Log("Crear bomba");
            tiempoCrearBomba = tiempoCrearBomba + 5;

            int x = UnityEngine.Random.Range(-40, 40);
            int z = UnityEngine.Random.Range(-40, 40);
            int y = UnityEngine.Random.Range(1, 4);

            Vector3 nuevaPosicion = new Vector3(x, y, z);
            Instantiate(bombaPrefab, nuevaPosicion, Quaternion.identity);
        }
    }
    public void Contador()
    {
        //El tiempo en segundos que tardó en completarse el último Frame
        
        contadorSegundos += Time.deltaTime;        
        tiempoTexto.text = "Tiempo: " + Convert.ToInt32(contadorSegundos).ToString();
    }

    public void DebajoDelSuelo()
    {
        //gameObject.GetComponent<Transform>().position.y
        if (gameObject.transform.position.y < 0)
        {
            //gameObject.transform.position = new Vector3(-14f, 1f, -4f);
            gameObject.transform.position = posicionInicialPlayer;
            vida--;
            vidaTexto.text = "Vida: " + vida.ToString();
        }
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
        if (Input.GetButton("Jump")) //"Jump" está asociado en Unity a la tecla espacio por defecto.
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
            other.gameObject.SetActive(false); //Esto hace desaparecer el objeto una vez es tocado
            gameObject.GetComponent<AudioSource>().Play();
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
