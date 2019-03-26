using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEditor;

public class Base : MonoBehaviour
{
    public float tiberium = 0;

    public TextMeshPro text;

    public GameObject fighterPrefab;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(tiberiumFactory());
        foreach (Renderer r in GetComponentsInChildren<Renderer>())
        {
            r.material.color = Color.HSVToRGB(Random.Range(0.0f, 1.0f), 1, 1);
        }
        
    }

    public IEnumerator tiberiumFactory()
    {
        while(tiberium < 100)
        {
            yield return new WaitForSeconds(1);
            tiberium = tiberium + 1;
        }    
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "" + tiberium;
        if(tiberium == 10)
        {
            makeFighter();
        }
    }

    void makeFighter()
    {
        GameObject.Instantiate(fighterPrefab,transform.position, transform.rotation);
        tiberium = tiberium - 10;
    }
}
