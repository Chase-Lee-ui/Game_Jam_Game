using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public int healthMax = 3;
    [SerializeField] public int healthCurrent;

    [SerializeField] public Image healthbar;
    [SerializeField] public Sprite health_0;
    [SerializeField] public Sprite health_1;
    [SerializeField] public Sprite health_2;
    [SerializeField] public Sprite health_3;

    // Update is called once per frame
/*    void Update() {
        if (healthCurrent >= 3) {
            healthbar.sprite = health_3;
        } else if (healthCurrent == 2) {
            healthbar.sprite = health_2;
        } else if (healthCurrent == 1) {
            healthbar.sprite = health_1;
        } else {
            healthbar.sprite = health_0;
            FindObjectOfType<GameOver>().DoGameOver();
            healthCurrent = -1;
        }
    }*/

    public void SubHealth() {
        healthCurrent--;

        if (healthCurrent >= 3) {
            healthbar.sprite = health_3;
        } else if (healthCurrent == 2) {
            healthbar.sprite = health_2;
        } else if (healthCurrent == 1) {
            healthbar.sprite = health_1;
        } else {
            healthbar.sprite = health_0;
            FindObjectOfType<GameOver>().DoGameOver();
            healthCurrent = -1;
        }
    }
}
