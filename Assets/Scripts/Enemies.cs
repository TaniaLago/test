using UnityEngine;

public class Enemies : MonoBehaviour
{


    //crear clase enemigo volador, este tiene la posibilidad de volar

    public class FlyingEnemy : Enemy
    {
        void Volar()
        {
            Debug.Log("Voy a volar");
        }
    }
    // atrributos: vida, ataque, nombre, melee

    int vida;
    int ataque;
    string nombre;

    void Melee()
    {
        vida = vida - ataque; 
        print("Estoy haciendo una melee");
    }
    void Start()
    {
        Enemy enemy1 = new Enemy();
        enemy1.vida = 1;
        enemy1.nombre = "goomba";
        enemy1.ataque = 1; 
        FlyingEnemy enemy2 = new FlyingEnemy();
        enemy2.Volar();
        enemy2.vida = 3;
        enemy2.ataque = 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
