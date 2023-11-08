using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManger : MonoBehaviour
{

    public static MenuManger instance;

    [SerializeField] Menu[] menus;


     void Awake()
    {
        instance = this;   
    }

    public void OpenMenu(string menuName)
    {

        for (int i = 0; i < menus.Length; i++)
        {
            if (menus[i].menuName == menuName)
            {
                OpenMenu(menus[i]);

            }
            else if (menus[i].open)
            {
                CloseMenu(menus[i]);
            }

        }

    }


    public void OpenMenu(Menu menu)
    {
        for (int i = 0; i < menus.Length; i++)
        {
         
            if (menus[i].open)
            {
                CloseMenu(menus[i]);
            }

        }
        menu.Open();
       

    }

    public void CloseMenu(Menu menu)
    {
        menu.Close();


    }



}
