using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsHandler : MonoBehaviour
{
    [SerializeField] GameObject shurikenPrefab;
    [SerializeField] Transform shurikenSpawnLocation;


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            InstantiateShuriken();
        }
    }

    public void InstantiateShuriken()
    {
        GameObject shurikenObj = Instantiate(shurikenPrefab, shurikenSpawnLocation.position, Quaternion.identity);
        Vector2 direction = transform.right;
        Debug.Log($"{transform.localScale.x}");
        if (transform.localScale.x < 0) direction = -transform.right;
        shurikenObj.GetComponent<Move>().direction = direction;   
    }
}
