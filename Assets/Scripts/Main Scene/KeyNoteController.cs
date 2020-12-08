using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyNoteController : MonoBehaviour
{
    public AudioClip[] audioClips;
    public AudioSource audioSource;
    string keyName;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(ray, out raycastHit))
            {
                keyName = raycastHit.transform.name;
                switch (keyName)
                {
                    case "keyBoard":
                        audioSource.clip = audioClips[0];
                        audioSource.Play();
                        break;
                    case "keyBoard/black_01":
                        audioSource.clip = audioClips[0];
                        audioSource.Play();
                        break;
                    case "black_01":
                        audioSource.clip = audioClips[0];
                        audioSource.Play();
                        break;
                    case "keyBoard/white_01":
                        audioSource.clip = audioClips[0];
                        audioSource.Play();
                        break;
                    case "white_01":
                        audioSource.clip = audioClips[0];
                        audioSource.Play();
                        break;
                    case "A":
                        audioSource.clip = audioClips[0];
                        audioSource.Play();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
