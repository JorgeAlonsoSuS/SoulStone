using TMPro;
using UnityEngine;

public class Crystal : MonoBehaviour
{   
    public static int found = 0;
    [SerializeField]
    private TMP_Text text;
    private AudioSource audioSource;
    public bool isGood;

    public AudioSource AudioSource { get => audioSource; set => audioSource = value; }
    public bool IsGood { get => isGood; set => isGood = value; }

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            found += 1;
            if(isGood == false)
            {
                ClipSetter.Instance.lost = true;
            }
            text.text = "Crystals Found: " + found;

            Destroy(gameObject);
        }
    }
}
