using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Spinner spinner;
    public float wallet;
    public int level = 1;

    [Range(0f, 0.2f)]
    public float tax;

    private void Awake() {
        spinner = FindObjectOfType<Spinner>();
    }

    private void Update() {
        AddWallet();
    }

    private void AddWallet(){
        wallet += spinner.speed * tax;
    }

    public void Upgrade(){
        wallet -= 200f;
        tax += 0.005f;
        level++;
    }
}
