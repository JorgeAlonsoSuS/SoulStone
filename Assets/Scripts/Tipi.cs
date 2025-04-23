using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Tipi : MonoBehaviour
{
    [SerializeField]
    private Transform tipito;
    [SerializeField]
    private GameObject tepeadol;
    [SerializeField] private AudioSource SFX;
    [SerializeField] AudioClip audioclip;


    private void OnTriggerExit(Collider other)
    {   
        if(other.gameObject.tag == "Player")
        {
            tepeadol.GetComponent<CharacterController>().enabled = false;
            tepeadol.transform.position = tipito.position;
            tepeadol.transform.rotation = tipito.rotation;
            tepeadol.GetComponent<CharacterController>().enabled = true;
            SFX.PlayOneShot(audioclip);

            
        }

    }
    
    private IEnumerable DeactivateCC()
    {
        tepeadol.GetComponent<CharacterController>().enabled = false;
        yield return new WaitForSeconds(0.5f);
        tepeadol.GetComponent<CharacterController>().enabled = true;
    }
}
