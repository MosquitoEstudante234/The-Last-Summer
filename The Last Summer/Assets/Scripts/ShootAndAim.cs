using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAndAim : MonoBehaviour
{
    public Transform firePoint, firePoint2, firePoint3;
    public GameObject bulletPrefab;
    public int bulletsGun = 5;
    public GameObject balas1, balas2, balas3, balas4, balas5;
    public float bulletCooldown = 0.5f;
    private float lastFireTime;

    public void Start()
    {
        reload();
    }
    void Update()
    {

        if (Input.GetButtonDown("Fire1") && bulletsGun >= 1)
        {
            
        }
        if (Input.GetButtonDown("Fire1"))
        {

            float timeSinceLastFire = Time.time - lastFireTime;

            if (timeSinceLastFire > +bulletCooldown)
            {
                Shoot();

                lastFireTime = Time.time;
                StartCoroutine(reload());
                bulletsGun--;
            }
            
            
        }
        if (bulletsGun == 0)
        {
            bulletPrefab.SetActive(false);
        }
        if (bulletsGun < 0)
        {
            bulletsGun = 0;
        }
        print(bulletsGun);

        if (bulletsGun == 0)
        {
            balas1.SetActive(false);
            balas2.SetActive(false);
            balas3.SetActive(false);
            balas4.SetActive(false);
            balas5.SetActive(false);
        }
        if (bulletsGun == 1)
        {
            balas1.SetActive(true);
            balas2.SetActive(false);
            balas3.SetActive(false);
            balas4.SetActive(false);
            balas5.SetActive(false);
        }
        if (bulletsGun == 2)
        {
            balas1.SetActive(true);
            balas2.SetActive(true);
            balas3.SetActive(false);
            balas4.SetActive(false);
            balas5.SetActive(false);
        }
        if (bulletsGun == 3)
        {
            balas1.SetActive(true);
            balas2.SetActive(true);
            balas3.SetActive(true);
            balas4.SetActive(false);
            balas5.SetActive(false);
        }
        if (bulletsGun == 4)
        {
            balas1.SetActive(true);
            balas2.SetActive(true);
            balas3.SetActive(true);
            balas4.SetActive(true);
            balas5.SetActive(false);
        }
        if (bulletsGun == 5)
        {
            balas5.SetActive(true);
            balas4.SetActive(true);
            balas3.SetActive(true);
            balas2.SetActive(true);
            balas1.SetActive(true);
        }
    }
    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Instantiate(bulletPrefab, firePoint2.position, firePoint2.rotation);
        Instantiate(bulletPrefab, firePoint3.position, firePoint3.rotation);

    }
    IEnumerator reload()
    {
        if (bulletsGun == 1)
        {
            yield return new WaitForSeconds(2);
            bulletsGun = bulletsGun + 5;
            bulletPrefab.SetActive(true);
            balas1.SetActive(false); balas2.SetActive(false); balas3.SetActive(false); balas4.SetActive(false); balas5.SetActive(false);
        }
    }
}
