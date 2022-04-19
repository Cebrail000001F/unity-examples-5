using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatikMetotlar : MonoBehaviour
{
    public Transform baslangýcNoktasý;
    public Transform bitisNoktasý;
    public float baslangýcZamaný;
    public Transform Obje2Transformu;
     float aradakiMesafe;
    void Start()
    {/*
        Vector3 mesafe = Obje2Transformu.position - transform.position;
        float acýsalOran = Vector3.Angle(mesafe, transform.localPosition);  //ýspector ekranýnda obje2 yi obje1 e ata... sonra calýstýr
                                                                                //aradaki acýyý verecek
        Debug.Log(acýsalOran);
        */
        /*
        aradakiMesafe = Vector3.Distance(Obje2Transformu.position, transform.position);
        Debug.Log(aradakiMesafe);
        */
        baslangýcZamaný = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        /*     //objeyi belirlenen konuma gönderme
        Time.timeScale = 1f;
        transform.position = Vector3.Lerp(baslangýcNoktasý.position, bitisNoktasý.position, (Time.time - baslangýcZamaný)*0.5f);
        */
        //
        
    }
}
