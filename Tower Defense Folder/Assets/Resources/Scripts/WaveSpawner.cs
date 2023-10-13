using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public float timeBetweenWaves = 5f;
    public TextMeshProUGUI waveCountDownText;
    public Transform spawnPoint;

    private float countdown = 5f;

    private int waveIndex = 0;

    void Update(){
        if (countdown<=0f){
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }
        countdown -= Time.deltaTime;
        waveCountDownText.text = Mathf.Round(countdown).ToString();
    }

    IEnumerator SpawnWave(){
        // Debug.console("Starting wave!");
        for (int i=0; i<waveIndex; i++){
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
        waveIndex++;
    }

    void SpawnEnemy(){
        Instantiate(enemyPrefab,spawnPoint.position, spawnPoint.rotation);
    }
}
