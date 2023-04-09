using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource audioSrc;
    public AudioClip click;
    public AudioClip upgrade;

    private Spinner spinner;
    private float audioTimer = 0f;
    private float audioInterval = 0.1f;

    private void Awake() {
        audioSrc = GetComponent<AudioSource>();
        spinner = FindObjectOfType<Spinner>();
    }
    
    private void Update() {
        audioInterval = 1f / (spinner.speed * 0.5f + 1f);

        audioTimer += Time.deltaTime;
        if(audioTimer >= audioInterval){
            ClickSFX();
            audioTimer = 0f;
        }
    }

    public void ClickSFX(){
        if(spinner.speed > 1f){
            audioSrc.PlayOneShot(click);
        }
    }
    
    public void UpgradeSFX(){
        audioSrc.PlayOneShot(upgrade);
    }
}
