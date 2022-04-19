using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transform1 : MonoBehaviour
{
    Vector3 ali;
    public Transform aliTransform;
    public void Start()
    {


        // transform.Translate(new Vector3(3f, 5f, 4f));
        //transform.Translate(new Vector3(0f, 250f, 0f) * Time.deltaTime);
        /*
       Vector3 ayse = transform.position;
       float uzunluk = ayse.magnitude;     //objenin tum uzunlugunu toplar ve sonucu soyler
       Debug.Log(uzunluk);
        */
        /*
       Vector3 ali= new Vector3(1f, 2f, 5f);
       Vector3 ayse = new Vector3(6f, 0f, 3f);
       if (ali.sqrMagnitude > ayse.sqrMagnitude)                //hangisin vektorunun daha buyuk oldugunu soyler
           Debug.Log("alinin vektoru ayseden daha buyuk");
       else
           Debug.Log("aysenin vektoru aliden daha buyuk");
        */
        /*
        Vector3 veli = new Vector3(-50f, -60f, 10f);      // bu degerleri normal bir boyuta donusturur -1 ile 1 arasýnda bir yeni deger
                                                          //basit kesire donusturur denebilir
        Debug.Log(veli.normalized);
        */
        /*
        ali.Set(5f, 4f, 3f);
        transform.position = ali;        //yeni koordinatlar atamak
        Debug.Log(transform.position);
        */
        /*
        Vector3 ayse = new Vector3(5f, 4f, 2f);   //degerleri string yapar
        Debug.Log(ayse.ToString());
        */
        /*
        Vector3 ayse = new Vector3(5f, 5f, 5f);
        Vector3 ali = new Vector3(5f, 5f, 5f);
        if (ayse.Equals(ali))
        {
            Debug.Log("pozisyonlar esit");
        }
        else                                              //2 vektorun pozisyonlarýný karsýlastýrýr
        {
            Debug.Log("pozisyonlar esit degil");
        }
        */
       
    }

    
    void Update()
    {
        
    }
}
