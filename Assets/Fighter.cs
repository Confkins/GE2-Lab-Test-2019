using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : MonoBehaviour
{
    public int tiberium = 7;
    public GameObject bulletPrefab;
    public GameObject origin;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(bulletFactory());
    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator bulletFactory()
    {
        while (tiberium > 0)
        {
            yield return new WaitForSeconds(1);
            makeBullet();
        }

    }

    void makeBullet()
    {
        GameObject.Instantiate(bulletPrefab, transform.position, transform.rotation);
        tiberium = tiberium - 1;
    }
}
