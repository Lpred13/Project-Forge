using System;
using UnityEngine;

public class Joueur : MonoBehaviour
{
    public float vitesse;
    public GameObject projectile;
    public GameObject point;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, vitesse, 0);
            
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(vitesse, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, vitesse, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(vitesse, 0, 0);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SpawnProjectiles();
        }

    }

    public void SpawnProjectiles()
    {
        Instantiate(projectile, point.transform.position, Quaternion.identity);
       
    }


}
