using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyNoteController : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip[] blackAudioClips;
    public AudioClip[] whiteAudioClips;

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
                    //black
                    case "black_01":
                        audioSource.clip = blackAudioClips[0];
                        audioSource.Play();
                        break;
                    case "black_02":
                        audioSource.clip = blackAudioClips[1];
                        audioSource.Play();
                        break;
                    case "black_03":
                        audioSource.clip = blackAudioClips[2];
                        audioSource.Play();
                        break;
                    case "black_04":
                        audioSource.clip = blackAudioClips[3];
                        audioSource.Play();
                        break;
                    case "black_05":
                        audioSource.clip = blackAudioClips[4];
                        audioSource.Play();
                        break;
                    case "black_06":
                        audioSource.clip = blackAudioClips[5];
                        audioSource.Play();
                        break;
                    case "black_07":
                        audioSource.clip = blackAudioClips[6];
                        audioSource.Play();
                        break;
                    case "black_08":
                        audioSource.clip = blackAudioClips[7];
                        audioSource.Play();
                        break;
                    case "black_09":
                        audioSource.clip = blackAudioClips[8];
                        audioSource.Play();
                        break;
                    case "black_10":
                        audioSource.clip = blackAudioClips[9];
                        audioSource.Play();
                        break;
                    case "black_11":
                        audioSource.clip = blackAudioClips[10];
                        audioSource.Play();
                        break;
                    case "black_12":
                        audioSource.clip = blackAudioClips[11];
                        audioSource.Play();
                        break;
                    case "black_13":
                        audioSource.clip = blackAudioClips[12];
                        audioSource.Play();
                        break;
                    case "black_14":
                        audioSource.clip = blackAudioClips[13];
                        audioSource.Play();
                        break;
                    case "black_15":
                        audioSource.clip = blackAudioClips[14];
                        audioSource.Play();
                        break;
                    case "black_16":
                        audioSource.clip = blackAudioClips[15];
                        audioSource.Play();
                        break;
                    case "black_17":
                        audioSource.clip = blackAudioClips[16];
                        audioSource.Play();
                        break;
                    case "black_18":
                        audioSource.clip = blackAudioClips[17];
                        audioSource.Play();
                        break;
                    case "black_19":
                        audioSource.clip = blackAudioClips[18];
                        audioSource.Play();
                        break;
                    case "black_20":
                        audioSource.clip = blackAudioClips[19];
                        audioSource.Play();
                        break;
                    case "black_21":
                        audioSource.clip = blackAudioClips[20];
                        audioSource.Play();
                        break;
                    case "black_22":
                        audioSource.clip = blackAudioClips[21];
                        audioSource.Play();
                        break;
                    case "black_23":
                        audioSource.clip = blackAudioClips[22];
                        audioSource.Play();
                        break;
                    case "black_24":
                        audioSource.clip = blackAudioClips[23];
                        audioSource.Play();
                        break;
                    case "black_25":
                        audioSource.clip = blackAudioClips[24];
                        audioSource.Play();
                        break;

                    // White Keys
                    case "white_01":
                        playKeyTone(false, 1);
                        break;
                    case "white_02":
                        playKeyTone(false, 2);
                        break;
                    case "white_03":
                        playKeyTone(false, 3);
                        break;
                    case "white_04":
                        playKeyTone(false, 4);
                        break;
                    case "white_05":
                        playKeyTone(false, 5);
                        break;
                    case "white_06":
                        playKeyTone(false, 6);
                        break;
                    case "white_07":
                        playKeyTone(false, 7);
                        break;
                    case "white_08":
                        playKeyTone(false, 8);
                        break;
                    case "white_09":
                        playKeyTone(false, 9);
                        break;
                    case "white_10":
                        playKeyTone(false, 10);
                        break;
                    case "white_11":
                        playKeyTone(false, 11);
                        break;
                    case "white_12":
                        playKeyTone(false, 12);
                        break;
                    case "white_13":
                        playKeyTone(false, 13);
                        break;
                    case "white_14":
                        playKeyTone(false, 14);
                        break;
                    case "white_15":
                        playKeyTone(false, 15);
                        break;
                    case "white_16":
                        playKeyTone(false, 16);
                        break;
                    case "white_17":
                        playKeyTone(false, 17);
                        break;
                    case "white_18":
                        playKeyTone(false, 18);
                        break;
                    case "white_19":
                        playKeyTone(false, 19);
                        break;
                    case "white_20":
                        playKeyTone(false, 20);
                        break;
                    case "white_21":
                        playKeyTone(false, 21);
                        break;
                    case "white_22":
                        playKeyTone(false, 22);
                        break;
                    case "white_23":
                        playKeyTone(false, 23);
                        break;
                    case "white_24":
                        playKeyTone(false, 24);
                        break;
                    case "white_25":
                        playKeyTone(false, 25);
                        break;
                    case "white_26":
                        playKeyTone(false, 26);
                        break;
                    case "white_27":
                        playKeyTone(false, 27);
                        break;
                    case "white_28":
                        playKeyTone(false, 28);
                        break;
                    case "white_29":
                        playKeyTone(false, 29);
                        break;
                    case "white_30":
                        playKeyTone(false, 30);
                        break;
                    case "white_31":
                        playKeyTone(false, 31);
                        break;
                    case "white_32":
                        playKeyTone(false, 32);
                        break;
                    case "white_33":
                        playKeyTone(false, 33);
                        break;
                    case "white_34":
                        playKeyTone(false, 34);
                        break;
                    case "white_35":
                        playKeyTone(false, 35);
                        break;
                    case "white_36":
                        playKeyTone(false, 36);
                        break;

                    // Deafult check
                    case "A":
                        audioSource.clip = blackAudioClips[4];
                        audioSource.Play();
                        break;
                    default:
                        break;
                }
            }
        }
    }

    private void playKeyTone(bool isBlackKey, int keyNumber)
    {
        if (true)
        {
            audioSource.clip = blackAudioClips[keyNumber - 1];
        }
        else
        {
            audioSource.clip = whiteAudioClips[keyNumber - 1];
        }
        
        audioSource.Play();
    }
}
