using UnityEngine;

public class TintinCorreCorre : MonoBehaviour
{
    [SerializeField]
    private Light light;
    [SerializeField]
    private Light luz1;
    [SerializeField] private Light luz2;
    [SerializeField] private AudioSource SFX;
    [SerializeField] AudioClip SFXClip;
    [SerializeField] AudioSource MainAudio;
    [SerializeField] AudioClip heartBeat;
    [SerializeField] GameObject mkina;
    [SerializeField] GameObject final;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            light.color = Color.red;
            luz1.gameObject.SetActive(true);
            luz2 .gameObject.SetActive(true);
            SFX.PlayOneShot(SFXClip);
            MainAudio.clip =  heartBeat;
            MainAudio.Play();
            mkina.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
            mkina.transform.position = new Vector3(-12.3780003f, 0.151f, -8.39099979f);
            final.SetActive(true);
            Destroy(gameObject);
        }
    }


}
