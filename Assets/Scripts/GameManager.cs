using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject health;
    public GameObject skillBar;
    public int hitCount = 6;
    public float rage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FloorBuilder(5);
    }

    public void RoomBuilder(bool slasher, bool pistolman, bool shotgunner, bool demoman, int size, string setting){
        Debug.Log("Generating room...");
    }

    public void FloorBuilder(int size){
        int length = 0;
        Debug.Log("Building floor...");
        while (length<=size){
            bool slashers = Random.value > 0.5f;
            bool pistolmen = Random.value > 0.5f;
            bool shotgunners = Random.value > 0.5f;
            bool demomen = Random.value > 0.5f;
            int roomSize = Random.Range(1,size+1);
            RoomBuilder(slashers,pistolmen,shotgunners,demomen,size,"theater");
            length += roomSize;
            size -= roomSize;
        }
    }
}
