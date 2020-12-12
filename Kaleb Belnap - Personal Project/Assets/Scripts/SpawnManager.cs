using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] alienPrefabs;
  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
            int alienIndex = Random.Range(0, 3);

            Instantiate(alienPrefabs[alienIndex], new Vector3(0, 30, 3), alienPrefabs[alienIndex].transform.rotation);
        }
    }
}
