using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionPlaceholder : MonoBehaviour
{
    public bool isOccupied;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="NumberObject")
        {


        }
    }
}
