using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject _bulletprefab;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(shoot());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator shoot()
    {
        while (true)
        {
            Instantiate(_bulletprefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(3f);

        }
    }
}
