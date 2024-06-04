using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    [SerializeField] private GameObject itemPrefab;
    [SerializeField] private GameObject itemSpawnPos;

    [SerializeField] private float spawnRange;
    [SerializeField] private float spawnSpan;

    private Item item;

    private void Start()
    {
        item = new(spawnRange, spawnSpan, itemSpawnPos, itemPrefab);
    }

    private void Update()
    {
        item.SpawnItem();
    }

    class Item
    {
        private float spawnTime = 0f;
        private readonly float spawnRange;
        private readonly float spawnSpan;
        private readonly GameObject itemSpawnPos;
        private readonly GameObject itemPrefab;

        public Item(float spawnRange, float spawnSpan, GameObject itemSpawnPos, GameObject itemPrefab)
        {
            this.spawnRange = spawnRange;
            this.spawnSpan = spawnSpan;
            this.itemSpawnPos = itemSpawnPos;
            this.itemPrefab = itemPrefab;
        }

        public void SpawnItem()
        {
            spawnTime += 1f * Time.deltaTime;

            float spawnAreax = Random.Range(0 - spawnRange, 0 + spawnRange);
            float spawnAreaz = Random.Range(0 - spawnRange, 0 + spawnRange);

            if (spawnTime > spawnSpan)
            {
                Vector3 spawnAreaPos = itemSpawnPos.transform.position;
                Instantiate(itemPrefab, new(spawnAreaPos.x + spawnAreax, spawnAreaPos.y, spawnAreaPos.z + spawnAreaz), Quaternion.identity);
                spawnTime = 0f;
            }
        }
    }
}
