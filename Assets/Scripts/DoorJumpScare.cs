using UnityEngine;

public class DoorJumpScare : MonoBehaviour
{
    [SerializeField] AudioSource pianoScare;
    [SerializeField] AudioSource doorSlam;
    [SerializeField] GameObject theDoor;
    [SerializeField] GameObject gunPickUp;

    void OnTriggerEnter(Collider other)
    {
        theDoor.GetComponent<Animator>().Play("JumpAnimDoor");
        pianoScare.Play();
        doorSlam.Play();
        gunPickUp.SetActive(true);
        this.GetComponent<BoxCollider>().enabled = false;
    }
}
