using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour
{    
    [SerializeField] Transform roadParent;
    [SerializeField] Transform road;
    [SerializeField] Transform newRoad;    
    [SerializeField] public float roadPassingSpeed;
    
    private void OnEnable() {
        roadPassingSpeed = 1;
        
    }

    public void RespawnRoad(){
        newRoad = Instantiate(road, new Vector2(0,16),Quaternion.identity);
        newRoad.name = "OffscreenRoad";
        newRoad.SetParent(roadParent);
    }

    

    // Update is called once per frame
    void Update()
    {        
        if(roadPassingSpeed < 10){
             roadPassingSpeed += Time.deltaTime;
             //print(roadPassingSpeed.ToString());
         }        
        if(road.transform.position.y <= GameManager.UPPER_BOUND && newRoad == null){
            //print("Spawn new Road");
            RespawnRoad();            
        }
        if(road.transform.position.y <= GameManager.LOWER_BOUND){
            Destroy(road.gameObject);
            road = newRoad;
            road.SetParent(roadParent);
            road.name = "ActiveRoad";
            newRoad = null;
        }
    }
}
