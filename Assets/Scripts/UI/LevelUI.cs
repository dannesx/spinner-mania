using UnityEngine;
using UnityEngine.UI;

public class LevelUI : MonoBehaviour
{
    private Text txt;
    private GameManager GM;

    private void Awake() {
        txt = GetComponent<Text>();
        GM = FindObjectOfType<GameManager>();
    }

    private void Update() {
        txt.text = "LV. " + GM.level.ToString("00");
    }
}
