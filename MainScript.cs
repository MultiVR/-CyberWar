using System;

[Serializable]
public class MainScript
{
    public string nickPlayer; // ник игрока
    public float hp; // здоровье у игрока
    public string clan; // фракция
    public float speed;

    public float CCP; // CCP(сombat capability points) / ОБ(очки боеспособности)

    public float damage; //урон у оружия
    public float range; // дальность
    public float accuracy; // точность
    public float scatter; // разброс
    public float fireRate; //скорострельность

    public float ammo; //всего патронов
    public float[] ammoInClip; //патроны в каждой обойме
    public float lockingTimeClip; // на сколько блокируются обоймы
    public float impactForce; // "сила" стрельбы

}
