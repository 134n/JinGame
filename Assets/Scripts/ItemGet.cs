using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGet : MonoBehaviour
{
    [SerializeField] private GameObject UiScript;
    [SerializeField] private int itemPrehabPoint;
    private int totalPoint;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            Destroy(other.gameObject);
            ItemPoint();
        }
    }

    public void ItemPoint()
    {
        totalPoint += itemPrehabPoint;
        UiScript.GetComponent<UI>().PointText(totalPoint);
    }

}
