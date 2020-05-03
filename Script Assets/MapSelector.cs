using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapSelector : MonoBehaviour{

    [SerializeField] private GameObject map1;
    [SerializeField] private GameObject map2;
    [SerializeField] private GameObject map3;



    void Start(){
        var mapNum = Random.Range(1,4);

        switch (mapNum){
            case 1:
                map1.SetActive(true);
                map2.SetActive(false);
                map3.SetActive(false);
                break;

            case 2:
                map1.SetActive(false);
                map2.SetActive(true);
                map3.SetActive(false);
                break;

            case 3:
                map1.SetActive(false);
                map2.SetActive(false);
                map3.SetActive(true);
                break;

            default:
                map1.SetActive(true);
                map2.SetActive(false);
                map3.SetActive(false);
                break;
        }
        
    }
}
