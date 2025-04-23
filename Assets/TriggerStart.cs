using TMPro;
using UnityEngine;

public class TriggerStart : MonoBehaviour
{
    [SerializeField]
    private TMP_Text text;
    [SerializeField]
    private TMP_Text finalText;
    [SerializeField]
    private GameObject finalPanel;
    private bool started = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (started == false)
            {
                started = true;
                text.gameObject.SetActive(true);
                foreach(Crystal crystal in ClipSetter.Instance.crystalList) { crystal.gameObject.SetActive(true); }
                ClipSetter.Instance.StartCrystals();
            }

            if(started == true) 
            { 
                if(Crystal.found >= 4) 
                {
                    finalPanel.SetActive(true);
                    if (ClipSetter.Instance.lost == false)
                    {
                        finalText.text = "You escaped";
                        finalText.color = Color.green;
                    }
                    else 
                    {
                        finalText.text = "YOU MESSED WITH THE WRONG SOUL";
                        finalText.color = Color.red;
                    }
                    
                }
            }
        }
    }
}
