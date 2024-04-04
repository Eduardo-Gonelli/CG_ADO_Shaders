using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class Exemplo : MonoBehaviour
{
    GameObject[] enemies;
    float maxDistance = 10f;
    void Start()
    {
        var nearbyEnemies = enemies.Where(enemy => {
            float distance = Vector3.Distance(transform.position, enemy.transform.position);
            return distance < maxDistance;
        });    
    }    
}