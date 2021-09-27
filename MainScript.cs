using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript
{
    float hp; // здоровье у игрока
    string clan; // фракция
    float speed;

    float CCP; // CCP(сombat capability points) / ОБ(очки боеспособности)

    float damage; //урон у оружия
    float range; // дальность
    float accuracy; // точность
    float scatter; // разброс
    float fireRate; //скорострельность

    float ammo; //всего патронов
    float[] ammoInClip; //патроны в каждой обойме
    float lockingTimeClip; // на сколько блокируются обоймы
    float impactForce; // "сила" стрельбы

}
