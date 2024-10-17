using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject spherePrefab; 
    public Transform shootingPoint; 
    private Animator animator; 

    public float sphereSpeed; 

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootFlamingSphere();
        }
    }

    void ShootFlamingSphere()
    {
        animator.SetTrigger("ShootTrigger");

        GameObject newSphere = Instantiate(spherePrefab, shootingPoint.position, shootingPoint.rotation);
        Rigidbody rb = newSphere.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = shootingPoint.forward * sphereSpeed; 
        }
        Destroy(newSphere, 5f);
    }
}
