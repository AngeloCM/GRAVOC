using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalShotSpawner : ProjectileSpawner
{

    // Update is called once per frame
    void Update()
    {
        base.addDeadProjectilesToRemoveList();
        base.removeObjectInListToRemove();
    }

    public void SpawnTheObject()
    {
        this.Spawn();
    }
}
