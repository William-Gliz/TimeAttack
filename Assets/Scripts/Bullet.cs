﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private Transform target;

    public float speed = 60f;

    public GameObject impactEffect;

    public void Seek(Transform _target)
    {
        target = _target;
    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        // 
        if (dir.magnitude <= distanceThisFrame)  // Distance até o alvo é menor que a distancia percorrida (Já acertei o alvo)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);

    }

    void HitTarget()
    {
        GameObject effectIns =  Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(gameObject);
        Destroy(target.gameObject);
        Destroy(effectIns, 2f);
        
    }

}
