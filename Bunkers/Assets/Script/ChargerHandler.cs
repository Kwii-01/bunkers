﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChargerHandler : MonoBehaviour
{
    // public PlayerAction player;
    // public Text nbOfBullet;
    // public Text nbOfCharger;
    // public Image imageCharger;

    // void Update()
    // {
    //     if (player.inventory.weapons[0] != null)
    //     {
    //         int chargerNb = player.inventory.weapons[player.inventory.actualEquiped].transform.Find("Equiped").gameObject.GetComponent<range>().chargers.Count;
    //         if (chargerNb > 0)
    //         {
    //             nbOfCharger.text = chargerNb + "";
    //             nbOfBullet.text = player.inventory.weapons[player.inventory.actualEquiped].transform.Find("Equiped").gameObject.GetComponent<range>().chargers[0].gameObject.GetComponent<Charger>().actualNbOfBullets + "";
    //             imageCharger.color = new Color32(255, 255, 225, 255);
    //             imageCharger.sprite = player.inventory.weapons[player.inventory.actualEquiped].transform.Find("Equiped").gameObject.GetComponent<range>().chargers[0].GetComponent<SpriteRenderer>().sprite;
    //         }
    //         else if (imageCharger.sprite != null && nbOfCharger.text != "" && nbOfBullet.text != "0")
    //         {
    //             imageCharger.color = new Color32(255, 255, 225, 0);
    //             imageCharger.sprite = null;
    //             nbOfCharger.text = "";
    //             nbOfBullet.text = "0";
    //         }
    //     }
    // }
}