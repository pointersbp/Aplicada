using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private void Awake() {
        // Debug.Break();
    }
    //Game Bounds
    // Upper : 5
    // Lower : -5
    // Left : -2.6
    // Right : 2.6

    public const int UPPER_BOUND = 5;
    public const int LOWER_BOUND = -5;
    public const double LEFT_BOUND = -2.6;
    public const double RIGHT_BOUND = 2.6;

    [Header("Management Script References")]
    [SerializeField] public UIManager uIManager;
    [SerializeField] public ScoreManager scoreManager;
    [SerializeField] private GameManager myGM;
    [SerializeField] public RoadManager roadManager;
       
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
