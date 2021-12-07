using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swithcing : MonoBehaviour
{
    public int SelectWeapon = 0;


    void Start()
    {
        Select();
    }

    // Update is called once per frame
    void Update()
    {
        int prev = SelectWeapon;

        if(Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if(SelectWeapon >= transform.childCount -1)
                SelectWeapon = 0;
            else 
                SelectWeapon++;
        }
        
        if(Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if(SelectWeapon <= 0)
                SelectWeapon = transform.childCount -1;
            else 
                SelectWeapon--;
        }

        if(prev != SelectWeapon)
            Select();
    }

    void Select()
    {
        int i = 0;
        foreach(Transform weapon in transform)
        {
            if(i == SelectWeapon)
                weapon.gameObject.SetActive(true);
            else 
                weapon.gameObject.SetActive(false);
            
            i++;
        }
    }
}
