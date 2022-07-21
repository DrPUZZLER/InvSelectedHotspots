using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AC;

/*
 * This is a script written by Dr. Puzzler for Ptomaine
 * This will enable and disable a hotspot depending on whether or not a player is holding an item in the inventory
 * For the opposite effect, just swawp the methods so playerHotspot.TurnOn() is playerHotspot.TurnOff(), and vice versa
 */
public class InvSelectedHotspot : MonoBehaviour
{
     Hotspot playerHotspot;

    void Start() {
        playerHotspot = GetComponent<Hotspot>();
    }
    void Update()
    {
        if (AC.KickStarter.runtimeInventory.SelectedItem != null) {
                playerHotspot.TurnOn();
            
        } else if (AC.KickStarter.runtimeInventory.SelectedItem == null) {
                playerHotspot.TurnOff();
        }
    }
}
