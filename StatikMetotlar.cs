using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatikMetotlar : MonoBehaviour
{
    public Transform baslang�cNoktas�;
    public Transform bitisNoktas�;
    public float baslang�cZaman�;
    public Transform Obje2Transformu;
     float aradakiMesafe;
    void Start()
    {/*
        Vector3 mesafe = Obje2Transformu.position - transform.position;
        float ac�salOran = Vector3.Angle(mesafe, transform.localPosition);  //�spector ekran�nda obje2 yi obje1 e ata... sonra cal�st�r
                                                                                //aradaki ac�y� verecek
        Debug.Log(ac�salOran);
        */
        /*
        aradakiMesafe = Vector3.Distance(Obje2Transformu.position, transform.position);
        Debug.Log(aradakiMesafe);
        */
        baslang�cZaman� = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        /*     //objeyi belirlenen konuma g�nderme
        Time.timeScale = 1f;
        transform.position = Vector3.Lerp(baslang�cNoktas�.position, bitisNoktas�.position, (Time.time - baslang�cZaman�)*0.5f);
        */
        //
        
    }
}
