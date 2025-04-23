using System.Collections.Generic;
using UnityEngine;

public class ClipSetter : MonoBehaviour
{
    public static ClipSetter Instance { get; private set; }

    
    public List<Crystal> crystalList;
    [SerializeField]
    private AudioClip goodClip;
    [SerializeField]
    private AudioClip badClip;

    public bool lost = false;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject); // Evita duplicados
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject); // Opcional: mantiene el objeto entre escenas
    }
    public void StartCrystals()
    {
        int randomnum = Random.Range(0, crystalList.Count);
        Debug.Log(randomnum);
        for (int i = 0; i < crystalList.Count; i++) { 
            if (i==randomnum) 
            {
                crystalList[i].AudioSource.clip = badClip;
                crystalList[i].AudioSource.Play();
                crystalList[i].IsGood = false;
            } else
            {
                crystalList[i].AudioSource.clip = goodClip;
                crystalList[i].AudioSource.Play();
                crystalList[i].IsGood = true;  
            }
        }
    }
}
