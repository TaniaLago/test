using UnityEngine;
using UnityEngine.Rendering;

public class PooScript : MonoBehaviour
{
    //CREANDO LA CLASE COCHE
    public class Coche
    {
        //CREAR ATRIBUTOS
        public string color = "gris";
        public string modelo = "delorean";
        bool encendido = false;
        //CREAR UN METODO
        public void Arrancar()
        {
            encendido = true;
        }
        //CREAR UN METODO PARA CAMBIAR EL COLOR DEL COCHE
        public void CambiarColor(string color)
        {
        }

    }
    //INSTANCIAR UN OBJETO
    Coche coche2 = new Coche(); 
   public void Start () 
    {
        //COMO CAMBIAR ATRIBUTO
        coche2.modelo = "seat panda";
        //ARRANCAR MI COCHE 2
        coche2.Arrancar();
        //CAMBIAR MI COCHE 2 A VERDE
        coche2.CambiarColor("verde");
    }
}
