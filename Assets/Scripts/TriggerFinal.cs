using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TriggerFinal : MonoBehaviour
{
    [SerializeField] Image imagen;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            imagen.color = new Color(0, 0, 0, 1);
            StartCoroutine(Die());
        }
    }

    IEnumerator Die()
    {
        yield return new WaitForSeconds(1f);
        Application.Quit();
    }
}
