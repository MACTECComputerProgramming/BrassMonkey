using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int xPos = 100;
    private bool creatingSection = false;
    private int sectionNum;
    public int wait;


    // Update is called once per frame
    void Update()
    {
        if (creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());

        }
    }

    IEnumerator GenerateSection()
    {
        sectionNum = Random.Range(0, section.Length);
        Instantiate(section[sectionNum], new Vector3(xPos, 0, 0), Quaternion.identity);

        xPos += 100;
        
        yield return new WaitForSeconds(wait);
        creatingSection = false;
    }

}
