using UnityEngine;
using static PooScript;

public class Monster : MonoBehaviour 
{
    // Crear clase de enemigos

    //CREAR UN METODO
    void Attack()
    {
        print("Estoy siendo atacado");
    }

    void Escape()
    {
        print("Estoy escapando");
    }
}
public class FlyingMonster: Monster 
    {
    void FlyingAttack()
    {
        print("Estoy siendo atacado con ataque volador");
    }

    //ATRIBUTOS
    string name;
        int life;
        int force;
        int attack;
        int scape;
    int flyingattack;

       
    void Start()
    {
        //INSTANCIAR UN OBJETO
        Monster monster1 = new Monster();
        monster1.name = "mettaton";
        monster1.life = 8;
        monster1.force = 10;
        monster1.Attack();
        monster1.Escape();
        FlyingMonster monster2 = new FlyingMonster();
        monster2.name = "chilldrake";
        monster2.life = 12;
        monster2.force = 7;
        monster2.Attack();
        monster2.Escape();
        monster2.FlyingAttack();
        Monster monster3 = new Monster();
        monster3.name = "migospel";
        monster3.life = 5;
        monster3.force = 15;
        monster3.Attack();
        monster3.Escape();
    }
   




}
