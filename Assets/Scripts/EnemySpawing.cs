using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawing : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] enemies;
    public Stack<GameObject> enemyspawn = new Stack<GameObject>();
    float time;
    void Start()
    {
        //SpawnEnemy();
        CreateEnemyStack();
    }

    private void CreateEnemyStack()
    {
        for (int i = 0; i < 3; i++)
        {
            foreach (var item in enemies)
            {
                enemyspawn.Push(Instantiate(item));
                item.SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
       
        time = Time.deltaTime + time;
        if (time>4f)
        {
            SpawnEnemy();
            
            time = 0f;
        }
        
        
    }

    private void SpawnEnemy()
    {

        GameObject enemy = enemyspawn.Pop();
        //Instantiate(enemy, new Vector3(Random.Range(-1f, 2f), enemy.transform.position.y, 0f), Quaternion.identity);
        enemy.SetActive(true);
        enemy.transform.position = new Vector3(Random.Range(2f, 6.5f), enemy.transform.position.y, 0f);
    }
    public void BackToStack(GameObject obj)
    {
        enemyspawn.Push(obj);
        obj.SetActive(false);
    }

}
