using UnityEngine;
using UnityEngine.UI;

public class UpgradeButtonUI : MonoBehaviour
{
    private Button btn;
    private GameManager GM;

    private void Awake() {
        btn = GetComponent<Button>();
        GM = FindObjectOfType<GameManager>();
    }

    private void Update() {
        ToggleActiveButton();
    }

    private void ToggleActiveButton(){
        btn.interactable = GM.wallet > 200f;
    }
}
