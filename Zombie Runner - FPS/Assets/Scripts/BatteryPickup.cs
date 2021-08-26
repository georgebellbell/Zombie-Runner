using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] float restoreAngle = 70f;
    [SerializeField] float addIntensity = 2.5f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            FlashLightSystem flashLight = other.gameObject.GetComponentInChildren<FlashLightSystem>();

            flashLight.RestoreLightAngle(restoreAngle);
            flashLight.AddLightIntensity(addIntensity);
            Destroy(gameObject);
        }

    }
}
