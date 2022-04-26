using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NematodeSchool : MonoBehaviour
{
    public GameObject prefab;

    [Range (1, 5000)]
    public int radius = 50;
    
    public int count = 10;
    public Vector3 firstNematode;
    // Start is called before the first frame update
    void Awake()
    {
        for(int i=0;i<count;i++)
        {
            firstNematode.x = Random.Range(0,radius);
            firstNematode.y = Random.Range(0, radius);
            firstNematode.z = Random.Range(0, radius);
            GameObject nematodes = Instantiate(prefab ,firstNematode , Quaternion.Euler(0, 0, 0));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
