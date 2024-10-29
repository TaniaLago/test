using System.Diagnostics;
using UnityEngine;

public class SecondScript : MonoBehaviour
{
    int health = 3;

    //DOBLE CONDICION
    int level = 42;
    bool llave = false;

    //BUCLES 
    int num;

    //WHILE 
    int condicion = 3;

    //ESTRUCTURA CONTROL AVANZADA
    bool escudo;
    float impacto = 4;
    float energia = 5;

    //FUNCION
    void Saludar()
    {
        print("Buenas tardes, ya queda menos");
    }

    void SaludoPersonalizado(string saludo= "¿No dices nada?")
    {
        print(saludo);
    }
    //AMBITO DE LA VARIABLE
    string mensaje = "Animo";
    string mensajeLocal = "Hasta mañana chicos";

    void Hablar()
    {
        string mensaje = "¿Hola?";
        print(mensaje);

    }

    //SI MI NIVEL ES MAYOR QUE 20 O TENGO LLAVE "PUEDO ENTRAR EN LA DUNGEON". SI NO, "NO PUEDO"

    //DENTRO DE LOS METODOS ESCRIBIMOS LAS ESTRUCTURAS DE CONTROL 
    void Start()
    {

        //SCOPE O AMBITO 
        print(mensaje);
        Hablar();
        print(mensajeLocal);


        //INVOCAMOS LA FUNCION
        Saludar();
        SaludoPersonalizado("¿Que pasa pixa?");

        // ESTRUCTURA CONTROL AVANZADA

        if (impacto < energia && escudo == false )
        {
            energia -= impacto;
            Debug.Log("Tengo" + energia + "energia");
        }else if (escudo == true)
        {
            escudo = false;
            Debug.Log("No tengo escudo");
        }
        else
        {
            Debug.Log("Estoy muerto");
        }

        //VIDA 
        if (health > 0)
        {
            print("Estoy vivo");
        }
        else if (health < 0)
        {
            print("Estamos muertos");
        }
        else
        {
            print("Hola cesugers");
        }

        //DUNGEON
        if (level > 20 || llave)
        {
            print("Entrar a la dungeon");
        }
        else
        {
            print("No entrar a la dungeon");
        }

        //BUCLES FOR DE 0 A 9 
        for (int num = 0; num < 10; num++)
        {
            print(num);
        }

        //BUCLES DE 9 A 0 
        for (/*INICIO*/ int num = 9;
            /*FINAL*/ num >= 0;
            /*NUMERO QUE VA SUMADO*/ num--)
        {
            print(num);
        }

        //SWITCH 

        switch (level)
        {
            case 1:
                print("Somos novatos");
                break;
            case 10:
                print("Somos decentes");
                break;
            case 42:
                print("Somos profesionales");
                break;
            default:
                print("No somos nada");
                break;


        }
        //WHILE / DO 
        while (condicion < 5)
        {
            print("Hola");
            condicion++;
        }
    }



    void Update()
    {
        
    }
}
