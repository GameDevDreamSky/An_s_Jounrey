using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firingPoint;
    //[Range(0.1f,1f)]
    //[SerializeField] private float fireRate = 0.5f;

    public void Tire()
    {
            Instantiate(bulletPrefab, firingPoint.position, firingPoint.rotation);
    }
}
