using UnityEngine;
using UnityEngine.UI;

public class WalletUI : MonoBehaviour
{
    private Text walletTXT;
    private GameManager GM;

    private void Awake() {
        walletTXT = GetComponent<Text>();
        GM = FindObjectOfType<GameManager>();
    }

    private void LateUpdate() {
        walletTXT.text = "$ " + Mathf.FloorToInt(GM.wallet).ToString("N0");
    }
}
