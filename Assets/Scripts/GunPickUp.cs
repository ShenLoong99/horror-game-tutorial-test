using StarterAssets;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class GunPickUp : MonoBehaviour
{
    [SerializeField] bool canPick;
    [SerializeField] GameObject textOnScreen;
    [SerializeField] GameObject tableCandle;
    [SerializeField] GameObject handCandle;
    [SerializeField] GameObject handGun;
    [SerializeField] GameObject tableGun;

    void Update()
    {
        if (canPick == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                this.GetComponent<BoxCollider>().enabled = false;
                // Drop candle
                handCandle.SetActive(false);
                tableCandle.SetActive(true);
                // Pick up gun
                tableGun.SetActive(false);
                handGun.SetActive(true);
            }
        }
    }

    void OnMouseOver()
    {
        if (PlayerCasting.distanceFromTarget < 5)
        {
            canPick = true;
            UIController.actionText = "Handgun";
            UIController.commandText = "Pick Up";
            UIController.uiActive = true;
        }
        else
        {
            canPick = false;
            UIController.actionText = "";
            UIController.commandText = "";
            UIController.uiActive = false;
        }
    }

    void OnMouseExit()
    {
        canPick = false;
        UIController.actionText = "";
        UIController.commandText = "";
        UIController.uiActive = false;
    }
}
