using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Weapon myWeapon;

    public Weapon weapon;

    private Enemy myEnemy;


    public Player()
    {
        weapon = new Weapon("Random", 500); // 아무것도 넣지 않으면 기본 사양으로 출력됨
    }

    public Player(string weaponName, int weaponDamage)
    {
        weapon = new Weapon(weaponName, weaponDamage);
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Player's weapon : " + weapon.name + ", with damage : " + weapon.damage);

        myEnemy = new Zombie();
        myEnemy.Die();

        myWeapon = new Sword();
        myWeapon.Attack();

        myWeapon = new Bow();
        myWeapon.Attack();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
