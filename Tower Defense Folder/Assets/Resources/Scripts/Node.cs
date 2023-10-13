using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Node : MonoBehaviour
{

    public Color hoverColor;
    private Renderer rend;
    private Color startColor;
    public Vector3 positionOffset;

    public GameObject turret;

    private void OnMouseDown()
    {
        if (turret != null)
        {
            Debug.Log("We can't build here! TODO: Display on screen");
            return;
        } else
        {
            GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
            turret = (GameObject)Instantiate(turretToBuild,transform.position+ positionOffset, transform.rotation);
        }
    }

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }
    private void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }

    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
