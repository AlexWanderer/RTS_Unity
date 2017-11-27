using UnityEngine;
using System.Collections;

public class BuildingBehavior : MonoBehaviour {
    public float HeroSpawnTime = 4.0f;
    public GameObject HeroRef;

    private bool heroBuilding;
    private float heroBuildTimer = 0f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            heroBuildTimer = 0;
            heroBuilding = true;
        }
        else if (heroBuilding)
        {
            HeroSpawnTime += Time.deltaTime;
            if (heroBuildTimer >= HeroSpawnTime) { SpawnHero(); }
        }
    }
    public void SpawnHero()
    {
        GameObject hero = GameObject.Instantiate<GameObject>(HeroRef);
        hero.transform.position = new Vector3(2f, 0, 2f) + gameObject.transform.position;
        heroBuildTimer = 0f;
        heroBuilding = false;
    }
}