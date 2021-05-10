using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPoints : MonoBehaviour
{
    public int points;
    // Start is called before the first frame update
    void Start()
    {
        points = 0;
        UpdateHUD();
    }
    public void Damage(int damage)
    {
        points += damage;
        UpdateHUD();
    }
    public void UpdateHUD()
    {
        //   GameObject.Find("Canvas - HUD").GetComponent<HUDManager>().SetPlayersPoints(points);
        GameObject canvas = GameObject.Find("Canvas - HUD");
        HUDManager hudManager = canvas.GetComponent<HUDManager>();
        hudManager.SetPlayersPoints(points);
    }
   
}
