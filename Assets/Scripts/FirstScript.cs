using UnityEditor.ShaderGraph.Legacy;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    //TIPOS DE VARIABLES
    //variable enter
    int entero = 2;
    //variable decimal
    float numerodecimal = 3.5f;
    //variable numero grande
    long largo = 4444444444444;
    //variable numeros decimales muy grandes
    double doble = 3.141592738484848758;
    //variable cadena de texto; 
    string comida = "hamburguesa";
    //variable caracter; 
    char letra = 'A';
    //variable booleana
    bool booleana = true;
    //Array
    public string[] array = { "zelda", "ganon", "link" };
    float[] floats = { 2.5f, 1.4f, 8.9f };

    //SUMA
    int myInt1 = 2;
    int myInt2 = 3;
    int suma;

    //UNIR DOS PALABRAS 

    string palabra1 = "mesa";
    string palabra2 = "flopa";
    string resultado;

    //TUS VIDAS SON DOS: 2

    string texto = "Tus vidas son: ";
    int myInt3 = 2;
    string resultado2;

    //OBJETO
    public GameObject miObjeto;

    //ATAJOS DE SUMA/RESTA

    int n1 = 2;
    int n2 = 3;
    int suma2;
    int resta;

    //IF ELSE CON OPERADORES RELACIONALES
    int myHealth = 3;
    //MAYOR QUE CERO, ESTAMOS VIVOS. MENOER QUE CERO, ESTAMOS MUERTOS



    private void Start()
    {
        Debug.Log(booleana);
        print(comida);
        Debug.Log(array);

        suma = myInt1 + myInt2;
        print(suma); 

        resultado = palabra1 + " " + palabra2;
        print(resultado);

        resultado = texto + myInt3;
        print(resultado);

        print(miObjeto);

   
        //SUMA DE PROGRAMADOR
        suma2 = n1 += n2;
        Debug.Log(suma2);
        //RESTA DE PROGRAMADOR
        resta = n1 -= n2; 
        Debug.Log(resta);

        //MAYOR QUE CERO, ESTAMOS VIVOS. MENOER QUE CERO, ESTAMOS MUERTOS
        if (myHealth > 0)
        {
            Debug.Log("Vivooo");
        }
        else {

            Debug.Log("muertooo");
        }


    }
}
