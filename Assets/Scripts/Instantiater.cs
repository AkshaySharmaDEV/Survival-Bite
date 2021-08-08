using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;
using System;


public class Instantiater : MonoBehaviour
{

  

    


    public Material SkinMaterial;
   


    public Color Skin1;
    public Color Skin2;
    public Color Skin3;
    public Color Skin4;
    public Color Skin5;
    public Color Skin6;
    public Color Skin7;
    


    void Start()
    {

        
        
    }

    // Update is called once per frame
    

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void SkinOne()
    {

        SkinMaterial.color = Skin1;

    }

    public void SkinOne2()
    {

        SkinMaterial.color = Skin2;

    }

    public void SkinOne3()
    {

        SkinMaterial.color = Skin3;

    }

    public void SkinOne4()
    {

        SkinMaterial.color = Skin4;

    }

    public void SkinOne5()
    {

        SkinMaterial.color = Skin5;

    }

    public void SkinOne6()
    {

        SkinMaterial.color = Skin6;

    }

    public void SkinOne7()
    {

        SkinMaterial.color = Skin7;

    }

















}
