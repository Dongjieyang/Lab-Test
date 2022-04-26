using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nematode : MonoBehaviour
{
    public int length = 5;
    public Vector3 sizeSegment;
    public int nematodeDensity;

    public Material material;

    public GameObject spheresPrefab;

    public Vector3 firstSegment;
    private int rotate_x;
    private int rotate_y;
    private int rotate_z;
    void Awake()
    {
        for( int i =0;i<length;i++)
        {
            firstSegment.x +=1.1f;

            rotate_x += Random.Range(10,20);
        
            rotate_y += Random.Range(10, 20);

            rotate_z += Random.Range(10, 20);
            if (i <= length / 2)
            {
                sizeSegment.x += 0.2f;
                sizeSegment.y += 0.2f;
                sizeSegment.z += 0.2f;
            }
            if(i>=length/2)
            {
                sizeSegment.x -= 0.2f;
                sizeSegment.y -= 0.2f;
                sizeSegment.z -= 0.2f;
            }
            spheresPrefab.transform.localScale = sizeSegment;

            GameObject nematode = Instantiate(spheresPrefab,firstSegment,Quaternion.Euler(rotate_x,rotate_y,rotate_z));
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
